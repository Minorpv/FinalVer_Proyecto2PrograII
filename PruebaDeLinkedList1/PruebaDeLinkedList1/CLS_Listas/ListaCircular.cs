using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDeLinkedList1.CLS_Listas
{
    public class ListaCircular<T>
    {
        //Apuntadores
        public Foto<T> Primero { get; set; }
        public Foto<T> Ultimo { get; set; }
        public Foto<T> actual { get; set; }

        //Propiedades
        public int ContLCLMax { get; set; }

        public int ContActual { get; set; }


        //Constructor
        public ListaCircular()
        {
            Primero = null;
            Ultimo = null;
        }

        //Metodos

        //Metodo para agregar nodos al final de la lista
        public void Agregar(Foto<T> NewNodo)
        {
            if (Primero == null) //Lista vacía
            {
                Primero = NewNodo;
                Primero.Siguiente = Primero;
                Ultimo = Primero;
                
                
            }
            else //Se añade un nuevo nodo despues del ultimo
            {
                Ultimo.Siguiente = NewNodo;
                NewNodo.Siguiente = Primero;
                Ultimo = NewNodo;
                Ultimo.Siguiente = Primero;
            }
            ContLCLMax++;
        }

        public bool Eliminar(Foto<T> DelNodo)
        {
            bool encontrado = false;
            Foto<T> anterior = null;
            Foto<T> Actual = Primero;
            Foto<T> inicio = Primero; // Guarda una referencia al primer nodo

            if (Primero != null)
            {
                do // Usa un ciclo do-while para asegurarte de que el cuerpo del ciclo se ejecute al menos una vez
                {
                    if (Actual.ID.Equals(DelNodo.ID))
                    {
                        //Se elimina al primero
                        if (Primero.ID.Equals(DelNodo.ID))
                        {
                            //Se elimina todo vinvulo del primero nodo con los demás elementos de la lista
                            Primero = Primero.Siguiente;
                            Ultimo.Siguiente = Primero;
                        }
                        else if (Ultimo.ID.Equals(DelNodo.ID))
                        {
                            anterior.Siguiente = Primero;
                            Ultimo = anterior;
                        }
                        else
                        {
                            anterior.Siguiente = Actual.Siguiente;
                        }
                        encontrado = true;
                        ContLCLMax--;
                        break; // Salir del ciclo una vez que se ha encontrado y eliminado el nodo
                    }
                    else
                    {
                        anterior = Actual;
                        Actual = Actual.Siguiente;
                    }
                } while (Actual != inicio && Actual != null); // Continúa el ciclo hasta que vuelvas al primer nodo o encuentres un nodo nulo
            }
            return encontrado;
        }


        public Foto<T> MostrarFotos()
        {
            //La lista no está vacía
            if (Primero != null)
            {
                //Ultimo de la lista
                if (ContActual == ContLCLMax)
                {
                    actual = Primero;
                    ContActual = 1;
                }
                // Cualquier otro de la lista
                else if (ContActual != 0 && ContActual != ContLCLMax)
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
