namespace PruebaDeLinkedList1
{
    partial class FormGaleria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelRuta = new System.Windows.Forms.Label();
            this.buttonSig = new System.Windows.Forms.Button();
            this.buttonReinicio = new System.Windows.Forms.Button();
            this.buttonAnt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.BackColor = System.Drawing.Color.Transparent;
            this.labelDesc.Location = new System.Drawing.Point(12, 9);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(63, 13);
            this.labelDesc.TabIndex = 1;
            this.labelDesc.Text = "Descripcion";
            // 
            // labelRuta
            // 
            this.labelRuta.AutoSize = true;
            this.labelRuta.BackColor = System.Drawing.Color.Transparent;
            this.labelRuta.Location = new System.Drawing.Point(12, 428);
            this.labelRuta.Name = "labelRuta";
            this.labelRuta.Size = new System.Drawing.Size(83, 13);
            this.labelRuta.TabIndex = 2;
            this.labelRuta.Text = "Ruta de acceso";
            this.labelRuta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSig
            // 
            this.buttonSig.BackColor = System.Drawing.Color.Transparent;
            this.buttonSig.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSig.Location = new System.Drawing.Point(762, 138);
            this.buttonSig.Name = "buttonSig";
            this.buttonSig.Size = new System.Drawing.Size(26, 166);
            this.buttonSig.TabIndex = 3;
            this.buttonSig.Text = ">";
            this.buttonSig.UseVisualStyleBackColor = false;
            this.buttonSig.Click += new System.EventHandler(this.buttonSig_Click);
            // 
            // buttonReinicio
            // 
            this.buttonReinicio.Location = new System.Drawing.Point(692, 9);
            this.buttonReinicio.Name = "buttonReinicio";
            this.buttonReinicio.Size = new System.Drawing.Size(96, 23);
            this.buttonReinicio.TabIndex = 4;
            this.buttonReinicio.Text = "Reiniciar Lista";
            this.buttonReinicio.UseVisualStyleBackColor = true;
            this.buttonReinicio.Click += new System.EventHandler(this.buttonReinicio_Click);
            // 
            // buttonAnt
            // 
            this.buttonAnt.BackColor = System.Drawing.Color.Transparent;
            this.buttonAnt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAnt.Location = new System.Drawing.Point(12, 138);
            this.buttonAnt.Name = "buttonAnt";
            this.buttonAnt.Size = new System.Drawing.Size(26, 166);
            this.buttonAnt.TabIndex = 5;
            this.buttonAnt.Text = "<";
            this.buttonAnt.UseVisualStyleBackColor = false;
            this.buttonAnt.Click += new System.EventHandler(this.buttonAnt_Click);
            // 
            // FormGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAnt);
            this.Controls.Add(this.buttonReinicio);
            this.Controls.Add(this.buttonSig);
            this.Controls.Add(this.labelRuta);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormGaleria";
            this.Text = "Album de fotos";
            this.Load += new System.EventHandler(this.FormGaleria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelRuta;
        private System.Windows.Forms.Button buttonSig;
        private System.Windows.Forms.Button buttonReinicio;
        private System.Windows.Forms.Button buttonAnt;
    }
}