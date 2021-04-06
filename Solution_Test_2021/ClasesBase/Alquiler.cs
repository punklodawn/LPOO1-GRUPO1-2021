using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Alquiler
    {
        private int alq_codigo;

        public int Alq_codigo
        {
            get { return alq_codigo; }
            set { alq_codigo = value; }
        }
        private DateTime alq_fecha;

        public DateTime Alq_fecha
        {
            get { return alq_fecha; }
            set { alq_fecha = value; }
        }
        private int dpto_codigo;

        public int Dpto_codigo
        {
            get { return dpto_codigo; }
            set { dpto_codigo = value; }
        }
        private int inq_codigo;

        public int Inq_codigo
        {
            get { return inq_codigo; }
            set { inq_codigo = value; }
        }
        private DateTime alq_fechadesde;

        public DateTime Alq_fechadesde
        {
            get { return alq_fechadesde; }
            set { alq_fechadesde = value; }
        }
        private DateTime alq_fechahasta;

        public DateTime Alq_fechahasta
        {
            get { return alq_fechahasta; }
            set { alq_fechahasta = value; }
        }
        private decimal alq_precio;

        public decimal Alq_precio
        {
            get { return alq_precio; }
            set { alq_precio = value; }
        }



        /*
        public int Alq_Codigo
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DateTime Alq_Fecha
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Dpto_Codigo
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Inq_Codigo
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DateTime Alq_FechaDesde
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public DateTime Alq_FechaHasta
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public decimal Alq_Precio
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }*/
    }
}
