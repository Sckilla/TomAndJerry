using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace winTomyJerry
{
    class clsTomyJerry
    {
        public bool objetivo = false;
        public string[,] espacio;
        struct celda
        {
            public int fila;
            public int columna;
        }
        struct obstaculo
        {
            public celda supizq;//superior izquierda
            public celda infder;//superior derecha
        }
        int N;//COLUMNAS
        int M;//FILAS
        celda TOM;
        celda JERRY;
        List<obstaculo> OBST;
        List<int> clibres;
        List<string> caminos;
        List<int> costo;
        public clsTomyJerry()
        {
            N = 0;
            M = 0;
            TOM = new celda();
            JERRY = new celda();
            OBST = new List<obstaculo>();
            clibres = new List<int>();
            caminos = new List<string>();
            costo = new List<int>();
        }
        ~clsTomyJerry()
        {
            if (OBST.Count > 0)
            {
                OBST.Clear();
            }
            if (clibres.Count > 0)
            {
                clibres.Clear();
            }
            if (caminos.Count > 0)
            {
                caminos.Clear();
            }
            if (costo.Count > 0)
            {
                costo.Clear();
            }
        }
        public int n
        {
            get { return N; }
            set { N = value; }
        }//lee y modifica el número de columnas
        public int m
        {
            get { return M; }
            set { M = value; }
        }//lee y modifica el número de flas
        public void definirPosTJ(int f1, int c1, int f2, int c2)//define la posicion de tom y de jerry
        {
            TOM.fila = f1;
            TOM.columna = c1;
            JERRY.fila = f2;
            JERRY.columna = c2;
        }
        public void genObstaculo(int f1, int c1, int f2, int c2)
        {
            celda si = new celda { fila = f1, columna = c1 };
            celda id = new celda { fila = f2, columna = c2 };
            obstaculo obstcl = new obstaculo { supizq = si, infder = id };
            OBST.Add(obstcl);
        }//Genera un obstáculo
        public int crearArchivoIN()
        {
            StreamWriter wr;
            int nomarch = crearNombre();
            wr = File.CreateText("TOM" + nomarch.ToString() + ".DAT");
            wr.WriteLine(M.ToString() + " " + N.ToString());
            wr.WriteLine(TOM.fila.ToString() + " " + TOM.columna.ToString() + " " + JERRY.fila.ToString() + " " + JERRY.columna.ToString());
            for (int i = 0; i < OBST.Count; i++) 
            {
                wr.WriteLine(OBST[i].supizq.fila.ToString() + " " + OBST[i].supizq.columna.ToString() + " " + OBST[i].infder.fila.ToString() + " " + OBST[i].infder.columna.ToString());
            }
            wr.Close();
            return nomarch;
        }
        int crearNombre()
        {
            int cnt = 0;
            do
            {
                cnt++;
            } while (File.Exists("TOM" + cnt.ToString() + ".DAT"));
            return cnt;
        }
        public int leerArchivoIN(string nomarch)
        {
            borrarDatos(0);
            StreamReader r;
            string aux = "";
            string[] datos;
            try
            {
                r = File.OpenText(nomarch);
                aux = r.ReadLine();
                datos = aux.Split(' ');
                M = int.Parse(datos[0]);
                N = int.Parse(datos[1]);
                aux = r.ReadLine();
                datos = aux.Split(' ');
                TOM.fila = int.Parse(datos[0]);
                TOM.columna = int.Parse(datos[1]);
                JERRY.fila = int.Parse(datos[2]);
                JERRY.columna = int.Parse(datos[3]);
                aux = r.ReadLine();
                while (aux != null)
                {
                    datos = aux.Split(' ');
                    celda c1 = new celda { fila = int.Parse(datos[0]), columna = int.Parse(datos[1]) };
                    celda c2 = new celda { fila = int.Parse(datos[2]), columna = int.Parse(datos[3]) };
                    obstaculo o = new obstaculo { supizq = c1, infder = c2 };
                    OBST.Add(o);
                    aux = r.ReadLine();
                }
                generarEspacio();
                r.Close();
            }
            catch(FileNotFoundException)
            {
                return 0;//no se encontró el archivo
            }
            catch
            {
                return 1;//ocurrió un error al leer el archivo
            }
            return -1;
        }
        public int crearArchivoOUT(int narch)
        {
            int val = validacionE();
            StreamWriter wr = File.CreateText("TOM" + narch.ToString() + ".RES");
            if (val == -1)
            {
                generarEspacio();             
                for(int i = 0; i < espacio.GetLength(0); i++)
                {
                    string linea = "";
                    for(int j = 0; j < espacio.GetLength(1); j++)
                    {
                        linea = linea + espacio[i, j] + " ";
                    }
                    wr.WriteLine(linea);
                }
            }
            else
            {
                wr.Write("ERROR E" + val.ToString());
            }
            wr.Close();
            return val;
        }
        public void borrarDatos(int obst)
        {
            if (obst == 0)
            {
                N = 0;
                M = 0;
                TOM = new celda();
                JERRY = new celda();
                clibres = new List<int>();
                caminos = new List<string>();
                costo = new List<int>();
            }
            OBST = new List<obstaculo>();
            objetivo = false;
        }//Reinicia los datos si obst =1 solo borra obstáculos
        int validacionE()
        {
            //(E0) M o N (o ambas) son igual a 0. 
            //(E1) Tom o Jerry no se encuentran en coordenadas válidas de la superficie de la casa. 
            //(E2) Tom y Jerry están en la misma casilla. 
            //(E3) Algún obstáculo no está situado en coordenadas válidas de la superficie. 
            //(E4) Los vértices que representan un obstáculo no cumplen una relación válida entre sí. 
            //(E5) Dos o más obstáculos se solapan. 
            //(E6) Tom o Jerry están en una casilla ocupada por un obstáculo.
            if (M <= 0 || N <= 0)
            {
                return 0;
            }
            if (TOM.fila < 1 || TOM.fila > M || TOM.columna < 1 || TOM.columna > N || JERRY.fila < 1 || JERRY.fila > M || JERRY.columna < 1 || JERRY.columna > N)
            {
                return 1;
            }
            if (TOM.fila == JERRY.fila && TOM.columna == JERRY.columna)
            {
                return 2;
            }
            for (int i = 0; i < OBST.Count; i++)
            {
                if (OBST[i].supizq.fila < 1 || OBST[i].supizq.fila > M || OBST[i].supizq.columna < 1 || OBST[i].supizq.columna > N || OBST[i].infder.fila < 1 || OBST[i].infder.fila > M || OBST[i].infder.columna < 1 || OBST[i].infder.columna > N)
                {
                    return 3;
                }
            }
            for (int i = 0; i < OBST.Count; i++)
            {
                if (OBST[i].supizq.fila > OBST[i].infder.fila || OBST[i].supizq.columna > OBST[i].infder.columna)
                {
                    return 4;
                }
            }
            for (int i = 0; i < OBST.Count; i++)
            {
                for (int j = i+1; j < OBST.Count; j++)
                {
                    if (OBST[i].infder.fila >= OBST[j].supizq.fila && OBST[i].infder.columna >= OBST[j].supizq.columna && OBST[i].supizq.fila <= OBST[j].infder.fila && OBST[i].supizq.columna <= OBST[j].infder.columna)
                    {
                        return 5;
                    }
                }
            }
            for (int i = 0; i < OBST.Count; i++)
            {
                if (OBST[i].infder.fila >= TOM.fila && OBST[i].infder.columna >= TOM.columna && OBST[i].supizq.fila <= TOM.fila && OBST[i].supizq.columna <= TOM.columna)
                {
                    return 6;
                }
                if (OBST[i].infder.fila >= JERRY.fila && OBST[i].infder.columna >= JERRY.columna && OBST[i].supizq.fila <= JERRY.fila && OBST[i].supizq.columna <= JERRY.columna)
                {
                    return 6;
                }
            }
            return -1;//no exixten errores
        }
        void generarEspacio()
        {
            espacio = new string[M, N];
            espacio[TOM.fila - 1, TOM.columna - 1] = "T";
            espacio[JERRY.fila - 1, JERRY.columna - 1] = "J";
            for (int i = 0; i < OBST.Count; i++)
            {
                for (int j = OBST[i].supizq.fila; j <= OBST[i].infder.fila; j++)
                {
                    for (int k = OBST[i].supizq.columna; k <= OBST[i].infder.columna; k++)
                    {
                        espacio[j - 1, k - 1] = "X";
                    }
                }
            }
            for (int i = 0; i < espacio.GetLength(0); i++)
            {
                for (int j = 0; j < espacio.GetLength(1); j++)
                {
                    if (espacio[i, j] == null)
                    {
                        espacio[i, j] = "O";
                    }
                }
            }
        }
        void obtCeldasLib()//llena la lista con las celdas por las que sí se puede pasar
        {
            clibres = new List<int>();
            int id = 0;
            for (int i = 0; i < espacio.GetLength(0); i++)
            {
                for (int j = 0; j < espacio.GetLength(1); j++)
                {
                    if(espacio[i, j] == "O"|| espacio[i, j] == "J")
                    {
                        clibres.Add(id);
                    }
                    id++;
                }
            }
        }
        public List<string> generarCaminos()//control de la generación de caminos
        {
            objetivo = false;
            obtCeldasLib();
            caminos = new List<string>();
            int Tom = (TOM.fila - 1) * N + TOM.columna - 1;
            int Jerry = (JERRY.fila - 1) * N + JERRY.columna - 1;
            caminos.Add(Tom.ToString());
            costo.Add(0);
            avanzar(Tom, Jerry, 0);
            if (costo.Count > 0)
            {
                quickSort(0, costo.Count - 1);
            }  
            return caminos;
        }
        void avanzar(int Tom, int Jerry, int nl)//nl=posicion del camino en la lista
        {
            int cantcam = 0;//indica si hay más de un camino dentro del análisis!!!!!
            string camact = caminos[nl];
            List<string> lcamact = camact.Split(' ').ToList<string>();
            int costact = costo[nl];
            if (Jerry == int.Parse(lcamact[lcamact.Count - 1]))
            {
                objetivo = true;
                costo[nl] = costo[nl] * -1;//le da su valor en negativo para llevarlo hasta arriba de la lista en el quicksort y no seguir con ese camino
                if (nl < caminos.Count - 1)
                {
                    lcamact = caminos[nl + 1].Split(' ').ToList<string>();
                    avanzar(int.Parse(lcamact[lcamact.Count - 1]), Jerry, nl + 1);
                }
                return;
            }
            int CT = 1 + Tom % N;
            int FT = 1 + (Tom - CT + 1) / N;
            int CJ = 1 + Jerry % N;
            int FJ = 1 + (Jerry - CJ + 1) / N;
            //HACER QUE TOM SE DIRIJA SEGÚN LA POSICION DE JERRY
            if (CJ > CT && FJ > FT) //CUADRANTE 4
            {
                if (CJ - CT > FJ - FT)
                {
                    cantcam = derecha(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = abajo(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = izquierda(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = arriba(Tom, cantcam, lcamact, nl, camact, costact);
                }
                else
                {
                    cantcam = abajo(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = derecha(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = izquierda(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = arriba(Tom, cantcam, lcamact, nl, camact, costact);                   
                }
            }
            else if (CJ > CT && FJ < FT)//CUADRANTE 1
            {
                if (CJ - CT > FT - FJ)
                {
                    cantcam = derecha(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = arriba(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = abajo(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = izquierda(Tom, cantcam, lcamact, nl, camact, costact);
                }
                else
                {
                    cantcam = arriba(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = derecha(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = abajo(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = izquierda(Tom, cantcam, lcamact, nl, camact, costact);
                }
            }
            else if (CJ < CT && FJ < FT)//CUADRANTE 2
            {
                if (CT - CJ > FT - FJ)
                {
                    cantcam = izquierda(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = arriba(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = derecha(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = abajo(Tom, cantcam, lcamact, nl, camact, costact);
                }
                else
                {
                    cantcam = arriba(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = izquierda(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = derecha(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = abajo(Tom, cantcam, lcamact, nl, camact, costact);
                }
            }
            else if (CJ < CT && FJ > FT)//CUADRANTE 3
            {
                if (CT - CJ > FJ - FT)
                {
                    cantcam = izquierda(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = abajo(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = arriba(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = derecha(Tom, cantcam, lcamact, nl, camact, costact);
                }
                else
                {
                    cantcam = abajo(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = izquierda(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = arriba(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = derecha(Tom, cantcam, lcamact, nl, camact, costact);
                }
            }
            else if(CJ == CT && FJ != FT)//eje y 
            {
                if (FT > FJ)
                {
                    cantcam = arriba(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = abajo(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = derecha(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = izquierda(Tom, cantcam, lcamact, nl, camact, costact);
                }
                else
                {
                    cantcam = abajo(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = arriba(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = derecha(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = izquierda(Tom, cantcam, lcamact, nl, camact, costact);
                }               
            }
            else if (CJ != CT && FJ == FT)//eje x
            {
                if (CJ > CT)
                {
                    cantcam = derecha(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = izquierda(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = abajo(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = arriba(Tom, cantcam, lcamact, nl, camact, costact);
                }
                else
                {
                    cantcam = izquierda(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = derecha(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = abajo(Tom, cantcam, lcamact, nl, camact, costact);
                    cantcam = arriba(Tom, cantcam, lcamact, nl, camact, costact);
                }
            }
            else
            {
                cantcam = derecha(Tom, cantcam, lcamact, nl, camact, costact);
                cantcam = abajo(Tom, cantcam, lcamact, nl, camact, costact);
                cantcam = izquierda(Tom, cantcam, lcamact, nl, camact, costact);
                cantcam = arriba(Tom, cantcam, lcamact, nl, camact, costact);
            }

            if (cantcam == 0)
            {
                caminos.RemoveAt(nl);
                costo.RemoveAt(nl);
            }
            if (costo.Count > 1)
            {
                quickSort(0, costo.Count - 1);
            }
            if (nl <= caminos.Count - 1)
            {
                lcamact = caminos[nl].Split(' ').ToList<string>();
                avanzar(int.Parse(lcamact[lcamact.Count - 1]), Jerry, nl);
            }
        }
        int derecha(int Tom, int cantcam,List<string>lcamact,int nl,string camact, int costact)
        {
            int sig = 0;
            if ((Tom + 1) % N != 0)//derecha
            {
                if (clibres.IndexOf(Tom + 1) != -1)
                {
                    sig = Tom + 1;
                    cantcam = sigcelda(lcamact, sig, cantcam, nl, camact, costact);
                }
            }
            return cantcam;
        }
        int izquierda(int Tom, int cantcam, List<string> lcamact, int nl, string camact, int costact)
        {
            int sig = 0;
            if (Tom % N != 0)//izquierda
            {
                if (clibres.IndexOf(Tom - 1) != -1)
                {
                    sig = Tom - 1;
                    cantcam = sigcelda(lcamact, sig, cantcam, nl, camact, costact);
                }
            }
            return cantcam;
        }
        int abajo(int Tom, int cantcam, List<string> lcamact, int nl, string camact, int costact)
        {
            int sig = 0;
            if ((Tom / N) < (M - 1))//abajo
            {
                if (clibres.IndexOf(Tom + N) != -1)
                {
                    sig = Tom + N;
                    cantcam = sigcelda(lcamact, sig, cantcam, nl, camact, costact);
                }
            }
            return cantcam;
        }
        int arriba(int Tom, int cantcam, List<string> lcamact, int nl, string camact, int costact)
        {
            int sig = 0;
            if (Tom >= N)//arriba
            {
                if (clibres.IndexOf(Tom - N) != -1)
                {
                    sig = Tom - N;
                    cantcam = sigcelda(lcamact, sig, cantcam, nl, camact, costact);
                }
            }
            return cantcam;
        }
        int sigcelda(List<string> lcamact, int sig, int cantcam, int nl, string camact, int costact)
        {
            if (lcamact.IndexOf(sig.ToString()) == -1)//valida si ya se pasó por esa celda
            {
                if (cantcam == 0)
                {
                    caminos[nl] = camact + " " + sig.ToString();
                    costo[nl]++;
                }
                else
                {
                    if (caminos.Count < 30)
                    {
                        caminos.Add(camact + " " + sig.ToString());
                        costo.Add(costact + 1);
                    }
                }
                cantcam++;
            }
            return cantcam;
        }
        void quickSort(int inicio, int fin)
        {
            int i, f, central;
            double pivote;
            central = (inicio + fin) / 2;
            pivote = costo[central];
            i = inicio;
            f = fin;
            do
            {
                while (costo[i] < pivote) i++;
                while (costo[f] > pivote) f--;
                if (i <= f)
                {
                    int aux = costo[i];
                    costo[i] = costo[f];
                    costo[f] = aux;
                    string aux1 = caminos[i];
                    caminos[i] = caminos[f];
                    caminos[f] = aux1;
                    i++;
                    f--;
                }
            } while (i <= f);

            if (inicio < f)
            {
                quickSort(inicio, f);
            }
            if (i < fin)
            {
                quickSort(i, fin);
            }
        }
    }
}
