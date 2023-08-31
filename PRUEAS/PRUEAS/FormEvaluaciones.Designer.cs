namespace PRUEAS
{
    partial class FormEvaluaciones
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
            Cerrar = new Button();
            Label1 = new Label();
            Buscador = new TextBox();
            button2 = new Button();
            Button1 = new Button();
            claseEvaluacionesBindingSource = new BindingSource(components);
            divisionIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            claseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detallesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            notaPromedioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)GRILLA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource).BeginInit();
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
            GRILLA.Columns.AddRange(new DataGridViewColumn[] { divisionIDDataGridViewTextBoxColumn, claseDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn, detallesDataGridViewTextBoxColumn, notaPromedioDataGridViewTextBoxColumn });
            GRILLA.DataSource = claseEvaluacionesBindingSource;
            GRILLA.Location = new Point(46, 70);
            GRILLA.Name = "GRILLA";
            GRILLA.RowHeadersWidth = 51;
            GRILLA.RowTemplate.Height = 25;
            GRILLA.Size = new Size(753, 382);
            GRILLA.TabIndex = 21;
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
            // claseEvaluacionesBindingSource
            // 
            claseEvaluacionesBindingSource.DataSource = typeof(ClaseEvaluaciones);
            // 
            // divisionIDDataGridViewTextBoxColumn
            // 
            divisionIDDataGridViewTextBoxColumn.DataPropertyName = "Division_ID";
            divisionIDDataGridViewTextBoxColumn.HeaderText = "Division_ID";
            divisionIDDataGridViewTextBoxColumn.Name = "divisionIDDataGridViewTextBoxColumn";
            // 
            // claseDataGridViewTextBoxColumn
            // 
            claseDataGridViewTextBoxColumn.DataPropertyName = "Clase";
            claseDataGridViewTextBoxColumn.HeaderText = "Clase";
            claseDataGridViewTextBoxColumn.Name = "claseDataGridViewTextBoxColumn";
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
            notaPromedioDataGridViewTextBoxColumn.HeaderText = "NotaPromedio";
            notaPromedioDataGridViewTextBoxColumn.Name = "notaPromedioDataGridViewTextBoxColumn";
            // 
            // FormEvaluaciones
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
            Name = "FormEvaluaciones";
            Text = "FormEvaluaciones";
            ((System.ComponentModel.ISupportInitialize)GRILLA).EndInit();
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
        private DataGridViewTextBoxColumn divisionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn claseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn detallesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notaPromedioDataGridViewTextBoxColumn;
        private BindingSource claseEvaluacionesBindingSource;
    }
}