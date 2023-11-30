using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDeLinkedList1
{
    public class ListaSimplementeEnlazada<T>
    {
        //Apuntadores
        public Foto<T> Primero { get; set; }

        public Foto<T> Ultimo { get; set; }

        public Foto<T> actual { get; set; }

        //Propiedades
        public int ContLSMMax { get; set;  }
        public int ContActual { get; set; }


        //Constructor
        public ListaSimplementeEnlazada()
        {
            Primero = null;
            Ultimo = null;
            ContActual = 0;
            ContLSMMax = 0;
        }

        //Métodos
        //Agregar nodos a la lista
        public void Agregar(Foto<T> NewNodo) 
        {
            if (Primero == null)
            {
                //Si la lista es null está vacía y se agrega el primer dato
                Primero = NewNodo;
                Primero.Siguiente = null;
                Ultimo = NewNodo;
            }
            else
            {
                Ultimo.Siguiente = NewNodo;
                NewNodo.Siguiente = null;
                Ultimo = NewNodo;
                Ultimo.Siguiente = null;
            }
            ContLSMMax++;
        }

        public bool Eliminar(Foto<T> DelNodo)
        {
            bool encontrado = false;
            Foto<T> anterior = null;
            Foto<T> Actual = Primero;

            if (Primero != null)
            {
                while (Actual != null && !Actual.ID.Equals(DelNodo.ID))
                {
                    anterior = Actual;
                    Actual = Actual.Siguiente;
                }
                if (Actual != null)
                {
                    //Se elimina al primero
                    if (Primero.ID.Equals(DelNodo.ID))
                    {
                        //Se elimina todo vinvulo del primero nodo con los demás elementos de la lista
                        Primero = Primero.Siguiente;
                        //Se disminuye el contador
                    }
                    else if (Ultimo.ID.Equals(DelNodo.ID))
                    {
                        anterior.Siguiente = null;
                        Ultimo = anterior;
                    }
                    else
                    {
                        anterior.Siguiente = Actual.Siguiente;
                    }
                    encontrado = true;
                    ContLSMMax--;
                }
            }
            return encontrado;
        }


        public Foto<T> MostrarFotos() 
        {
            //La lista no está vacía
            if (Primero != null) 
            {
                if (actual == Ultimo) 
                {
                    return actual;
                }
                //Ultimo de la lista
                else if (ContActual == ContLSMMax)
                {
                    actual = Ultimo;
                }
                // Cualquier otro de la lista
                else if (ContActual != 0 && ContActual != ContLSMMax)
                {
                    actual = actual.Siguiente;
                    ContActual++;
                }
                else if (ContActual == 0)
                {
                    actual = Primero;
                    ContActual++;
                }
                
            }
            return actual;
        }
    }
}
