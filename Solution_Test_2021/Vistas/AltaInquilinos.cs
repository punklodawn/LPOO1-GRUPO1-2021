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
    public partial class AltaInquilinos_Form : Form
    {
        public AltaInquilinos_Form()
        {
            InitializeComponent();
        

        }
        
        //Boton aceptar, al hacer click en acepetar en nuestro formulario acciona este evento.
        private void Aceptar_Edificio_btn_Click(object sender, EventArgs e)
        {
            {
                if (ValidarCampos())
                {

                    Inquilino oInquilino = new Inquilino();
                    DialogResult dialog = MessageBox.Show("¿ Desea Agregar Inquilino ?",
                    "Agregar Inquilino", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        oInquilino.Inq_Codigo1 = Convert.ToInt32(Codigo_Inquilino_textBox.Text);
                        oInquilino.Inq_Nombre1 = Nombre_Inquilino_textBox.Text;
                        oInquilino.Inq_Apellido1 = Apellido_Inquilino_textBox.Text;
                        oInquilino.Inq_Telefono1 = Telefono_Inquilino_textBox.Text;
                        MessageBox.Show("Inquilino Cargado!");
                        ClearTexForm();
                    }
                    else
                    {
                        MessageBox.Show("Inquilino Cancelado");
                        ClearTexForm();
                    }

                }
                else {

                    Error_lbl.Text = "Los campos no deben estar vacios";
                    Error_Codigo_lbl.Text = "solo numeros";
                    Error_Nombre_lbl.Text = "solo letras";
                    Error_Apellido_lbl.Text = "solo letras";
                    Error_Telefono_lbl.Text = "solo numeros";
                    Error_lbl.Visible = true;
                    Error_Codigo_lbl.Visible = true;
                    Error_Nombre_lbl.Visible = true;
                    Error_Apellido_lbl.Visible = true;
                    Error_Telefono_lbl.Visible = true;

                }
            }
        }
        

        //limpia los textbox.
        private void ClearTexForm()
        {

            Codigo_Inquilino_textBox.Text = "";
            Nombre_Inquilino_textBox.Text ="";
            Apellido_Inquilino_textBox.Text = "";
            Telefono_Inquilino_textBox.Text = "";
            Error_lbl.Text = "";
            Error_Codigo_lbl.Text = "";
            Error_Nombre_lbl.Text = "";
            Error_Apellido_lbl.Text = "";
            Error_Telefono_lbl.Text = "";
        }

        /// <summary>
        /// validar con evento keypress, con la clase validar.
        /// controla los textbox
        /// </summary>
        /// <param name="Validar"></param>
        private void Nombre_Inquilino_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetras(e);
        }

        private void Codigo_Inquilino_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void Apellido_Inquilino_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetras(e);
        }

        private void Telefono_Inquilino_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }


        //Valida si los campos estan vacios.
        private bool ValidarCampos() {
            bool ok = true;

            if (Codigo_Inquilino_textBox.Text=="")
            {
                ok = false;
                MessageBox.Show(Codigo_Inquilino_textBox, "Ingrese Codigo");
            }
            if (Nombre_Inquilino_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(Nombre_Inquilino_textBox, "Ingrese un Nombre");
            }
            if (Apellido_Inquilino_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(Apellido_Inquilino_textBox, "Ingrese un Apellido");
            }
            if (Telefono_Inquilino_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(Telefono_Inquilino_textBox, "Ingrese un Telefono");
            }

            return ok;
        }


        //Boton salir, al hacer click en salir en nuestro formulario acciona este evento.
        private void Salir_Inquilino_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        //Evento _FormClosing, se acciona al cerrar nuestro fomulario,
        //previamente enviando un mensaje de confirmacion.
        private void AltaInquilinos_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿ Desea Salir del formulario S/N ?",
        "Salir de Aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogo == DialogResult.OK)
            {
            }
            else
            { e.Cancel = true; }
        }


    }
}
