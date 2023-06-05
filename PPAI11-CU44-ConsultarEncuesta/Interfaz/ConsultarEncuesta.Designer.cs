namespace PPAI11_CU44_ConsultarEncuesta.Interfaz
{
    partial class ConsultarEncuesta
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
            this.PnlCE = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.fechaFin = new System.Windows.Forms.DateTimePicker();
            this.BtnCSV = new System.Windows.Forms.Button();
            this.LblFechaInicio = new System.Windows.Forms.Label();
            this.LblFechaFin = new System.Windows.Forms.Label();
            this.LblDatosLlamada = new System.Windows.Forms.Label();
            this.LblLlamadas = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.LblPeriodo = new System.Windows.Forms.Label();
            this.LblDuracion = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblClienteDato = new System.Windows.Forms.Label();
            this.LblEstadoDato = new System.Windows.Forms.Label();
            this.LblDuracionDato = new System.Windows.Forms.Label();
            this.LblPreguntasDatos = new System.Windows.Forms.Label();
            this.LblLinea2 = new System.Windows.Forms.Label();
            this.LblLinea1 = new System.Windows.Forms.Label();
            this.LblDatosEncuesta = new System.Windows.Forms.Label();
            this.LblLinea3 = new System.Windows.Forms.Label();
            this.LblLinea4 = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.PnlCE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlCE
            // 
            this.PnlCE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.PnlCE.Controls.Add(this.BtnSalir);
            this.PnlCE.Controls.Add(this.panel2);
            this.PnlCE.Controls.Add(this.LblTitulo);
            this.PnlCE.Location = new System.Drawing.Point(0, 0);
            this.PnlCE.Name = "PnlCE";
            this.PnlCE.Size = new System.Drawing.Size(911, 20);
            this.PnlCE.TabIndex = 0;
            this.PnlCE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseDown);
            this.PnlCE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseMove);
            this.PnlCE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.titleBar_MouseUp);
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
            this.BtnSalir.Location = new System.Drawing.Point(875, 0);
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
            this.panel2.BackgroundImage = global::PPAI11_CU44_ConsultarEncuesta.Properties.Resources.icon_encuesta;
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
            this.LblTitulo.Size = new System.Drawing.Size(171, 20);
            this.LblTitulo.TabIndex = 9;
            this.LblTitulo.Text = "Consultar Encuesta";
            // 
            // fechaInicio
            // 
            this.fechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaInicio.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold);
            this.fechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaInicio.Location = new System.Drawing.Point(24, 101);
            this.fechaInicio.MaximumSize = new System.Drawing.Size(180, 20);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(180, 20);
            this.fechaInicio.TabIndex = 1;
            // 
            // fechaFin
            // 
            this.fechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fechaFin.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fechaFin.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.fechaFin.CalendarTitleBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.fechaFin.CalendarTitleForeColor = System.Drawing.SystemColors.Info;
            this.fechaFin.CalendarTrailingForeColor = System.Drawing.SystemColors.WindowText;
            this.fechaFin.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold);
            this.fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaFin.Location = new System.Drawing.Point(220, 101);
            this.fechaFin.MaximumSize = new System.Drawing.Size(180, 20);
            this.fechaFin.Name = "fechaFin";
            this.fechaFin.Size = new System.Drawing.Size(180, 20);
            this.fechaFin.TabIndex = 2;
            // 
            // BtnCSV
            // 
            this.BtnCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.BtnCSV.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCSV.FlatAppearance.BorderSize = 0;
            this.BtnCSV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.BtnCSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(116)))));
            this.BtnCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCSV.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnCSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnCSV.Location = new System.Drawing.Point(773, 521);
            this.BtnCSV.Name = "BtnCSV";
            this.BtnCSV.Size = new System.Drawing.Size(110, 20);
            this.BtnCSV.TabIndex = 5;
            this.BtnCSV.Text = "Generar CSV";
            this.BtnCSV.UseVisualStyleBackColor = false;
            this.BtnCSV.Click += new System.EventHandler(this.BtnCSV_Click);
            // 
            // LblFechaInicio
            // 
            this.LblFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFechaInicio.AutoSize = true;
            this.LblFechaInicio.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold);
            this.LblFechaInicio.Location = new System.Drawing.Point(21, 82);
            this.LblFechaInicio.MaximumSize = new System.Drawing.Size(79, 15);
            this.LblFechaInicio.Name = "LblFechaInicio";
            this.LblFechaInicio.Size = new System.Drawing.Size(79, 15);
            this.LblFechaInicio.TabIndex = 8;
            this.LblFechaInicio.Text = "Fecha Inicio";
            // 
            // LblFechaFin
            // 
            this.LblFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFechaFin.AutoSize = true;
            this.LblFechaFin.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold);
            this.LblFechaFin.Location = new System.Drawing.Point(217, 83);
            this.LblFechaFin.MaximumSize = new System.Drawing.Size(79, 15);
            this.LblFechaFin.Name = "LblFechaFin";
            this.LblFechaFin.Size = new System.Drawing.Size(61, 15);
            this.LblFechaFin.TabIndex = 9;
            this.LblFechaFin.Text = "Fecha Fin";
            // 
            // LblDatosLlamada
            // 
            this.LblDatosLlamada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDatosLlamada.AutoSize = true;
            this.LblDatosLlamada.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatosLlamada.Location = new System.Drawing.Point(536, 130);
            this.LblDatosLlamada.Name = "LblDatosLlamada";
            this.LblDatosLlamada.Size = new System.Drawing.Size(121, 15);
            this.LblDatosLlamada.TabIndex = 10;
            this.LblDatosLlamada.Text = "Datos de la Llamada";
            // 
            // LblLlamadas
            // 
            this.LblLlamadas.AutoSize = true;
            this.LblLlamadas.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold);
            this.LblLlamadas.Location = new System.Drawing.Point(21, 130);
            this.LblLlamadas.MaximumSize = new System.Drawing.Size(127, 15);
            this.LblLlamadas.Name = "LblLlamadas";
            this.LblLlamadas.Size = new System.Drawing.Size(127, 15);
            this.LblLlamadas.TabIndex = 11;
            this.LblLlamadas.Text = "Llamadas Disponibles";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(106)))));
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnCancelar.Location = new System.Drawing.Point(24, 520);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 20);
            this.BtnCancelar.TabIndex = 12;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.BtnImprimir.FlatAppearance.BorderSize = 0;
            this.BtnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.BtnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(116)))));
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnImprimir.Location = new System.Drawing.Point(538, 521);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(110, 20);
            this.BtnImprimir.TabIndex = 13;
            this.BtnImprimir.Text = "Imprimir";
            this.BtnImprimir.UseVisualStyleBackColor = false;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(228)))), ((int)(((byte)(187)))));
            this.BtnFiltrar.FlatAppearance.BorderSize = 0;
            this.BtnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.BtnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(215)))), ((int)(((byte)(116)))));
            this.BtnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiltrar.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.BtnFiltrar.Location = new System.Drawing.Point(406, 101);
            this.BtnFiltrar.MaximumSize = new System.Drawing.Size(80, 20);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(80, 20);
            this.BtnFiltrar.TabIndex = 14;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = false;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // LblPeriodo
            // 
            this.LblPeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPeriodo.AutoSize = true;
            this.LblPeriodo.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Bold);
            this.LblPeriodo.Location = new System.Drawing.Point(21, 53);
            this.LblPeriodo.MaximumSize = new System.Drawing.Size(140, 16);
            this.LblPeriodo.Name = "LblPeriodo";
            this.LblPeriodo.Size = new System.Drawing.Size(140, 16);
            this.LblPeriodo.TabIndex = 15;
            this.LblPeriodo.Text = "Seleccionar Periodo";
            // 
            // LblDuracion
            // 
            this.LblDuracion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDuracion.AutoSize = true;
            this.LblDuracion.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDuracion.Location = new System.Drawing.Point(536, 213);
            this.LblDuracion.Name = "LblDuracion";
            this.LblDuracion.Size = new System.Drawing.Size(145, 15);
            this.LblDuracion.TabIndex = 31;
            this.LblDuracion.Text = "Duracion de la llamada:";
            // 
            // LblEstado
            // 
            this.LblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEstado.AutoSize = true;
            this.LblEstado.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstado.Location = new System.Drawing.Point(536, 185);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(133, 15);
            this.LblEstado.TabIndex = 30;
            this.LblEstado.Text = "Estado de la Llamada:";
            // 
            // LblCliente
            // 
            this.LblCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCliente.Location = new System.Drawing.Point(536, 162);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(55, 15);
            this.LblCliente.TabIndex = 29;
            this.LblCliente.Text = "Cliente:";
            // 
            // LblClienteDato
            // 
            this.LblClienteDato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblClienteDato.AutoSize = true;
            this.LblClienteDato.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClienteDato.Location = new System.Drawing.Point(705, 162);
            this.LblClienteDato.Name = "LblClienteDato";
            this.LblClienteDato.Size = new System.Drawing.Size(49, 15);
            this.LblClienteDato.TabIndex = 33;
            this.LblClienteDato.Text = "Cliente";
            // 
            // LblEstadoDato
            // 
            this.LblEstadoDato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEstadoDato.AutoSize = true;
            this.LblEstadoDato.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstadoDato.Location = new System.Drawing.Point(705, 185);
            this.LblEstadoDato.Name = "LblEstadoDato";
            this.LblEstadoDato.Size = new System.Drawing.Size(43, 15);
            this.LblEstadoDato.TabIndex = 34;
            this.LblEstadoDato.Text = "Estado";
            // 
            // LblDuracionDato
            // 
            this.LblDuracionDato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDuracionDato.AutoSize = true;
            this.LblDuracionDato.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDuracionDato.Location = new System.Drawing.Point(705, 213);
            this.LblDuracionDato.Name = "LblDuracionDato";
            this.LblDuracionDato.Size = new System.Drawing.Size(43, 15);
            this.LblDuracionDato.TabIndex = 35;
            this.LblDuracionDato.Text = "Tiempo";
            // 
            // LblPreguntasDatos
            // 
            this.LblPreguntasDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblPreguntasDatos.AutoSize = true;
            this.LblPreguntasDatos.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPreguntasDatos.Location = new System.Drawing.Point(536, 283);
            this.LblPreguntasDatos.Name = "LblPreguntasDatos";
            this.LblPreguntasDatos.Size = new System.Drawing.Size(49, 15);
            this.LblPreguntasDatos.TabIndex = 36;
            this.LblPreguntasDatos.Text = "ejemplo";
            // 
            // LblLinea2
            // 
            this.LblLinea2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLinea2.AutoSize = true;
            this.LblLinea2.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinea2.Location = new System.Drawing.Point(535, 228);
            this.LblLinea2.Name = "LblLinea2";
            this.LblLinea2.Size = new System.Drawing.Size(349, 15);
            this.LblLinea2.TabIndex = 38;
            this.LblLinea2.Text = "_________________________________________________________";
            // 
            // LblLinea1
            // 
            this.LblLinea1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLinea1.AutoSize = true;
            this.LblLinea1.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinea1.Location = new System.Drawing.Point(535, 137);
            this.LblLinea1.Name = "LblLinea1";
            this.LblLinea1.Size = new System.Drawing.Size(349, 15);
            this.LblLinea1.TabIndex = 9;
            this.LblLinea1.Text = "_________________________________________________________";
            // 
            // LblDatosEncuesta
            // 
            this.LblDatosEncuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDatosEncuesta.AutoSize = true;
            this.LblDatosEncuesta.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDatosEncuesta.Location = new System.Drawing.Point(535, 246);
            this.LblDatosEncuesta.Name = "LblDatosEncuesta";
            this.LblDatosEncuesta.Size = new System.Drawing.Size(127, 15);
            this.LblDatosEncuesta.TabIndex = 39;
            this.LblDatosEncuesta.Text = "Datos de la Encuesta";
            // 
            // LblLinea3
            // 
            this.LblLinea3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLinea3.AutoSize = true;
            this.LblLinea3.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinea3.Location = new System.Drawing.Point(535, 251);
            this.LblLinea3.Name = "LblLinea3";
            this.LblLinea3.Size = new System.Drawing.Size(349, 15);
            this.LblLinea3.TabIndex = 49;
            this.LblLinea3.Text = "_________________________________________________________";
            // 
            // LblLinea4
            // 
            this.LblLinea4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLinea4.AutoSize = true;
            this.LblLinea4.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinea4.Location = new System.Drawing.Point(535, 469);
            this.LblLinea4.Name = "LblLinea4";
            this.LblLinea4.Size = new System.Drawing.Size(349, 15);
            this.LblLinea4.TabIndex = 50;
            this.LblLinea4.Text = "_________________________________________________________";
            // 
            // DGV
            // 
            this.DGV.AllowUserToOrderColumns = true;
            this.DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(221)))));
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(24, 149);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.Size = new System.Drawing.Size(462, 347);
            this.DGV.TabIndex = 55;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // ConsultarEncuesta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(895, 553);
            this.Controls.Add(this.DGV);
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
            this.Controls.Add(this.LblPeriodo);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LblLlamadas);
            this.Controls.Add(this.LblFechaFin);
            this.Controls.Add(this.LblFechaInicio);
            this.Controls.Add(this.BtnCSV);
            this.Controls.Add(this.fechaFin);
            this.Controls.Add(this.fechaInicio);
            this.Controls.Add(this.PnlCE);
            this.Controls.Add(this.LblLinea1);
            this.Controls.Add(this.LblLinea3);
            this.Controls.Add(this.LblLinea4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ConsultarEncuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ConsultarEncuesta_Load);
            this.PnlCE.ResumeLayout(false);
            this.PnlCE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlCE;
        private System.Windows.Forms.DateTimePicker fechaInicio;
        private System.Windows.Forms.DateTimePicker fechaFin;
        private System.Windows.Forms.Button BtnCSV;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblFechaInicio;
        private System.Windows.Forms.Label LblFechaFin;
        private System.Windows.Forms.Label LblDatosLlamada;
        private System.Windows.Forms.Label LblLlamadas;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Label LblPeriodo;
        private System.Windows.Forms.Label LblDuracion;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Label LblClienteDato;
        private System.Windows.Forms.Label LblEstadoDato;
        private System.Windows.Forms.Label LblDuracionDato;
        private System.Windows.Forms.Label LblPreguntasDatos;
        private System.Windows.Forms.Label LblLinea2;
        private System.Windows.Forms.Label LblLinea1;
        private System.Windows.Forms.Label LblDatosEncuesta;
        private System.Windows.Forms.Label LblLinea3;
        private System.Windows.Forms.Label LblLinea4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.DataGridView DGV;
    }
}