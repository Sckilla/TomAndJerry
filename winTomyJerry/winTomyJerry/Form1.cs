using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace winTomyJerry
{
    public partial class frmTomyJerry : Form
    {
        clsTomyJerry obj = new clsTomyJerry();
        bool tam = false;//indica si ya se definió el tamaño del espacio
        bool tyj = false;//indica si las posiciones de tom y de jerry ya se definieron
        bool archn = false;
        public frmTomyJerry()
        {
            InitializeComponent();
        }
        private void frmTomyJerry_Load(object sender, EventArgs e)
        {

        }
        private void txtNArch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNArch.ReadOnly == false)
            {
                if ((e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 65 || e.KeyChar > 90) && (e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46)
                {
                    e.Handled = true;
                    erpNumeros.SetError(txtNArch, "Sólo pueden ser ingresados números y letras.");
                }
                else
                    erpNumeros.SetError(txtNArch, "");
            }
            else
            {
                erpNumeros.SetError(txtNArch, "Se ha cargado un archivo, si deseas introducir otro deber reestablecer todo.");
            }
        }
        private void txtM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                erpNumeros.SetError(txtM, "Sólo pueden ser ingresados números.");
            }
            else
                erpNumeros.SetError(txtM, "");
        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                erpNumeros.SetError(txtN, "Sólo pueden ser ingresados números.");
            }
            else
                erpNumeros.SetError(txtN, "");
        }

        private void txtFilaT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                erpNumeros.SetError(txtFilaT, "Sólo pueden ser ingresados números.");
            }
            else
                erpNumeros.SetError(txtFilaT, "");
        }

        private void txtColumnaT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                erpNumeros.SetError(txtColumnaT, "Sólo pueden ser ingresados números.");
            }
            else
                erpNumeros.SetError(txtColumnaT, "");
        }

        private void txtColumnaJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                erpNumeros.SetError(txtColumnaJ, "Sólo pueden ser ingresados números.");
            }
            else
                erpNumeros.SetError(txtColumnaJ, "");
        }

        private void txtFilaJ_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                erpNumeros.SetError(txtFilaJ, "Sólo pueden ser ingresados números.");
            }
            else
                erpNumeros.SetError(txtFilaJ, "");
        }

        private void txtFilaOSI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                erpNumeros.SetError(txtFilaOSI, "Sólo pueden ser ingresados números.");
            }
            else
                erpNumeros.SetError(txtFilaOSI, "");
        }

        private void txtColumnaOSI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                erpNumeros.SetError(txtColumnaOSI, "Sólo pueden ser ingresados números.");
            }
            else
                erpNumeros.SetError(txtColumnaOSI, "");
        }

        private void txtFilaOID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                erpNumeros.SetError(txtFilaOID, "Sólo pueden ser ingresados números.");
            }
            else
                erpNumeros.SetError(txtFilaOID, "");
        }

        private void txtColumnaOID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                erpNumeros.SetError(txtColumnaOID, "Sólo pueden ser ingresados números.");
            }
            else
                erpNumeros.SetError(txtColumnaOID, "");
        }

        private void btnAceptarEsp_Click(object sender, EventArgs e)
        {
            if (txtM.Text != "" && txtN.Text != "")
            {
                if(int.Parse(txtN.Text)<=15&& int.Parse(txtM.Text) <= 15)
                {
                    obj.n = int.Parse(txtN.Text);
                    obj.m = int.Parse(txtM.Text);
                    MessageBox.Show("Se ha definido el tamaño del espacio correctamente.", "Listo", MessageBoxButtons.OK);
                    tam = true;
                    if (tam && tyj)
                    {
                        btnGenEsp.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Las filas y columnas no pueden ser mas de 10 cada una.", "No se puede continuar.", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Alguna de las entradas está vacía.", "No se puede continuar.", MessageBoxButtons.OK);
            }
        }

        private void btnAceptarUbi_Click(object sender, EventArgs e)
        {
            if(txtFilaT.Text != "" &&txtColumnaT.Text != "" &&txtFilaJ.Text != "" &&txtColumnaJ.Text != "")
            {
                obj.definirPosTJ(int.Parse(txtFilaT.Text), int.Parse(txtColumnaT.Text), int.Parse(txtFilaJ.Text), int.Parse(txtColumnaJ.Text));
                MessageBox.Show("Se han definido las ubicaciones iniciales de Tom y Jerry.", "Listo", MessageBoxButtons.OK);
                tyj = true;
                if (tam && tyj)
                {
                    btnGenEsp.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Alguna de las entradas está vacía.", "No se puede continuar.", MessageBoxButtons.OK);
            }
        }

        private void btnIntObst_Click(object sender, EventArgs e)
        {
            if (txtFilaOSI.Text != "" && txtColumnaOSI.Text != "" && txtFilaOID.Text != "" && txtColumnaOID.Text != "")
            {
                obj.genObstaculo(int.Parse(txtFilaOSI.Text), int.Parse(txtColumnaOSI.Text), int.Parse(txtFilaOID.Text), int.Parse(txtColumnaOID.Text));
                MessageBox.Show("Se ha definido el obstáculo correctamente.", "Listo", MessageBoxButtons.OK);
                txtFilaOID.Text = "";
                txtFilaOSI.Text = "";
                txtColumnaOID.Text = "";
                txtColumnaOSI.Text = "";
                txtFilaOSI.Focus();
            }
            else
            {
                MessageBox.Show("Alguna de las entradas está vacía.", "No se puede continuar.", MessageBoxButtons.OK);
            }
        }

        private void btnRestObst_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar todos los obstáculos introducidos?", "¿Eliminar?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                obj.borrarDatos(1);
                txtFilaOID.Text = "";
                txtFilaOSI.Text = "";
                txtColumnaOID.Text = "";
                txtColumnaOSI.Text = "";
                MessageBox.Show("Se han borrado los obstáculos.", "Terminado.", MessageBoxButtons.OK);
            }
        }

        private void btnRestAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar todos los datos introducidos?", "¿Eliminar?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                txtNArch.ReadOnly = false;
                btnCargarArch.Enabled = true;
                obj.borrarDatos(0);
                archn = false;
                tyj = false;
                tam = false;
                txtN.Text = "";
                txtM.Text = "";
                txtFilaJ.Text = "";
                txtFilaT.Text = "";
                txtFilaOID.Text = "";
                txtFilaOSI.Text = "";
                txtColumnaJ.Text = "";
                txtColumnaT.Text = "";
                txtColumnaOID.Text = "";
                txtColumnaOSI.Text = "";
                txtNArch.Text = "";
                erpNumeros.SetError(txtNArch, "");
                erpNumeros.SetError(txtN, "");
                erpNumeros.SetError(txtM, "");
                erpNumeros.SetError(txtFilaJ, "");
                erpNumeros.SetError(txtFilaT, "");
                erpNumeros.SetError(txtFilaOID, "");
                erpNumeros.SetError(txtFilaOSI, "");
                erpNumeros.SetError(txtColumnaJ, "");
                erpNumeros.SetError(txtColumnaT, "");
                erpNumeros.SetError(txtColumnaOID, "");
                erpNumeros.SetError(txtColumnaOSI, "");
                MessageBox.Show("Se han borrado los datos.", "Terminado.", MessageBoxButtons.OK);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar Tom y Jerry?", "¿Salir?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }         
        }

        private void btnGenEsp_Click(object sender, EventArgs e)
        {
            if (archn)
            {
                DialogResult result = MessageBox.Show("Se generarán nuevos archivos ¿De aucerdo?", "¿Continuar?", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            int narch = obj.crearArchivoIN();
            int erarch=obj.leerArchivoIN("TOM" + narch.ToString() + ".DAT");
            if (erarch == -1)
            {
                int er = obj.crearArchivoOUT(narch);
                if (er == -1)
                {
                    List<string> caminos = obj.generarCaminos();
                    if (obj.objetivo)
                    {
                        MessageBox.Show("Se generó TOM" + narch + ".DAT y TOM" + narch + ".RES correctamente.\n" + "Se encontraron " + caminos.Count.ToString() + " caminos.", "Caminos generados", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Se generó " + narch + " correctamente.\n" + "No se encontraron caminos.", "Objetivo inalcanzable", MessageBoxButtons.OK);
                    }
                    frmCaminoGráfico frm = new frmCaminoGráfico(obj.espacio, caminos);
                    frm.Show();
                }
                else
                {
                    string error = "";
                    switch (er)
                    {
                        case 0:
                            error = "M o N (o ambas) son igual a 0";
                            break;
                        case 1:
                            error = "Tom o Jerry no se encuentran en coordenadas válidas de la superficie de la casa.";
                            break;
                        case 2:
                            error = "Tom y Jerry están en la misma casilla.";
                            break;
                        case 3:
                            error = "Algún obstáculo no está situado en coordenadas válidas de la superficie.";
                            break;
                        case 4:
                            error = "Los vértices que representan un obstáculo no cumplen una relación válida entre sí.";
                            break;
                        case 5:
                            error = "Dos o más obstáculos se solapan.";
                            break;
                        case 6:
                            error = "Tom o Jerry están en una casilla ocupada por un obstáculo.";
                            break;
                    }
                    MessageBox.Show("Error " + er.ToString() + "\n" + error, "Error en los datos", MessageBoxButtons.OK);
                }
            }else if (erarch == 0)
            {
                MessageBox.Show("No se localizó el archivo", "Error en el archivo", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No se pudo leer el archivo correctamente.", "Archivo dañado", MessageBoxButtons.OK);
            }
        }

        private void btnCargarArch_Click(object sender, EventArgs e)
        {
            txtNArch.Text = txtNArch.Text.ToUpper();
            if (txtNArch.Text != "")
            {
                try
                {
                    if (File.Exists(txtNArch.Text))
                    {
                        txtN.Text = "";
                        txtM.Text = "";
                        txtFilaJ.Text = "";
                        txtFilaT.Text = "";
                        txtFilaOID.Text = "";
                        txtFilaOSI.Text = "";
                        txtColumnaJ.Text = "";
                        txtColumnaT.Text = "";
                        txtColumnaOID.Text = "";
                        txtColumnaOSI.Text = "";
                        int erarch = obj.leerArchivoIN(txtNArch.Text);
                        if (erarch == -1)
                        {
                            char[] sep = txtNArch.Text.ToCharArray();
                            int er = obj.crearArchivoOUT(int.Parse(sep[3].ToString()));
                            if (er == -1)
                            {
                                txtNArch.ReadOnly = true;
                                btnCargarArch.Enabled = false;
                                btnGenEsp.Enabled = true;
                                archn = true;
                                List<string> caminos = obj.generarCaminos();
                                if (obj.objetivo)
                                {
                                    MessageBox.Show("Se encontraron " + caminos.Count.ToString() + " caminos.", "Caminos generados", MessageBoxButtons.OK);
                                }
                                else
                                {
                                    MessageBox.Show("No se encontraron caminos.", "Objetivo inalcanzable", MessageBoxButtons.OK);
                                }
                                frmCaminoGráfico frm = new frmCaminoGráfico(obj.espacio, caminos);
                                frm.Show();
                            }
                            else
                            {
                                string error = "";
                                switch (er)
                                {
                                    case 0:
                                        error = "M o N (o ambas) son igual a 0";
                                        break;
                                    case 1:
                                        error = "Tom o Jerry no se encuentran en coordenadas válidas de la superficie de la casa.";
                                        break;
                                    case 2:
                                        error = "Tom y Jerry están en la misma casilla.";
                                        break;
                                    case 3:
                                        error = "Algún obstáculo no está situado en coordenadas válidas de la superficie.";
                                        break;
                                    case 4:
                                        error = "Los vértices que representan un obstáculo no cumplen una relación válida entre sí.";
                                        break;
                                    case 5:
                                        error = "Dos o más obstáculos se solapan.";
                                        break;
                                    case 6:
                                        error = "Tom o Jerry están en una casilla ocupada por un obstáculo.";
                                        break;
                                }
                                MessageBox.Show("Error " + er.ToString() + "\n" + error, "Error en " + txtNArch.Text, MessageBoxButtons.OK);
                            }
                        }
                        else if (erarch == 0)
                        {
                            MessageBox.Show("No se localizó el archivo", "Error en el archivo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo leer el archivo correctamente.", "Archivo dañado", MessageBoxButtons.OK);
                        }

                    }
                    else
                    {
                        MessageBox.Show("El nombre introducido no coincide con ningun archivo existente.", "No se encontró el archivo", MessageBoxButtons.OK);
                    }
                }
                catch
                {
                    MessageBox.Show("No se pudo leer ni generar el nuevo archivo .RES", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {

                MessageBox.Show("Debes introducir el nombre del archivo.", "No se pudo completar la operación", MessageBoxButtons.OK);
            }
        }    
    }
}
