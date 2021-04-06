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
            Edificio oEdificio = new Edificio();

            MessageBox.Show("¿Desea dar de Alta el Edificio?");
            //Control con alguna condicion para que si o si cargue todos los datos;;;;;;
            oEdificio.Edif_Administrador1 = Codigo_Administrador_Edificio_textBox.Text;
            oEdificio.Edif_Codigo1 = Convert.ToInt32(Codigo_Edificio_textBox.Text);// Controlar formulario y validacion(caso si esta vacio o null)
            oEdificio.Edif_Direccion1 = Codigo_Direccion_textBox.Text;
            oEdificio.Edif_Nombre1 = Codigo_Nombre_textBox.Text;
            oEdificio.Edif_Telefono1 = Codigo_Telefono_textBox.Text;


            MessageBox.Show("edificio cargado!");
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
            if (dialogo == DialogResult.OK) {
              
            }
            else { e.Cancel = true; }
        }




    }
}
