namespace PRUEAS
{
    partial class FormDivisiones
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
            claseDivisionesBindingSource = new BindingSource(components);
            Cerrar = new Button();
            Label1 = new Label();
            Buscador = new TextBox();
            button2 = new Button();
            Button1 = new Button();
            claseDivisionesBindingSource1 = new BindingSource(components);
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            turno = new DataGridViewTextBoxColumn();
            divisions = new DataGridViewTextBoxColumn();
            Clases = new DataGridViewLinkColumn();
            Alumno = new DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)GRILLA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseDivisionesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseDivisionesBindingSource1).BeginInit();
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
            GRILLA.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, iDDataGridViewTextBoxColumn, turno, divisions, Clases, Alumno });
            GRILLA.DataSource = claseDivisionesBindingSource1;
            GRILLA.Location = new Point(43, 71);
            GRILLA.Name = "GRILLA";
            GRILLA.RowHeadersWidth = 51;
            GRILLA.RowTemplate.Height = 25;
            GRILLA.Size = new Size(753, 382);
            GRILLA.TabIndex = 21;
            // 
            // claseDivisionesBindingSource
            // 
            claseDivisionesBindingSource.DataSource = typeof(ClaseDivisiones);
            // 
            // Cerrar
            // 
            Cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Cerrar.AutoSize = true;
            Cerrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Cerrar.Location = new Point(792, 466);
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
            Label1.Location = new Point(43, 21);
            Label1.Name = "Label1";
            Label1.Size = new Size(58, 20);
            Label1.TabIndex = 19;
            Label1.Text = "Buscar";
            // 
            // Buscador
            // 
            Buscador.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Buscador.Location = new Point(119, 22);
            Buscador.MaxLength = 8;
            Buscador.Name = "Buscador";
            Buscador.Size = new Size(518, 23);
            Buscador.TabIndex = 18;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(731, 22);
            button2.Name = "button2";
            button2.Size = new Size(79, 30);
            button2.TabIndex = 17;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button1.Location = new Point(646, 21);
            Button1.Name = "Button1";
            Button1.Size = new Size(79, 30);
            Button1.TabIndex = 16;
            Button1.Text = "Buscar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // claseDivisionesBindingSource1
            // 
            claseDivisionesBindingSource1.DataSource = typeof(ClaseDivisiones);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // turno
            // 
            turno.DataPropertyName = "turno";
            turno.HeaderText = "Turno";
            turno.Name = "turno";
            // 
            // divisions
            // 
            divisions.DataPropertyName = "divisions";
            divisions.HeaderText = "Divisions";
            divisions.Name = "divisions";
            // 
            // Clases
            // 
            Clases.HeaderText = "Clases";
            Clases.Name = "Clases";
            Clases.Resizable = DataGridViewTriState.True;
            Clases.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Alumno
            // 
            Alumno.HeaderText = "Alumno";
            Alumno.Name = "Alumno";
            Alumno.Resizable = DataGridViewTriState.True;
            Alumno.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // FormDivisiones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 505);
            Controls.Add(GRILLA);
            Controls.Add(Cerrar);
            Controls.Add(Label1);
            Controls.Add(Buscador);
            Controls.Add(button2);
            Controls.Add(Button1);
            Name = "FormDivisiones";
            Text = "FormDivisiones";
            ((System.ComponentModel.ISupportInitialize)GRILLA).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseDivisionesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseDivisionesBindingSource1).EndInit();
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
        private BindingSource claseDivisionesBindingSource;
        private DataGridViewTextBoxColumn divisionsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turnoDataGridViewTextBoxColumn;
        private BindingSource claseDivisionesBindingSource1;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn turno;
        private DataGridViewTextBoxColumn divisions;
        private DataGridViewLinkColumn Clases;
        private DataGridViewLinkColumn Alumno;
    }
}