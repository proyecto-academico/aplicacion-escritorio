namespace PRUEAS
{
    partial class FormVerClaseMateria
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
            claseIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            divisionIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materiaIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            profesorIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaComienzoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaFinalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Evaluaciones = new DataGridViewLinkColumn();
            claseClaseMateriaBindingSource3 = new BindingSource(components);
            claseClaseMateriaBindingSource = new BindingSource(components);
            Cerrar = new Button();
            Label1 = new Label();
            Buscador = new TextBox();
            button2 = new Button();
            Button1 = new Button();
            claseClaseMateriaBindingSource1 = new BindingSource(components);
            claseClaseMateriaBindingSource2 = new BindingSource(components);
            claseEvaluacionesBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)GRILLA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseClaseMateriaBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseClaseMateriaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseClaseMateriaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseClaseMateriaBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // GRILLA
            // 
            GRILLA.AllowUserToDeleteRows = false;
            GRILLA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            GRILLA.Columns.AddRange(new DataGridViewColumn[] { claseIDDataGridViewTextBoxColumn, divisionIDDataGridViewTextBoxColumn, materiaIDDataGridViewTextBoxColumn, profesorIDDataGridViewTextBoxColumn, fechaComienzoDataGridViewTextBoxColumn, fechaFinalDataGridViewTextBoxColumn, Evaluaciones });
            GRILLA.DataSource = claseClaseMateriaBindingSource3;
            GRILLA.Location = new Point(28, 84);
            GRILLA.Name = "GRILLA";
            GRILLA.ReadOnly = true;
            GRILLA.RowHeadersWidth = 51;
            GRILLA.RowTemplate.Height = 25;
            GRILLA.Size = new Size(792, 360);
            GRILLA.TabIndex = 21;
            // 
            // claseIDDataGridViewTextBoxColumn
            // 
            claseIDDataGridViewTextBoxColumn.DataPropertyName = "Clase_ID";
            claseIDDataGridViewTextBoxColumn.HeaderText = "Clase";
            claseIDDataGridViewTextBoxColumn.Name = "claseIDDataGridViewTextBoxColumn";
            claseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // divisionIDDataGridViewTextBoxColumn
            // 
            divisionIDDataGridViewTextBoxColumn.DataPropertyName = "Division_ID";
            divisionIDDataGridViewTextBoxColumn.HeaderText = "Division";
            divisionIDDataGridViewTextBoxColumn.Name = "divisionIDDataGridViewTextBoxColumn";
            divisionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // materiaIDDataGridViewTextBoxColumn
            // 
            materiaIDDataGridViewTextBoxColumn.DataPropertyName = "Materia_ID";
            materiaIDDataGridViewTextBoxColumn.HeaderText = "Materia";
            materiaIDDataGridViewTextBoxColumn.Name = "materiaIDDataGridViewTextBoxColumn";
            materiaIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profesorIDDataGridViewTextBoxColumn
            // 
            profesorIDDataGridViewTextBoxColumn.DataPropertyName = "Profesor_ID";
            profesorIDDataGridViewTextBoxColumn.HeaderText = "Profesor";
            profesorIDDataGridViewTextBoxColumn.Name = "profesorIDDataGridViewTextBoxColumn";
            profesorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaComienzoDataGridViewTextBoxColumn
            // 
            fechaComienzoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Comienzo";
            fechaComienzoDataGridViewTextBoxColumn.HeaderText = "Fecha_Comienzo";
            fechaComienzoDataGridViewTextBoxColumn.Name = "fechaComienzoDataGridViewTextBoxColumn";
            fechaComienzoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFinalDataGridViewTextBoxColumn
            // 
            fechaFinalDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Final";
            fechaFinalDataGridViewTextBoxColumn.HeaderText = "Fecha_Final";
            fechaFinalDataGridViewTextBoxColumn.Name = "fechaFinalDataGridViewTextBoxColumn";
            fechaFinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Evaluaciones
            // 
            Evaluaciones.HeaderText = "Evaluaciones";
            Evaluaciones.Name = "Evaluaciones";
            Evaluaciones.ReadOnly = true;
            Evaluaciones.UseColumnTextForLinkValue = true;
            // 
            // claseClaseMateriaBindingSource3
            // 
            claseClaseMateriaBindingSource3.DataSource = typeof(Clase_ClaseMateria);
            // 
            // claseClaseMateriaBindingSource
            // 
            claseClaseMateriaBindingSource.DataSource = typeof(Clase_ClaseMateria);
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
            Label1.Location = new Point(40, 25);
            Label1.Name = "Label1";
            Label1.Size = new Size(58, 20);
            Label1.TabIndex = 19;
            Label1.Text = "Buscar";
            Label1.Click += Label1_Click;
            // 
            // Buscador
            // 
            Buscador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Buscador.Location = new Point(104, 26);
            Buscador.MaxLength = 8;
            Buscador.Name = "Buscador";
            Buscador.Size = new Size(546, 23);
            Buscador.TabIndex = 18;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(741, 26);
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
            Button1.Location = new Point(656, 26);
            Button1.Name = "Button1";
            Button1.Size = new Size(79, 30);
            Button1.TabIndex = 16;
            Button1.Text = "Buscar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // claseClaseMateriaBindingSource1
            // 
            claseClaseMateriaBindingSource1.DataSource = typeof(Clase_ClaseMateria);
            // 
            // claseClaseMateriaBindingSource2
            // 
            claseClaseMateriaBindingSource2.DataSource = typeof(Clase_ClaseMateria);
            // 
            // claseEvaluacionesBindingSource
            // 
            claseEvaluacionesBindingSource.DataSource = typeof(ClaseEvaluaciones);
            // 
            // FormVerClaseMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(848, 497);
            Controls.Add(GRILLA);
            Controls.Add(Cerrar);
            Controls.Add(Label1);
            Controls.Add(Buscador);
            Controls.Add(button2);
            Controls.Add(Button1);
            Name = "FormVerClaseMateria";
            Text = "FormClaseMateria";
            Load += FormClaseMateria_Load;
            ((System.ComponentModel.ISupportInitialize)GRILLA).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseClaseMateriaBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseClaseMateriaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseClaseMateriaBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseClaseMateriaBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource).EndInit();
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
        private BindingSource claseClaseMateriaBindingSource;
        private BindingSource claseClaseMateriaBindingSource1;
        private BindingSource claseClaseMateriaBindingSource2;
        private BindingSource claseClaseMateriaBindingSource3;
        private BindingSource claseEvaluacionesBindingSource;
        private DataGridViewTextBoxColumn claseIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn divisionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materiaIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profesorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaComienzoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinalDataGridViewTextBoxColumn;
        private DataGridViewLinkColumn Evaluaciones;
    }
}