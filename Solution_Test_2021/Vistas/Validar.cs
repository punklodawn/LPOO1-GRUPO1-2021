using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    class Validar
    {
        public static void soloLetras(KeyPressEventArgs v) {
 
            if(Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else 
            {
                v.Handled = true;
            }
        }


        public static void soloNumeros(KeyPressEventArgs v)
        {

            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }
        }


        public static void soloDecimal(KeyPressEventArgs v)
        {

            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }
        }


        //public static void vacio() {

        //    var vr = !string.IsNullOrEmpty(txt);
        //}



        //public bool vacio; // Variable utilizada para saber si hay algún TextBox vacio.

        //public static void validar(Form formulario)//Metodo para validar
        //{
        //    foreach (Control oControls in formulario.Controls) // Busca en cada TextBox de nuestro Formulario.
        //    {
        //        if (oControls is TextBox & oControls.Text == String.Empty) // Verifica que no este vacio.
        //        {
        //            bool vacio = true; // Si esta vacio el TextBox asignamos el valor True a la variable.
        //        }
        //    }

        //    if (vacio == true)//Condicional si es true es porque estan vacios los textbox mando un msj
        //    {
        //        MessageBox.Show("Favor de llenar todos los campos"); // Si la variable es verdadera muestra un mensaje.
        //        vacio = true;// asigna a  la variable el valor true.
        //    }
        //    else
        //    {
        //        vacio = false;// asigna a la variable el valor false
        //    }
        //}
    }
}
