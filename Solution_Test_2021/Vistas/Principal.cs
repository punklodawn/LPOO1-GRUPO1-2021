using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
                  
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿ Desea Salir de la Aplicacion S/N ?",
                      "Salir de Aplicacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogo == DialogResult.OK) {
                System.Windows.Forms.Application.Exit();
            }
            else { e.Cancel = true; }
        }

        private void altaEdificioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AltaEdificio_Form oAltaEdificio = new AltaEdificio_Form();
            oAltaEdificio.Show();
        }

        private void altaDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaDepartamento_Form oAltaDepartamento = new AltaDepartamento_Form();
            oAltaDepartamento.Show();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaInquilinos_Form oAltaInquilinos = new AltaInquilinos_Form();
            oAltaInquilinos.Show();

        }
    }
}
