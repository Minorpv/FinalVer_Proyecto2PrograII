using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaDeLinkedList1
{
    public partial class FormGaleria : Form
    {
        //Album de fotos recolectadas en el menú
        Album Lista = new Album();

        //Propiedades
        public string Ruta { get; set; }
        Foto<string> foto { get; set; }


        //Constructor
        public FormGaleria(Album album)
        {
            InitializeComponent();
            Lista = album;
        }

        //Eventos

        //Al cargar el formulario
        private void FormGaleria_Load(object sender, EventArgs e)
        {
            foto = Lista.MostrarFotoSiguiente();
            labelDesc.Text = foto.Descripcion;
            labelRuta.Text = foto.RutaArchivo;
            pictureBox1.ImageLocation = foto.RutaArchivo;
        }

        private void buttonSig_Click(object sender, EventArgs e)
        {
            foto = Lista.MostrarFotoSiguiente();
            labelDesc.Text = foto.Descripcion;
            labelRuta.Text = foto.RutaArchivo;
            pictureBox1.ImageLocation = foto.RutaArchivo;
        }

        private void buttonReinicio_Click(object sender, EventArgs e)
        {
            Lista.reinicioListas();
            Lista.Cont = 0;
            this.Close();
        }

        private void buttonAnt_Click(object sender, EventArgs e)
        {
            foto = Lista.MostrarFotoAnterior();
            if (foto != null) 
            {
                labelDesc.Text = foto.Descripcion;
                labelRuta.Text = foto.RutaArchivo;
                pictureBox1.ImageLocation = foto.RutaArchivo;
            }
        }
    }
}
