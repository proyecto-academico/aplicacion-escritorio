namespace PRUEAS
{
    partial class FormVerMateria
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            GRILLA = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            anioescolarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horassemanalesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Clases = new DataGridViewLinkColumn();
            claseMateriaBindingSource = new BindingSource(components);
            claseMateriaBindingSource1 = new BindingSource(components);
            Cerrar = new Button();
            Label1 = new Label();
            Buscador = new TextBox();
            button2 = new Button();
            Button1 = new Button();
            claseEvaluacionesBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)GRILLA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseMateriaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseMateriaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // GRILLA
            // 
            GRILLA.AllowUserToDeleteRows = false;
            GRILLA.AutoGenerateColumns = false;
            GRILLA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GRILLA.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            GRILLA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            GRILLA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GRILLA.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, anioescolarDataGridViewTextBoxColumn, horassemanalesDataGridViewTextBoxColumn, Clases });
            GRILLA.DataSource = claseMateriaBindingSource;
            GRILLA.Location = new Point(44, 59);
            GRILLA.Name = "GRILLA";
            GRILLA.RowHeadersWidth = 51;
            GRILLA.RowTemplate.Height = 25;
            GRILLA.Size = new Size(753, 382);
            GRILLA.TabIndex = 15;
            GRILLA.CellContentClick += GRILLA_CellContentClick;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // anioescolarDataGridViewTextBoxColumn
            // 
            anioescolarDataGridViewTextBoxColumn.DataPropertyName = "Anio_escolar";
            anioescolarDataGridViewTextBoxColumn.HeaderText = "Anio_escolar";
            anioescolarDataGridViewTextBoxColumn.Name = "anioescolarDataGridViewTextBoxColumn";
            // 
            // horassemanalesDataGridViewTextBoxColumn
            // 
            horassemanalesDataGridViewTextBoxColumn.DataPropertyName = "Horas_semanales";
            horassemanalesDataGridViewTextBoxColumn.HeaderText = "Horas_semanales";
            horassemanalesDataGridViewTextBoxColumn.Name = "horassemanalesDataGridViewTextBoxColumn";
            // 
            // Clases
            // 
            Clases.HeaderText = "Clases";
            Clases.Name = "Clases";
            Clases.UseColumnTextForLinkValue = true;
            // 
            // claseMateriaBindingSource
            // 
            claseMateriaBindingSource.DataSource = typeof(ClaseMateria);
            // 
            // claseMateriaBindingSource1
            // 
            claseMateriaBindingSource1.DataSource = typeof(ClaseMateria);
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
            Cerrar.TabIndex = 14;
            Cerrar.Text = "SALIR";
            Cerrar.UseVisualStyleBackColor = true;
            Cerrar.Click += Cerrar_Click;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label1.Location = new Point(44, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(58, 20);
            Label1.TabIndex = 13;
            Label1.Text = "Buscar";
            // 
            // Buscador
            // 
            Buscador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Buscador.Location = new Point(120, 10);
            Buscador.MaxLength = 8;
            Buscador.Name = "Buscador";
            Buscador.Size = new Size(504, 23);
            Buscador.TabIndex = 12;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(718, 10);
            button2.Name = "button2";
            button2.Size = new Size(79, 30);
            button2.TabIndex = 11;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button1.Location = new Point(633, 9);
            Button1.Name = "Button1";
            Button1.Size = new Size(79, 30);
            Button1.TabIndex = 10;
            Button1.Text = "Buscar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // claseEvaluacionesBindingSource
            // 
            claseEvaluacionesBindingSource.DataSource = typeof(ClaseEvaluaciones);
            // 
            // FormVerMateria
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
            Name = "FormVerMateria";
            Text = "FormVerMateria";
            Load += FormVerMateria_Load;
            ((System.ComponentModel.ISupportInitialize)GRILLA).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseMateriaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseMateriaBindingSource1).EndInit();
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
        private BindingSource claseMateriaBindingSource;
        private BindingSource claseMateriaBindingSource1;
        private BindingSource claseEvaluacionesBindingSource;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn anioescolarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horassemanalesDataGridViewTextBoxColumn;
        private DataGridViewLinkColumn Clases;
    }
}