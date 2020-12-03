using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Prueba_2
{
    class Celular : Telefono
    {
        protected string mensaje;

        public string Mensaje
        {
            get
            {
                return mensaje;
            }
            set
            {
                mensaje = value;
            }
        }
        public Celular(): base()
        {
            mensaje = "";
        }
        public override string ToString()
        {
            return mensaje + " " + base.ToString();
        }
    }
}
