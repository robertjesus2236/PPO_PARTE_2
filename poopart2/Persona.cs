using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poopart2
{
   
    internal class Persona
    {
        private string nombre;
        private string nid;
        string pais;

        public string Nombre { get => nombre; set => nombre = value; }
       // public string Nid { get => nid; set => nid = value; }
       // public string Pais { get => pais; set => pais = value; }

        //Get y Set controlado para realizar modificaciones, el anterior es por defecto.

        //Forma resumida del get, set
        public string Nid { get; set; }

        public string Pais
        {
            get { return "Mi pais es " + pais; }
            set { pais = value; }
        }

    }
}
