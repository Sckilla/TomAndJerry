using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winTomyJerry
{
    public partial class frmCaminoGráfico : Form
    {
        string[,] Espacio;
        List<string> Caminos;
        int x = 0, y = 0;
        PictureBox[,] imagen;
        string[] camino;
        int CT, FT, CJ, FJ, CONT;
        public frmCaminoGráfico(string[,] espacio, List<string> caminos)
        {
            Espacio = espacio;
            Caminos = caminos;
            InitializeComponent();
        }

        private void btnVerCamino_Click(object sender, EventArgs e)
        {
            btnVerCamino.Enabled = false;
            if (Caminos.Count > 0)
            {
                recorrerCamino(cmbCaminos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("No se encontraron caminos", "Vacío", MessageBoxButtons.OK);
            }
            
        }

        private void frmCaminoGráfico_Load(object sender, EventArgs e)
        {
            int h = 250, w = 215;
            h = 275 + 25 * Espacio.GetLength(0);
            if (Espacio.GetLength(1) > 4)
            {
                w = 25 * (Espacio.GetLength(1) + 4) + 15;//
                x = 50;
            }
            else
            {
                x = 12 * (8 - Espacio.GetLength(1));
            }
            y = 150;
            this.Height = h;
            this.Width = w;
            btnSalir.Left = w - 72;
            btnSalir.Top = h - 74;
            lblCosto.Top = h - 74;
            lblCosto.Left = 25;            
            for (int i = 1; i <= Caminos.Count; i++)
            {
                cmbCaminos.Items.Add(i);
            }
            if (cmbCaminos.Items.Count > 0)
            {
                cmbCaminos.SelectedIndex = 0;
            }
            if (Caminos.Count > 0)
            {
                recorrerCamino(0);
            }
            else
            {
                generarImg();
            }  
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            tmrAvanzar.Enabled = false;
            elimImg();
            Espacio = new string[0, 0];
            Caminos = null;
            camino = new string[0];
            this.Close();
        }

        private void cmbCaminos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tmrAvanzar_Tick(object sender, EventArgs e)
        {
            CT = 1 + int.Parse(camino[CONT]) % Espacio.GetLength(1);
            FT = 1 + (int.Parse(camino[CONT]) - CT + 1) / Espacio.GetLength(1);
            imagen[FT, CT].Image = Properties.Resources.Camino;
            CONT++;
            CT = 1 + int.Parse(camino[CONT]) % Espacio.GetLength(1);
            FT = 1 + (int.Parse(camino[CONT]) - CT + 1) / Espacio.GetLength(1);
            imagen[FT, CT].Image = Properties.Resources.Tom;
            if (CONT >= camino.Length - 2)
            {
                tmrAvanzar.Enabled = false;
                btnVerCamino.Enabled = true;
            }
        }
        void recorrerCamino(int ind)
        {
            if (camino == null)
            {
                generarImg();
            }
            regimg();
            camino = Caminos[Caminos.Count - ind - 1].Split(' ');
            CT = 1 + int.Parse(camino[0]) % Espacio.GetLength(1);
            FT = 1 + (int.Parse(camino[0]) - CT + 1) / Espacio.GetLength(1);
            CJ = 1 + int.Parse(camino[camino.Length-1]) % Espacio.GetLength(0);
            FJ = 1 + (int.Parse(camino[camino.Length - 1]) - CJ + 1) / Espacio.GetLength(1);
            CONT = 0;
            int lon = camino.Length - 2;
            lblCosto.Text = "Longitud: " + lon.ToString();
            tmrAvanzar.Enabled = true;
        }
        void regimg()
        {
            for (int i = 1, t = y; i <= Espacio.GetLength(0); i++, t += 25)
            {
                for (int j = 1, l = x; j <= Espacio.GetLength(1); j++, l += 25)
                {
                    switch (Espacio[i - 1, j - 1])
                    {
                        case "O":
                            imagen[i, j].Image = Properties.Resources.Libre;
                            break;
                        case "X":
                            imagen[i, j].Image = Properties.Resources.Obstáculo;
                            break;
                        case "T":
                            imagen[i, j].Image = Properties.Resources.Tom;
                            break;
                        case "J":
                            imagen[i, j].Image = Properties.Resources.Jerry;
                            break;
                    }
                }
            }
        }
        void generarImg()
        {
            imagen = new PictureBox[Espacio.GetLength(0) + 2, Espacio.GetLength(1) + 2];
            for (int i = 1, t = y; i <= Espacio.GetLength(0); i++, t += 25)
            {
                for (int j = 1, l = x; j <= Espacio.GetLength(1); j++, l += 25)
                {
                    imagen[i, j] = new PictureBox();
                    imagen[i, j].Name = "img" + (i).ToString() + (i).ToString();
                    imagen[i, j].Top = t;
                    imagen[i, j].Left = l;
                    imagen[i, j].Width = 25;
                    imagen[i, j].Height = 25;
                    switch (Espacio[i-1, j-1])
                    {
                        case "O":
                            imagen[i, j].Image = Properties.Resources.Libre;
                            break;
                        case "X":
                            imagen[i, j].Image = Properties.Resources.Obstáculo;
                            break;
                        case "T":
                            imagen[i, j].Image = Properties.Resources.Tom;
                            break;
                        case "J":
                            imagen[i, j].Image = Properties.Resources.Jerry;
                            break;
                    }
                    imagen[i, j].SizeMode = PictureBoxSizeMode.StretchImage;

                    imagen[i, j].Show();
                    imagen[i, j].Parent = this;
                    this.Controls.Add(imagen[i, j]);
                }
            }
            int id = x - 25;
            int ab = y - 25;
            for (int i = 0; i < imagen.GetLength(1) - 1; i++, id += 25)
            {
                imagen[0, i] = new PictureBox();
                imagen[0, i].Name = "img" + (i).ToString() + "A";
                imagen[0, i].Top = ab;
                imagen[0, i].Left = id;
                imagen[0, i].Width = 25;
                imagen[0, i].Height = 25;
                imagen[0, i].Image = Properties.Resources.Límite;

                imagen[0, i].SizeMode = PictureBoxSizeMode.StretchImage;

                imagen[0, i].Show();
                imagen[0, i].Parent = this;
                this.Controls.Add(imagen[0, i]);
            }
            int l0 = imagen.GetLength(1) - 1;
            for (int i = 0; i < imagen.GetLength(0) - 1; i++, ab += 25)
            {
                imagen[i,l0] = new PictureBox();
                imagen[i,l0].Name = "img" + (i).ToString() + "B";
                imagen[i,l0].Top = ab;
                imagen[i, l0].Left = id;
                imagen[i, l0].Width = 25;
                imagen[i, l0].Height = 25;
                imagen[i, l0].Image = Properties.Resources.Límite;

                imagen[i, l0].SizeMode = PictureBoxSizeMode.StretchImage;

                imagen[i, l0].Show();
                imagen[i, l0].Parent = this;
                this.Controls.Add(imagen[i, l0]);
            }
            for (int i = 0; i < imagen.GetLength(1) - 1; i++, id -= 25)
            {
                imagen[0, i] = new PictureBox();
                imagen[0, i].Name = "img" + (i).ToString() + "C";
                imagen[0, i].Top = ab;
                imagen[0, i].Left = id;
                imagen[0, i].Width = 25;
                imagen[0, i].Height = 25;
                imagen[0, i].Image = Properties.Resources.Límite;

                imagen[0, i].SizeMode = PictureBoxSizeMode.StretchImage;

                imagen[0, i].Show();
                imagen[0, i].Parent = this;
                this.Controls.Add(imagen[0, i]);
            }
            for (int i = 0; i < imagen.GetLength(0) - 1; i++, ab -= 25)
            {
                imagen[i, l0] = new PictureBox();
                imagen[i, l0].Name = "img" + (i).ToString() + "D";
                imagen[i, l0].Top = ab;
                imagen[i, l0].Left = id;
                imagen[i, l0].Width = 25;
                imagen[i, l0].Height = 25;
                imagen[i, l0].Image = Properties.Resources.Límite;

                imagen[i, l0].SizeMode = PictureBoxSizeMode.StretchImage;

                imagen[i, l0].Show();
                imagen[i, l0].Parent = this;
                this.Controls.Add(imagen[i, l0]);
            }
        }
        void elimImg()
        {
            for(int i=0;i<imagen.GetLength(0); i++)
            {
                for(int j = 0; j < imagen.GetLength(1); j++)
                {
                    this.Controls.Remove(imagen[i, j]);
                }
            }
        }
    }
}
