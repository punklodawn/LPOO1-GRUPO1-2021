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
             if (ValidarCampos())
                {

                    Departamento oDepartamento = new Departamento();
                    DialogResult dialog = MessageBox.Show("¿ Desea Agregar Departamento ?",
                    "Agregar Departamento", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dialog == DialogResult.OK)
                    {
                        oDepartamento.Dpto_codigo = Convert.ToInt32(Codigo_Departamento_textBox.Text);
                        oDepartamento.Dpto_ambientes = Convert.ToInt32(Ambiente_Departamento_textBox.Text);
                        oDepartamento.Dpto_baños = Convert.ToInt32(Baños_Departamento_textBox.Text);
                        oDepartamento.Dpto_dormitorios = Convert.ToInt32(Dormitorio_Departamento_textBox.Text);
                        oDepartamento.Dpto_numero = Convert.ToInt32(Numero_Departamento_textBox.Text);
                        oDepartamento.Dpto_piso = Convert.ToInt32(Piso_Departamento_textBox.Text);
                        oDepartamento.Dpto_precio = Convert.ToInt32(Precio_Departamento_textBox.Text);
                        oDepartamento.Dpto_tipo = Tipo_Departamento_textBox.Text;
                        oDepartamento.Edif_codigo = Convert.ToInt32(EdificioCod_Departamento_textBox.Text);
                        oDepartamento.Dpto_disposicion = Disposicion_Departamento_textBox.Text;
                        MessageBox.Show("Departamento Cargado!");
                        ClearTexForm();
                    }
                    else
                    {
                        MessageBox.Show("Departamento Cancelado");
                        ClearTexForm();
                    }

                }
                else
                {
                    //Error_Codigo_Edi_lbl.Text = "solo numeros";
                    //Error_Administrador_Edi_lbl.Text = "solo letras";
                    //Error_Direccion_Edi_lbl.Text = "solo letras";
                    //Error_Nombre_Edi_lbl.Text = "solo letras";
                    //Error_Telefono_Edi_lbl.Text = "solo letras";
                    //Error_Codigo_Edi_lbl.Visible = true;
                    //Error_Administrador_Edi_lbl.Visible = true;
                    //Error_Direccion_Edi_lbl.Visible = true;
                    //Error_Nombre_Edi_lbl.Visible = true;
                    //Error_Telefono_Edi_lbl.Visible = true;

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

     private void ClearTexForm()
        {

            Codigo_Departamento_textBox.Text="";
            Ambiente_Departamento_textBox.Text="";
            Baños_Departamento_textBox.Text="";
            Dormitorio_Departamento_textBox.Text="";
            Numero_Departamento_textBox.Text="";
            Piso_Departamento_textBox.Text="";
            Precio_Departamento_textBox.Text="";
            Tipo_Departamento_textBox.Text="";
            EdificioCod_Departamento_textBox.Text="";
            Disposicion_Departamento_textBox.Text="";
        }

        private bool ValidarCampos()
        {
            bool ok = true;

            if (Codigo_Departamento_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(Codigo_Departamento_textBox, "Ingrese Codigo");
            }
            if (Ambiente_Departamento_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(Ambiente_Departamento_textBox, "Ingrese Ambiente");
            }
            if (Baños_Departamento_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(Baños_Departamento_textBox, "Ingrese Baños");
            }
            if (Dormitorio_Departamento_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(Dormitorio_Departamento_textBox, "Ingrese Dormitorio");
            }
            if (Numero_Departamento_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(Numero_Departamento_textBox, "Ingrese Numero");
            }
            if (Piso_Departamento_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(Piso_Departamento_textBox, "Ingrese Piso");
            }
            if (Precio_Departamento_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(Precio_Departamento_textBox, "Ingrese un Precio");
            }
            if (Tipo_Departamento_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(Tipo_Departamento_textBox, "Ingrese Tipo");
            }
            if (EdificioCod_Departamento_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(EdificioCod_Departamento_textBox, "Ingrese Codigo Edificio");
            }
            if (Disposicion_Departamento_textBox.Text == "")
            {
                ok = false;
                MessageBox.Show(Disposicion_Departamento_textBox, "Ingrese una Disposicion");
            }

            return ok;
        }
       
    }
}
