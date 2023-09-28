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
            profesorIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            NombreMateria = new DataGridViewTextBoxColumn();
            fechaComienzoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaFinalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Evaluaciones = new DataGridViewLinkColumn();

            Evaluaciones = new DataGridViewLinkColumn();


            claseClaseMateriaBindingSource5 = new BindingSource(components);
            claseClaseMateriaBindingSource4 = new BindingSource(components);

            claseClaseMateriaBindingSource3 = new BindingSource(components);
            claseClaseMateriaBindingSource = new BindingSource(components);
            Cerrar = new Button();
            claseClaseMateriaBindingSource1 = new BindingSource(components);
            claseClaseMateriaBindingSource2 = new BindingSource(components);
            claseEvaluacionesBindingSource = new BindingSource(components);
            Button1 = new Button();
            button2 = new Button();
            Buscador = new TextBox();
            Label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)GRILLA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseClaseMateriaBindingSource5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseClaseMateriaBindingSource4).BeginInit();
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

            GRILLA.Columns.AddRange(new DataGridViewColumn[] { claseIDDataGridViewTextBoxColumn, divisionIDDataGridViewTextBoxColumn, profesorIDDataGridViewTextBoxColumn, NombreMateria, fechaComienzoDataGridViewTextBoxColumn, fechaFinalDataGridViewTextBoxColumn, Evaluaciones });
            
            GRILLA.DataSource = claseClaseMateriaBindingSource3;
            GRILLA.DataSource = claseClaseMateriaBindingSource5;

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
            claseIDDataGridViewTextBoxColumn.HeaderText = "Clase_ID";
            claseIDDataGridViewTextBoxColumn.Name = "claseIDDataGridViewTextBoxColumn";
            claseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // divisionIDDataGridViewTextBoxColumn
            // 
            divisionIDDataGridViewTextBoxColumn.DataPropertyName = "Division_ID";
            divisionIDDataGridViewTextBoxColumn.HeaderText = "Division_ID";
            divisionIDDataGridViewTextBoxColumn.Name = "divisionIDDataGridViewTextBoxColumn";
            divisionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // profesorIDDataGridViewTextBoxColumn
            // 

            profesorIDDataGridViewTextBoxColumn.DataPropertyName = "Profesor_ID";
            profesorIDDataGridViewTextBoxColumn.HeaderText = "Profesor_ID";
            profesorIDDataGridViewTextBoxColumn.Name = "profesorIDDataGridViewTextBoxColumn";
            profesorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NombreMateria
            // 
            NombreMateria.DataPropertyName = "NombreMateria";
            NombreMateria.HeaderText = "Nombre De Materia";
            NombreMateria.Name = "NombreMateria";
            NombreMateria.ReadOnly = true;
            // 
            // fechaComienzoDataGridViewTextBoxColumn
            // 
            fechaComienzoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Comienzo";
            fechaComienzoDataGridViewTextBoxColumn.HeaderText = "Fecha Comienzo";
            fechaComienzoDataGridViewTextBoxColumn.Name = "fechaComienzoDataGridViewTextBoxColumn";
            fechaComienzoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFinalDataGridViewTextBoxColumn
            // 
            fechaFinalDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Final";
            fechaFinalDataGridViewTextBoxColumn.HeaderText = "Fecha Final";
            fechaFinalDataGridViewTextBoxColumn.Name = "fechaFinalDataGridViewTextBoxColumn";
            fechaFinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 

            // Evaluaciones
            // 
            Evaluaciones.HeaderText = "Evaluaciones";
            Evaluaciones.Name = "Evaluaciones";
            Evaluaciones.ReadOnly = true;

            Evaluaciones.Text = "Evaluaciones";
            Evaluaciones.UseColumnTextForLinkValue = true;
            // 

            Evaluaciones.UseColumnTextForLinkValue = true;

            // claseClaseMateriaBindingSource5
            // 
            claseClaseMateriaBindingSource5.DataSource = typeof(Clase_ClaseMateria);
            // 
            // claseClaseMateriaBindingSource4
            // 
            claseClaseMateriaBindingSource4.DataSource = typeof(Clase_ClaseMateria);

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
            // Buscador
            // 
            Buscador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Buscador.Location = new Point(104, 26);
            Buscador.MaxLength = 8;
            Buscador.Name = "Buscador";
            Buscador.Size = new Size(546, 23);
            Buscador.TabIndex = 18;
            // 

            // Label1

            // Evaluaciones

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
            ((System.ComponentModel.ISupportInitialize)claseClaseMateriaBindingSource5).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseClaseMateriaBindingSource4).EndInit();
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
        private BindingSource claseClaseMateriaBindingSource;
        private BindingSource claseClaseMateriaBindingSource1;
        private BindingSource claseClaseMateriaBindingSource2;
        private BindingSource claseClaseMateriaBindingSource3;
        private BindingSource claseEvaluacionesBindingSource;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private BindingSource claseClaseMateriaBindingSource4;
        private BindingSource claseClaseMateriaBindingSource5;
        private DataGridViewTextBoxColumn claseIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn divisionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn profesorIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn NombreMateria;
        private DataGridViewTextBoxColumn fechaComienzoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaFinalDataGridViewTextBoxColumn;
        private DataGridViewLinkColumn Evaluaciones;
        private Button Button1;
        private Button button2;
        private TextBox Buscador;
        private Label Label1;
    }
}