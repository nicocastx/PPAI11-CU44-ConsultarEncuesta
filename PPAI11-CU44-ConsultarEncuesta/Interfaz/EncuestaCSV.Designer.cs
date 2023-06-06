namespace PPAI11_CU44_ConsultarEncuesta
{
    partial class EncuestaCSV
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
            this.PnlCSV = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblPreguntasDatos = new System.Windows.Forms.Label();
            this.LblDato = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblDatosEncuesta = new System.Windows.Forms.Label();
            this.PnlCSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlCSV
            // 
            this.PnlCSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.PnlCSV.Controls.Add(this.BtnSalir);
            this.PnlCSV.Controls.Add(this.panel2);
            this.PnlCSV.Controls.Add(this.LblTitulo);
            this.PnlCSV.Location = new System.Drawing.Point(0, 0);
            this.PnlCSV.Name = "PnlCSV";
            this.PnlCSV.Size = new System.Drawing.Size(832, 20);
            this.PnlCSV.TabIndex = 2;
            this.PnlCSV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.PnlCSV.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            this.PnlCSV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseUp);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnSalir.Location = new System.Drawing.Point(796, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(20, 20);
            this.BtnSalir.TabIndex = 51;
            this.BtnSalir.Text = "X";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.panel2.BackgroundImage = global::PPAI11_CU44_ConsultarEncuesta.Properties.Resources.icon_csv;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 20);
            this.panel2.TabIndex = 10;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Cascadia Mono", 11F, System.Drawing.FontStyle.Bold);
            this.LblTitulo.Location = new System.Drawing.Point(27, 0);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(117, 20);
            this.LblTitulo.TabIndex = 9;
            this.LblTitulo.Text = "Encuesta CSV";
            // 
            // LblPreguntasDatos
            // 
            this.LblPreguntasDatos.AutoSize = true;
            this.LblPreguntasDatos.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreguntasDatos.Location = new System.Drawing.Point(12, 98);
            this.LblPreguntasDatos.Name = "LblPreguntasDatos";
            this.LblPreguntasDatos.Size = new System.Drawing.Size(55, 15);
            this.LblPreguntasDatos.TabIndex = 65;
            this.LblPreguntasDatos.Text = "Pregunta";
            // 
            // LblDato
            // 
            this.LblDato.AutoSize = true;
            this.LblDato.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDato.Location = new System.Drawing.Point(12, 51);
            this.LblDato.Name = "LblDato";
            this.LblDato.Size = new System.Drawing.Size(49, 15);
            this.LblDato.TabIndex = 62;
            this.LblDato.Text = "Cliente";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCliente.Location = new System.Drawing.Point(12, 27);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(313, 15);
            this.LblCliente.TabIndex = 59;
            this.LblCliente.Text = "Cliente,Estado de la Llamada,Duracion de la llamada";
            // 
            // LblDatosEncuesta
            // 
            this.LblDatosEncuesta.AutoSize = true;
            this.LblDatosEncuesta.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatosEncuesta.Location = new System.Drawing.Point(12, 75);
            this.LblDatosEncuesta.Name = "LblDatosEncuesta";
            this.LblDatosEncuesta.Size = new System.Drawing.Size(55, 15);
            this.LblDatosEncuesta.TabIndex = 67;
            this.LblDatosEncuesta.Text = "Encuesta";
            // 
            // EncuestaCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(816, 490);
            this.Controls.Add(this.LblDatosEncuesta);
            this.Controls.Add(this.LblPreguntasDatos);
            this.Controls.Add(this.LblDato);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.PnlCSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EncuestaCSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncuestaCSV";
            this.Load += new System.EventHandler(this.EncuestaCSV_Load);
            this.PnlCSV.ResumeLayout(false);
            this.PnlCSV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlCSV;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblPreguntasDatos;
        private System.Windows.Forms.Label LblDato;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Label LblDatosEncuesta;
    }
}