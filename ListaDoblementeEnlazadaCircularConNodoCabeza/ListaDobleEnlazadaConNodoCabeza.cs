using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDoblementeEnlazadaCircularConNodoCabeza
{
    class ListaDobleEnlazadaConNodoCabeza
    {

        public NodoCabez cabeza;
        public NodoDoble primero;
        public NodoDoble ultimo;

        private bool vacia()
        {
            if (cabeza == null)
                return true;
            else
                return false;
        }

        private void crearCabeza()
        {
            cabeza = new NodoCabez();
            cabeza.Enlace = null;
            cabeza.CantidadElementos = 0;
        }

        public void insertar(int x)
        {
            NodoDoble p;
            if (vacia())
            {
                crearCabeza();
                primero = new NodoDoble();
                primero.Informacion = x;
                primero.EnlaceIzquierdo = null;
                primero.EnlaceDerecho = null;
                ultimo = primero;

                //a
                cabeza.CantidadElementos++;
                cabeza.Enlace = primero;
            }
            else
            {
                p = new NodoDoble();
                p.Informacion = x;
                p.EnlaceDerecho = null;
                p.EnlaceIzquierdo = ultimo;
                ultimo.EnlaceDerecho = p;
                ultimo = p;
                cabeza.CantidadElementos++;
            }
        }
    }
}
