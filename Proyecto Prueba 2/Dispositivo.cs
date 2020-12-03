using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Prueba_2
{
    class Dispositivo
    {
        private string sistema;

        public string Sistema
        {
            get
            {
                return sistema;
            }
            set
            {
                sistema = value;
            }
        }
        public Dispositivo()
        {
            sistema = "";
        }
        public override string ToString()
        {
            return sistema  + " Generico";
        }
    }
}
