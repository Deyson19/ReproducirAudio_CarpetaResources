namespace ReproducirAudio_CarpetaResources
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnIncorrecta = new System.Windows.Forms.Button();
            this.btnCorrecta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reproducir un Audio desde la carpeta de recursos del proyecto.";
            // 
            // btnIncorrecta
            // 
            this.btnIncorrecta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncorrecta.Location = new System.Drawing.Point(12, 330);
            this.btnIncorrecta.Name = "btnIncorrecta";
            this.btnIncorrecta.Size = new System.Drawing.Size(111, 43);
            this.btnIncorrecta.TabIndex = 1;
            this.btnIncorrecta.Text = "Audio-Incorrecta";
            this.btnIncorrecta.UseVisualStyleBackColor = true;
            this.btnIncorrecta.Click += new System.EventHandler(this.btnIncorrecta_Click);
            // 
            // btnCorrecta
            // 
            this.btnCorrecta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCorrecta.Location = new System.Drawing.Point(397, 330);
            this.btnCorrecta.Name = "btnCorrecta";
            this.btnCorrecta.Size = new System.Drawing.Size(124, 43);
            this.btnCorrecta.TabIndex = 2;
            this.btnCorrecta.Text = "Audio-Correcta";
            this.btnCorrecta.UseVisualStyleBackColor = true;
            this.btnCorrecta.Click += new System.EventHandler(this.btnCorrecta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReproducirAudio_CarpetaResources.Properties.Resources.System___DevSoft__1_;
            this.ClientSize = new System.Drawing.Size(521, 475);
            this.Controls.Add(this.btnCorrecta);
            this.Controls.Add(this.btnIncorrecta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproducir Audio Interno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIncorrecta;
        private System.Windows.Forms.Button btnCorrecta;
    }
}

