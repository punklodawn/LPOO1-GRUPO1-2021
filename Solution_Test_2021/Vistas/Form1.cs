﻿using System;
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
    public partial class Bienvenido_Form : Form
    {
        public Bienvenido_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Bienvenido_Form_Load(object sender, EventArgs e)
        {
            Usuario oUsuario1 = new Usuario();
            Usuario oUsuario2 = new Usuario();
            Usuario oUsuario3 = new Usuario();

            

            oUsuario1.Usu_id1 = 1;
            oUsuario1.Usu_NombreUsuario1 = "Nadia";
            oUsuario1.Usu_Contraseña1 = "123";
            oUsuario1.Rol_Codigo1 = 1;
            oUsuario1.Usu_ApellidoNombre1 = "NADIA MAMANI";

            oUsuario2.Usu_id1 = 1;
            oUsuario2.Usu_NombreUsuario1 = "Lisandro";
            oUsuario2.Usu_Contraseña1 = "1234";
            oUsuario2.Rol_Codigo1 = 2;
            oUsuario2.Usu_ApellidoNombre1 = "Lisandro GOMEZ";

            oUsuario3.Usu_id1 = 1;
            oUsuario3.Usu_NombreUsuario1 = "Miguel";
            oUsuario3.Usu_Contraseña1 = "12345";
            oUsuario3.Rol_Codigo1 = 3;
            oUsuario3.Usu_ApellidoNombre1 = "Miguel Mansilla";



            string u = Usuario_txtBox.Text;
            string p = Contraseña_textBox.Text;

             
            if(oUsuario1 = 'Nadia' && oUsuario1.Usu_Contraseña1 =  ){
            
            }

        }
    }
}
