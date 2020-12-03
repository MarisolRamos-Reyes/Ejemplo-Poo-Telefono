using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Prueba_2
{
    class Telefono : Dispositivo
    {
        protected string llamada;

        public string Llamada
        {
            get
            {
                return llamada;
            }
            set
            {
                llamada = value;
            }
        }
        public Telefono()
        {
            llamada = "";
        }
        public override string ToString()
        {
            return llamada + "" + base.ToString();
        }

    }
}

