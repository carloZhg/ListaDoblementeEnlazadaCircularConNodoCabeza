using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDoblementeEnlazadaCircularConNodoCabeza
{
    class NodoDoble
    {

        private int informacion;

        public int Informacion
        {
            get { return informacion; }
            set { informacion = value; }
        }


        private NodoDoble enlaceIzquierdo;

        public NodoDoble EnlaceIzquierdo
        {
            get { return enlaceIzquierdo; }
            set { enlaceIzquierdo = value; }
        }

        private NodoDoble enlaceDerecho;

        public NodoDoble EnlaceDerecho
        {
            get { return enlaceDerecho; }
            set { enlaceDerecho = value; }
        }
    }
}
