using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDoblementeEnlazadaCircularConNodoCabeza
{
    class NodoCabez
    {

        private int cantidadElementos;

        public int CantidadElementos
        //public string Doctor, lista de pacientes
        {
            get { return cantidadElementos; }
            set { cantidadElementos = value; }
        }

        private NodoDoble enlace;

        public NodoDoble Enlace
        {
            get { return enlace; }
            set { enlace = value; }
        }
    }

}
