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
    public partial class AltaDepartamento_Form : Form
    {
        public AltaDepartamento_Form()
        {
            InitializeComponent();
        }


        private void Aceptar_Edificio_btn_Click(object sender, EventArgs e)
        {
            validar(this); //Llamo al metodo validar: Valida textbox no esten vacios.

            if (vacio == false)
            {
                Departamento oDepartamento = new Departamento();

                MessageBox.Show("¿Desea dar de Alta al Departamentos?");
                //Control con alguna condicion para que si o si cargue todos los datos;;;;;;
                oDepartamento.Dpto_codigo = Convert.ToInt32(Codigo_Departamento_textBox.Text);
                oDepartamento.Dpto_ambientes = Convert.ToInt32(Ambiente_Departamento_textBox.Text);
                oDepartamento.Dpto_baños = Convert.ToInt32(Baños_Departamento_textBox.Text);
                oDepartamento.Dpto_disposicion = Disposicion_Departamento_textBox.Text;
                oDepartamento.Dpto_dormitorios = Convert.ToInt32(Dormitorio_Departamento_textBox.Text);
                oDepartamento.Dpto_numero = Convert.ToInt32(Numero_Departamento_textBox.Text);
                oDepartamento.Dpto_piso = Convert.ToInt32(Piso_Departamento_textBox.Text);
                oDepartamento.Dpto_precio = Convert.ToInt32(Precio_Departamento_textBox.Text);
                oDepartamento.Dpto_tipo = Tipo_Departamento_textBox.Text;
                oDepartamento.Edif_codigo = Convert.ToInt32(EdificioCod_Departamento_textBox.Text);


                MessageBox.Show("Departamento Cargado!");
            }
        }

        private void Salir_Departamento_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaDepartamento_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿ Desea Salir de la Aplicacion S/N ?",
                          "Salir de Aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogo == DialogResult.OK)
            {

            }
            else { e.Cancel = true; }
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
