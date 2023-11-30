using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDeLinkedList1
{
    public class Foto <T>
    {
        //Propiedades
        public int ID { get; set; }
        public T Descripcion { get; set; }
        public T RutaArchivo { get; set; }

        //Enlaces entre nodos
        public Foto<T> Siguiente { get; set; }
        public Foto<T> Anterior { get; set; }


        //Constructores
        public Foto(int iD, T descripcion, T rutaArchivo)
        {
            ID = iD;
            Descripcion = descripcion;
            RutaArchivo = rutaArchivo;
        }

        public Foto()
        {
        }
    }
}
