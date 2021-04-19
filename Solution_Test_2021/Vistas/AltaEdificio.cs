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
            validar(this); //Llamo al metodo validar: Valida textbox no esten vacios.

            if (vacio == false)
            {
                Edificio oEdificio = new Edificio();

                MessageBox.Show("¿Desea dar de Alta el Edificio?");

                oEdificio.Edif_Administrador1 = Codigo_Administrador_Edificio_textBox.Text;
                oEdificio.Edif_Codigo1 = Convert.ToInt32(Codigo_Edificio_textBox.Text);
                oEdificio.Edif_Direccion1 = Codigo_Direccion_textBox.Text;
                oEdificio.Edif_Nombre1 = Codigo_Nombre_textBox.Text;
                oEdificio.Edif_Telefono1 = Codigo_Telefono_textBox.Text;

                MessageBox.Show("edificio cargado!");
            }
       }
        

       private void Salir_Edificio_btn_Click(object sender, EventArgs e)
       {
           this.Close();
            //System.Windows.Forms.Application.Exit();
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


        public bool vacio; // Variable utilizada para saber si hay algún TextBox vacio.

        private void validar(Form formulario)//Metodo para validar
        {
            foreach (Control oControls in formulario.Controls) // Busca en cada TextBox de nuestro Formulario.
            {
                if (oControls is TextBox & oControls.Text == String.Empty) // Verifica que no este vacio.
                {
                    vacio = true; // Si esta vacio el TextBox asignamos el valor True a la variable.
                }
            }

            if (vacio == true)//Condicional si es true es porque estan vacios los textbox mando un msj
            {
                MessageBox.Show("Favor de llenar todos los campos"); // Si la variable es verdadera muestra un mensaje.
                vacio = true;// asigna a  la variable el valor true.
            }
            else
            {
                vacio = false;// asigna a la variable el valor false
            }
        }
    }
}
