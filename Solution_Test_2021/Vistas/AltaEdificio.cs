using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class AltaEdificio_Form : Form
    {
        public AltaEdificio_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (ValidarCampos())
                {

                    Edificio oEdificio = new Edificio();
                    DialogResult dialog = MessageBox.Show("¿ Desea Agregar Edificio ?",
                    "Agregar Edificio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        oEdificio.Edif_Codigo1 = Convert.ToInt32(Codigo_Edificio_textBox.Text);
                        oEdificio.Edif_Administrador1 = Administrador_Edificio_textBox.Text;
                        oEdificio.Edif_Direccion1 = Direccion_Edificio_textBox.Text;
                        oEdificio.Edif_Nombre1 = Nombre_Edificio_textBox.Text;
                        oEdificio.Edif_Telefono1 = Telefono_Edificio_textBox.Text;
                        MessageBox.Show("Edificio Cargado!");
                        ClearTexForm();
                    }
                    else
                    {
                        MessageBox.Show("Edificio Cancelado");
                        ClearTexForm();
                    }

                }
                else
                {
                    Error_Codigo_Edi_lbl.Text = "solo numeros";
                    Error_Administrador_Edi_lbl.Text = "solo letras";
                    Error_Direccion_Edi_lbl.Text = "solo letras";
                    Error_Nombre_Edi_lbl.Text = "solo letras";
                    Error_Telefono_Edi_lbl.Text = "solo letras";
                    Error_Codigo_Edi_lbl.Visible = true;
                    Error_Administrador_Edi_lbl.Visible = true;
                    Error_Direccion_Edi_lbl.Visible = true;
                    Error_Nombre_Edi_lbl.Visible = true;
                    Error_Telefono_Edi_lbl.Visible = true;

                }
            }
       }
        

       private void Salir_Edificio_btn_Click(object sender, EventArgs e)
       {
           this.Close();
       }
        
        
        private void AltaEdificio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿ Desea Salir de la Aplicacion S/N ?",
                "Salir de Aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogo == DialogResult.OK) 
            { 
            }
            else
            { e.Cancel = true; }
        }

        private void ClearTexForm()
        {

            Codigo_Edificio_textBox.Text = "";
            Administrador_Edificio_textBox.Text = "";
            Direccion_Edificio_textBox.Text = "";
            Nombre_Edificio_textBox.Text = "";
            Telefono_Edificio_textBox.Text = "";
            Error_Codigo_Edi_lbl.Text = "";
            Error_Administrador_Edi_lbl.Text = "";
            Error_Direccion_Edi_lbl.Text = "";
            Error_Nombre_Edi_lbl.Text = "";
            Error_Telefono_Edi_lbl.Text = "";
        }

        private bool ValidarCampos()
        {
            bool ok = true;

            if (Codigo_Edificio_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(Codigo_Edificio_textBox, "Ingrese Codigo");
            }
            if (Codigo_Edificio_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(Administrador_Edificio_textBox, "Ingrese Administrador");
            }
            if (Direccion_Edificio_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(Direccion_Edificio_textBox, "Ingrese una Direccion");
            }
            if (Nombre_Edificio_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(Nombre_Edificio_textBox, "Ingrese un Nombre");
            }
            if (Telefono_Edificio_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(Telefono_Edificio_textBox, "Ingrese un Telefono");
            }

            return ok;
        }

        private void AltaEdificio_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
