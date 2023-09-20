namespace PRUEAS
{
    partial class FormVerEvaluaciones
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            GRILLA = new DataGridView();
            claseEvaluacionesBindingSource6 = new BindingSource(components);
            claseEvaluacionesBindingSource5 = new BindingSource(components);
            claseEvaluacionesBindingSource3 = new BindingSource(components);
            claseEvaluacionesBindingSource1 = new BindingSource(components);
            claseEvaluacionesBindingSource = new BindingSource(components);
            Cerrar = new Button();
            Label1 = new Label();
            Buscador = new TextBox();
            button2 = new Button();
            Button1 = new Button();
            clasenotasBindingSource = new BindingSource(components);
            claseEvaluacionesBindingSource2 = new BindingSource(components);
            claseEvaluacionesBindingSource4 = new BindingSource(components);
            evaluacionIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            claseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Clase_Name = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detallesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            notaPromedioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)GRILLA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clasenotasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource4).BeginInit();
            SuspendLayout();
            // 
            // GRILLA
            // 
            GRILLA.AllowUserToDeleteRows = false;
            GRILLA.AutoGenerateColumns = false;
            GRILLA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GRILLA.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            GRILLA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            GRILLA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GRILLA.Columns.AddRange(new DataGridViewColumn[] { evaluacionIDDataGridViewTextBoxColumn, claseDataGridViewTextBoxColumn, Clase_Name, fechaDataGridViewTextBoxColumn, detallesDataGridViewTextBoxColumn, notaPromedioDataGridViewTextBoxColumn });
            GRILLA.DataSource = claseEvaluacionesBindingSource6;
            GRILLA.Location = new Point(46, 70);
            GRILLA.Name = "GRILLA";
            GRILLA.RowHeadersWidth = 51;
            GRILLA.RowTemplate.Height = 25;
            GRILLA.Size = new Size(753, 382);
            GRILLA.TabIndex = 21;
            GRILLA.CellContentClick += GRILLA_CellContentClick;
            // 
            // claseEvaluacionesBindingSource6
            // 
            claseEvaluacionesBindingSource6.DataSource = typeof(ClaseEvaluaciones);
            // 
            // claseEvaluacionesBindingSource5
            // 
            claseEvaluacionesBindingSource5.DataSource = typeof(ClaseEvaluaciones);
            // 
            // claseEvaluacionesBindingSource3
            // 
            claseEvaluacionesBindingSource3.DataSource = typeof(ClaseEvaluaciones);
            // 
            // claseEvaluacionesBindingSource1
            // 
            claseEvaluacionesBindingSource1.DataSource = typeof(ClaseEvaluaciones);
            // 
            // claseEvaluacionesBindingSource
            // 
            claseEvaluacionesBindingSource.DataSource = typeof(ClaseEvaluaciones);
            // 
            // Cerrar
            // 
            Cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Cerrar.AutoSize = true;
            Cerrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Cerrar.Location = new Point(778, 458);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(58, 27);
            Cerrar.TabIndex = 20;
            Cerrar.Text = "SALIR";
            Cerrar.UseVisualStyleBackColor = true;
            Cerrar.Click += Cerrar_Click;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label1.Location = new Point(46, 20);
            Label1.Name = "Label1";
            Label1.Size = new Size(58, 20);
            Label1.TabIndex = 19;
            Label1.Text = "Buscar";
            // 
            // Buscador
            // 
            Buscador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Buscador.Location = new Point(122, 21);
            Buscador.MaxLength = 8;
            Buscador.Name = "Buscador";
            Buscador.Size = new Size(504, 23);
            Buscador.TabIndex = 18;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(720, 21);
            button2.Name = "button2";
            button2.Size = new Size(79, 30);
            button2.TabIndex = 17;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button1.Location = new Point(635, 20);
            Button1.Name = "Button1";
            Button1.Size = new Size(79, 30);
            Button1.TabIndex = 16;
            Button1.Text = "Buscar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // clasenotasBindingSource
            // 
            clasenotasBindingSource.DataSource = typeof(Clasenotas);
            // 
            // claseEvaluacionesBindingSource2
            // 
            claseEvaluacionesBindingSource2.DataSource = typeof(ClaseEvaluaciones);
            // 
            // claseEvaluacionesBindingSource4
            // 
            claseEvaluacionesBindingSource4.DataSource = typeof(ClaseEvaluaciones);
            // 
            // evaluacionIDDataGridViewTextBoxColumn
            // 
            evaluacionIDDataGridViewTextBoxColumn.DataPropertyName = "Evaluacion_ID";
            evaluacionIDDataGridViewTextBoxColumn.HeaderText = "Evaluacion";
            evaluacionIDDataGridViewTextBoxColumn.Name = "evaluacionIDDataGridViewTextBoxColumn";
            // 
            // claseDataGridViewTextBoxColumn
            // 
            claseDataGridViewTextBoxColumn.DataPropertyName = "Clase";
            claseDataGridViewTextBoxColumn.HeaderText = "Clase_ID";
            claseDataGridViewTextBoxColumn.Name = "claseDataGridViewTextBoxColumn";
            // 
            // Clase_Name
            // 
            Clase_Name.DataPropertyName = "Clase_Name";
            Clase_Name.HeaderText = "Clase";
            Clase_Name.Name = "Clase_Name";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // detallesDataGridViewTextBoxColumn
            // 
            detallesDataGridViewTextBoxColumn.DataPropertyName = "Detalles";
            detallesDataGridViewTextBoxColumn.HeaderText = "Detalles";
            detallesDataGridViewTextBoxColumn.Name = "detallesDataGridViewTextBoxColumn";
            // 
            // notaPromedioDataGridViewTextBoxColumn
            // 
            notaPromedioDataGridViewTextBoxColumn.DataPropertyName = "NotaPromedio";
            notaPromedioDataGridViewTextBoxColumn.HeaderText = "Nota Promedio";
            notaPromedioDataGridViewTextBoxColumn.Name = "notaPromedioDataGridViewTextBoxColumn";
            // 
            // FormVerEvaluaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 497);
            Controls.Add(GRILLA);
            Controls.Add(Cerrar);
            Controls.Add(Label1);
            Controls.Add(Buscador);
            Controls.Add(button2);
            Controls.Add(Button1);
            Name = "FormVerEvaluaciones";
            Text = "FormEvaluaciones";
            Load += FormVerEvaluaciones_Load;
            ((System.ComponentModel.ISupportInitialize)GRILLA).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource6).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource5).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clasenotasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GRILLA;
        private Button Cerrar;
        private Label Label1;
        private TextBox Buscador;
        private Button button2;
        private Button Button1;
        private BindingSource claseEvaluacionesBindingSource;
        private BindingSource claseEvaluacionesBindingSource1;
        private BindingSource clasenotasBindingSource;
        private BindingSource claseEvaluacionesBindingSource2;
        private BindingSource claseEvaluacionesBindingSource3;
        private DataGridViewTextBoxColumn evaluacion;
        private BindingSource claseEvaluacionesBindingSource4;
        private BindingSource claseEvaluacionesBindingSource5;
        private BindingSource claseEvaluacionesBindingSource6;
        private DataGridViewTextBoxColumn evaluacionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn claseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Clase_Name;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn detallesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notaPromedioDataGridViewTextBoxColumn;
    }
}