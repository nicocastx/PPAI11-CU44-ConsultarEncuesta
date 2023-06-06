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
            this.LblDatosEncuesta = new System.Windows.Forms.Label();
            this.LblDatosLlamada = new System.Windows.Forms.Label();
            this.LblLinea2 = new System.Windows.Forms.Label();
            this.LblPreguntasDatos = new System.Windows.Forms.Label();
            this.LblDuracionDato = new System.Windows.Forms.Label();
            this.LblEstadoDato = new System.Windows.Forms.Label();
            this.LblClienteDato = new System.Windows.Forms.Label();
            this.LblDuracion = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblLinea1 = new System.Windows.Forms.Label();
            this.LblLinea3 = new System.Windows.Forms.Label();
            this.LblLinea4 = new System.Windows.Forms.Label();
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
            // LblDatosEncuesta
            // 
            this.LblDatosEncuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDatosEncuesta.AutoSize = true;
            this.LblDatosEncuesta.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatosEncuesta.Location = new System.Drawing.Point(284, 200);
            this.LblDatosEncuesta.Name = "LblDatosEncuesta";
            this.LblDatosEncuesta.Size = new System.Drawing.Size(127, 15);
            this.LblDatosEncuesta.TabIndex = 67;
            this.LblDatosEncuesta.Text = "Datos de la Encuesta";
            // 
            // LblDatosLlamada
            // 
            this.LblDatosLlamada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDatosLlamada.AutoSize = true;
            this.LblDatosLlamada.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatosLlamada.Location = new System.Drawing.Point(280, 42);
            this.LblDatosLlamada.Name = "LblDatosLlamada";
            this.LblDatosLlamada.Size = new System.Drawing.Size(121, 15);
            this.LblDatosLlamada.TabIndex = 56;
            this.LblDatosLlamada.Text = "Datos de la Llamada";
            // 
            // LblLinea2
            // 
            this.LblLinea2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLinea2.AutoSize = true;
            this.LblLinea2.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinea2.Location = new System.Drawing.Point(284, 182);
            this.LblLinea2.Name = "LblLinea2";
            this.LblLinea2.Size = new System.Drawing.Size(253, 15);
            this.LblLinea2.TabIndex = 66;
            this.LblLinea2.Text = "_________________________________________";
            // 
            // LblPreguntasDatos
            // 
            this.LblPreguntasDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPreguntasDatos.AutoSize = true;
            this.LblPreguntasDatos.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreguntasDatos.Location = new System.Drawing.Point(285, 233);
            this.LblPreguntasDatos.Name = "LblPreguntasDatos";
            this.LblPreguntasDatos.Size = new System.Drawing.Size(91, 15);
            this.LblPreguntasDatos.TabIndex = 65;
            this.LblPreguntasDatos.Text = "Kevin Dictador";
            // 
            // LblDuracionDato
            // 
            this.LblDuracionDato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDuracionDato.AutoSize = true;
            this.LblDuracionDato.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDuracionDato.Location = new System.Drawing.Point(454, 167);
            this.LblDuracionDato.Name = "LblDuracionDato";
            this.LblDuracionDato.Size = new System.Drawing.Size(61, 15);
            this.LblDuracionDato.TabIndex = 64;
            this.LblDuracionDato.Text = "35minutos";
            // 
            // LblEstadoDato
            // 
            this.LblEstadoDato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEstadoDato.AutoSize = true;
            this.LblEstadoDato.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstadoDato.Location = new System.Drawing.Point(454, 139);
            this.LblEstadoDato.Name = "LblEstadoDato";
            this.LblEstadoDato.Size = new System.Drawing.Size(67, 15);
            this.LblEstadoDato.TabIndex = 63;
            this.LblEstadoDato.Text = "Finalizada";
            // 
            // LblClienteDato
            // 
            this.LblClienteDato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblClienteDato.AutoSize = true;
            this.LblClienteDato.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClienteDato.Location = new System.Drawing.Point(454, 108);
            this.LblClienteDato.Name = "LblClienteDato";
            this.LblClienteDato.Size = new System.Drawing.Size(61, 15);
            this.LblClienteDato.TabIndex = 62;
            this.LblClienteDato.Text = "Cliente 1";
            // 
            // LblDuracion
            // 
            this.LblDuracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDuracion.AutoSize = true;
            this.LblDuracion.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDuracion.Location = new System.Drawing.Point(285, 167);
            this.LblDuracion.Name = "LblDuracion";
            this.LblDuracion.Size = new System.Drawing.Size(145, 15);
            this.LblDuracion.TabIndex = 61;
            this.LblDuracion.Text = "Duracion de la llamada:";
            // 
            // LblEstado
            // 
            this.LblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(285, 139);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(133, 15);
            this.LblEstado.TabIndex = 60;
            this.LblEstado.Text = "Estado de la Llamada:";
            // 
            // LblCliente
            // 
            this.LblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCliente.Location = new System.Drawing.Point(285, 108);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(55, 15);
            this.LblCliente.TabIndex = 59;
            this.LblCliente.Text = "Cliente:";
            // 
            // LblLinea1
            // 
            this.LblLinea1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLinea1.AutoSize = true;
            this.LblLinea1.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinea1.Location = new System.Drawing.Point(284, 91);
            this.LblLinea1.Name = "LblLinea1";
            this.LblLinea1.Size = new System.Drawing.Size(253, 15);
            this.LblLinea1.TabIndex = 55;
            this.LblLinea1.Text = "_________________________________________";
            // 
            // LblLinea3
            // 
            this.LblLinea3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLinea3.AutoSize = true;
            this.LblLinea3.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinea3.Location = new System.Drawing.Point(284, 205);
            this.LblLinea3.Name = "LblLinea3";
            this.LblLinea3.Size = new System.Drawing.Size(253, 15);
            this.LblLinea3.TabIndex = 77;
            this.LblLinea3.Text = "_________________________________________";
            // 
            // LblLinea4
            // 
            this.LblLinea4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLinea4.AutoSize = true;
            this.LblLinea4.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinea4.Location = new System.Drawing.Point(284, 423);
            this.LblLinea4.Name = "LblLinea4";
            this.LblLinea4.Size = new System.Drawing.Size(253, 15);
            this.LblLinea4.TabIndex = 78;
            this.LblLinea4.Text = "_________________________________________";
            // 
            // EncuestaCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(816, 490);
            this.Controls.Add(this.LblDatosEncuesta);
            this.Controls.Add(this.LblDatosLlamada);
            this.Controls.Add(this.LblLinea2);
            this.Controls.Add(this.LblPreguntasDatos);
            this.Controls.Add(this.LblDuracionDato);
            this.Controls.Add(this.LblEstadoDato);
            this.Controls.Add(this.LblClienteDato);
            this.Controls.Add(this.LblDuracion);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.LblLinea1);
            this.Controls.Add(this.LblLinea3);
            this.Controls.Add(this.LblLinea4);
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
        private System.Windows.Forms.Label LblDatosEncuesta;
        private System.Windows.Forms.Label LblDatosLlamada;
        private System.Windows.Forms.Label LblLinea2;
        private System.Windows.Forms.Label LblPreguntasDatos;
        private System.Windows.Forms.Label LblDuracionDato;
        private System.Windows.Forms.Label LblEstadoDato;
        private System.Windows.Forms.Label LblClienteDato;
        private System.Windows.Forms.Label LblDuracion;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Label LblLinea1;
        private System.Windows.Forms.Label LblLinea3;
        private System.Windows.Forms.Label LblLinea4;
    }
}