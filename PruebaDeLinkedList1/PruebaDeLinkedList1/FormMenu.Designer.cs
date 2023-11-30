namespace PruebaDeLinkedList1
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.groupBoxIngDatos = new System.Windows.Forms.GroupBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButtonLista = new System.Windows.Forms.ToolStripSplitButton();
            this.simplementeEnlazadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doblementeEnlazadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxIngDatos.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(29, 51);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(66, 13);
            this.labelDesc.TabIndex = 0;
            this.labelDesc.Text = "Descripción:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(74, 21);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 13);
            this.labelID.TabIndex = 1;
            this.labelID.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ruta de acceso:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(115, 21);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(61, 20);
            this.textBoxID.TabIndex = 3;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(115, 51);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(401, 20);
            this.textBoxDesc.TabIndex = 4;
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Location = new System.Drawing.Point(115, 82);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.Size = new System.Drawing.Size(401, 20);
            this.textBoxRuta.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAdd.Location = new System.Drawing.Point(158, 413);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 58);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDel.Location = new System.Drawing.Point(401, 413);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(125, 58);
            this.buttonDel.TabIndex = 11;
            this.buttonDel.Text = "Eliminar";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // groupBoxIngDatos
            // 
            this.groupBoxIngDatos.Controls.Add(this.buttonOpenFile);
            this.groupBoxIngDatos.Controls.Add(this.textBoxRuta);
            this.groupBoxIngDatos.Controls.Add(this.labelDesc);
            this.groupBoxIngDatos.Controls.Add(this.labelID);
            this.groupBoxIngDatos.Controls.Add(this.label1);
            this.groupBoxIngDatos.Controls.Add(this.textBoxID);
            this.groupBoxIngDatos.Controls.Add(this.textBoxDesc);
            this.groupBoxIngDatos.Location = new System.Drawing.Point(18, 277);
            this.groupBoxIngDatos.Name = "groupBoxIngDatos";
            this.groupBoxIngDatos.Size = new System.Drawing.Size(603, 130);
            this.groupBoxIngDatos.TabIndex = 12;
            this.groupBoxIngDatos.TabStop = false;
            this.groupBoxIngDatos.Text = "Ingreso de Datos";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(522, 82);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 21;
            this.buttonOpenFile.Text = "Abrir Archivo";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.toolStripSplitButtonLista});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(645, 48);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(163, 45);
            this.toolStripLabel1.Text = "Imagenes";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(151, 45);
            this.toolStripLabel2.Text = "                                                ";
            // 
            // toolStripSplitButtonLista
            // 
            this.toolStripSplitButtonLista.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSplitButtonLista.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simplementeEnlazadaToolStripMenuItem,
            this.doblementeEnlazadaToolStripMenuItem,
            this.circularToolStripMenuItem});
            this.toolStripSplitButtonLista.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSplitButtonLista.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonLista.Image")));
            this.toolStripSplitButtonLista.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonLista.Name = "toolStripSplitButtonLista";
            this.toolStripSplitButtonLista.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripSplitButtonLista.Size = new System.Drawing.Size(90, 45);
            this.toolStripSplitButtonLista.Text = "Listas";
            this.toolStripSplitButtonLista.ToolTipText = "Listas";
            this.toolStripSplitButtonLista.ButtonClick += new System.EventHandler(this.toolStripSplitButtonLista_ButtonClick);
            // 
            // simplementeEnlazadaToolStripMenuItem
            // 
            this.simplementeEnlazadaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("simplementeEnlazadaToolStripMenuItem.Image")));
            this.simplementeEnlazadaToolStripMenuItem.Name = "simplementeEnlazadaToolStripMenuItem";
            this.simplementeEnlazadaToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.simplementeEnlazadaToolStripMenuItem.Text = "Simplemente Enlazada";
            this.simplementeEnlazadaToolStripMenuItem.Click += new System.EventHandler(this.simplementeEnlazadaToolStripMenuItem_Click_1);
            // 
            // doblementeEnlazadaToolStripMenuItem
            // 
            this.doblementeEnlazadaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("doblementeEnlazadaToolStripMenuItem.Image")));
            this.doblementeEnlazadaToolStripMenuItem.Name = "doblementeEnlazadaToolStripMenuItem";
            this.doblementeEnlazadaToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.doblementeEnlazadaToolStripMenuItem.Text = "Doblemente Enlazada";
            this.doblementeEnlazadaToolStripMenuItem.Click += new System.EventHandler(this.doblementeEnlazadaToolStripMenuItem_Click);
            // 
            // circularToolStripMenuItem
            // 
            this.circularToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("circularToolStripMenuItem.Image")));
            this.circularToolStripMenuItem.Name = "circularToolStripMenuItem";
            this.circularToolStripMenuItem.Size = new System.Drawing.Size(275, 30);
            this.circularToolStripMenuItem.Text = "Circular";
            this.circularToolStripMenuItem.Click += new System.EventHandler(this.circularToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 207);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripción";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ruta de acceso";
            this.Column3.Name = "Column3";
            this.Column3.Width = 1000;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Escoga su imagen.png";
            this.openFileDialog1.Filter = "Archivos PNG (*.png)|*.png| Archivos JPG(*.jpg)|*.jpg| Archivos JPGE (*.jpge)|*.j" +
    "pge| Archivos GIF(*.gif)|*.gif";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(645, 474);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBoxIngDatos);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxIngDatos.ResumeLayout(false);
            this.groupBoxIngDatos.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxRuta;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.GroupBox groupBoxIngDatos;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonLista;
        private System.Windows.Forms.ToolStripMenuItem simplementeEnlazadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doblementeEnlazadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circularToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

