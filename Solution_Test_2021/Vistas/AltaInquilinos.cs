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
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;  

        }
        
        //Boton aceptar, al hacer click en acepetar en nuestro formulario acciona este evento.
        private void Aceptar_Edificio_btn_Click(object sender, EventArgs e)
        {
            {

                if (this.ValidateChildren(ValidationConstraints.Enabled)) 
                {
                    Inquilino oInquilino = new Inquilino();
                    MessageBox.Show("¿Desea dar de Alta el Inquilino?");
                    oInquilino.Inq_Codigo1 = Convert.ToInt32(Codigo_Inquilino_textBox.Text);
                    oInquilino.Inq_Nombre1 = Nombre_Inquilino_textBox.Text;
                    oInquilino.Inq_Apellido1 = Apellido_Inquilino_textBox.Text;
                    oInquilino.Inq_Telefono1 = Telefono_Inquilino_textBox.Text;
                    MessageBox.Show("Inquilino Cargado!");
                } 
                else
                { MessageBox.Show("Faltan algunos campos por rellenar"); }

                //if (Codigo_Inquilino_textBox.Text == "" && Nombre_Inquilino_textBox.Text == "" && Apellido_Inquilino_textBox.Text == "" && Telefono_Inquilino_textBox.Text == "")
                //{
                //    Error_lbl.Text = "Los campos no deben estar vacios";
                //    Error_lbl.Visible = true;
                //}
                //else
                //{
                //    Inquilino oInquilino = new Inquilino();
                //    MessageBox.Show("¿Desea dar de Alta el Inquilino?");
                //    oInquilino.Inq_Codigo1 = Convert.ToInt32(Codigo_Inquilino_textBox.Text);
                //    oInquilino.Inq_Nombre1 = Nombre_Inquilino_textBox.Text;
                //    oInquilino.Inq_Apellido1 = Apellido_Inquilino_textBox.Text;
                //    oInquilino.Inq_Telefono1 = Telefono_Inquilino_textBox.Text;
                //    MessageBox.Show("Inquilino Cargado!");
                //}
                ClearTexForm();

            }
        }

        //Boton salir, al hacer click en salir en nuestro formulario acciona este evento.
        private void Salir_Edificio_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Evento _FormClosing, se acciona al cerrar nuestro fomulario,
        //previamente enviando un mensaje de confirmacion.
        private void AltaInquilinos_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿ Desea Salir de la Aplicacion S/N ?",
                "Salir de Aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogo == DialogResult.OK)
            {
            }
            else { e.Cancel = true; }
        }



      

        //limpia los textbox.
        private void ClearTexForm()
        {

            Codigo_Inquilino_textBox.Text = "";
            Nombre_Inquilino_textBox.Text ="";
            Apellido_Inquilino_textBox.Text = "";
            Telefono_Inquilino_textBox.Text = "";

        }

        /// <summary>
        /// validar con evento keypress, con la clase validar.
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



        private void textboxes_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                e.Cancel = true;
                tb.Select(0, tb.Text.Length);
                MessageBox.Show(tb, "Debe introducir el nombre");
            }
        }

        private void textboxes_Validated(object sender, System.EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            MessageBox.Show(tb, "");
        }

    }
}
