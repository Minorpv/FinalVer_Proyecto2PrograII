using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaDeLinkedList1
{
    public partial class FormMenu : Form
    {
        //Propiedades
        int id = 0;

        int idDGV = 0;
        public int tipoDeLista { get; set; }

        //Album de fotos
        Album album = new Album();

        
        //Constructor
        public FormMenu()
        {
            InitializeComponent();
        }


        //Eventos
        //Al cargar el form:
        private void Form1_Load(object sender, EventArgs e)
        {
            //ID = 0 y se centra en la text box de la descripción
            textBoxID.Text = "0";
            textBoxDesc.Focus();
        }

        //Al agregar una foto
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Se establecen las variables recogidas de las textbox y se colocan en
            //una instancia nueva de la clase foto
            id = int.Parse(textBoxID.Text);
            string desc = textBoxDesc.Text;
            string Ruta = textBoxRuta.Text;
            Foto<string> foto = new Foto<string>
            {
                ID = id,
                Descripcion = desc,
                RutaArchivo = Ruta
            };
            //Se agrega la foto al album
            album.AgregarFoto(foto);
            //Se obtiene el indice de la siguiente fila a usarse del data grid view
            int n = dataGridView1.Rows.Add();
            //Se añaden los datos de la foto en cada una de las columnas de la data grid view
            dataGridView1.Rows[n].Cells[0].Value = foto.ID;
            dataGridView1.Rows[n].Cells[1].Value = foto.Descripcion;
            dataGridView1.Rows[n].Cells[2].Value = foto.RutaArchivo;
            //Suma contador
            id++;
            //Se limpian las textbox y se coloca la siguiente id automaticamente
            limpiarTextBox();
        }

       

        //Indice del click del mouse dentro de la data grid view
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs ID)
        {
            //Al tocar una fila de la data grid view ña casilla de la id cambia automáticamente
            //al indice la de la fila
            idDGV = ID.RowIndex;
            textBoxID.Text = dataGridView1.Rows[idDGV].Cells[0].Value.ToString();
        }

        //Eliminar un dato
        private void buttonDel_Click(object sender, EventArgs e)
        {
            //Se asegura de que haya un dato seleccionado dentro de la data grid view
            if (idDGV != -1)
            {
                //Si la id es nula no se hace nada
                if (textBoxID.Text is null)
                {
                    return;
                }
                //Sino se elimina el dato que está en la posición del id que queremos elimanar
                id = int.Parse(textBoxID.Text);
                dataGridView1.Rows.RemoveAt(idDGV);
                    
            }
            //Se elimina la foto del album
            album.EliminarFoto(id);
            //Se limpian las textbox
            limpiarTextBox();
        }

        //Codigo para abrir y guardar la ruta de acceso del archivo
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Guarada laruta del archivo
                //"C:\Users\minor\Archivos VS Code\R.jpg"
                textBoxRuta.Text = openFileDialog1.FileName;
                //Guarada solamente el nombre y la extensión del archivo
                //"R.jpg"
                textBoxDesc.Text = openFileDialog1.SafeFileName;
            }
        }

        //Eventos para abrir las galerias de fotos
        //Tipos de listas:
        //0. Lista simplemenete enlazada
        //1. Lista Doblemente enlazada
        //2. Lista circular

        //Lista simplemente enlazada
        private void simplementeEnlazadaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            album.TipoDeLista = 0;
            //Se abre un nuevo formulario de galería y se trae todo lo que guaradamos
            //en el album de fotos hasta ese punto
            FormGaleria galeria = new FormGaleria(album);
            galeria.ShowDialog();
        }

        //Lista Doblemente enlazada
        private void doblementeEnlazadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            album.TipoDeLista = 1;
            //Se abre un nuevo formulario de galería y se trae todo lo que guaradamos
            ////en el album de fotos hasta ese punto
            FormGaleria galeria = new FormGaleria(album);
            galeria.ShowDialog();
        }

        //Lista circular
        private void circularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            album.TipoDeLista = 2;
            //Se abre un nuevo formulario de galería y se trae todo lo que guaradamos
            ////en el album de fotos hasta ese punto
            FormGaleria galeria = new FormGaleria(album);
            galeria.ShowDialog();
        }

        //Metodos

        //Limpieza de textbox
        private void limpiarTextBox() 
        {
            textBoxID.Text = id.ToString();
            textBoxDesc.Clear();
            textBoxRuta.Clear();
            textBoxDesc.Focus();
        }

        private void toolStripSplitButtonLista_ButtonClick(object sender, EventArgs e)
        {

        }
    }
}
