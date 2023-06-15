namespace PRUEAS
{
    partial class BaseDeDatos
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
            Button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            Label1 = new Label();
            Cerrar = new Button();
            GRILLA = new DataGridView();
            personasBindingSource2 = new BindingSource(components);
            personasBindingSource = new BindingSource(components);
            personasBindingSource1 = new BindingSource(components);
            FiltroPersonas = new CheckedListBox();
            _dni = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Notas = new DataGridViewLinkColumn();
            Faltas = new DataGridViewLinkColumn();
            edit = new DataGridViewLinkColumn();
            X = new DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)GRILLA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Button1.Location = new Point(634, 58);
            Button1.Name = "Button1";
            Button1.Size = new Size(79, 30);
            Button1.TabIndex = 1;
            Button1.Text = "Buscar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(719, 59);
            button2.Name = "button2";
            button2.Size = new Size(79, 30);
            button2.TabIndex = 2;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(121, 59);
            textBox1.MaxLength = 8;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(504, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Label1
            // 
            Label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label1.Location = new Point(45, 58);
            Label1.Name = "Label1";
            Label1.Size = new Size(74, 25);
            Label1.TabIndex = 4;
            Label1.Text = "Buscar";
            // 
            // Cerrar
            // 
            Cerrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Cerrar.AutoSize = true;
            Cerrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Cerrar.Location = new Point(739, 507);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(66, 30);
            Cerrar.TabIndex = 5;
            Cerrar.Text = "SALIR";
            Cerrar.UseVisualStyleBackColor = true;
            Cerrar.Click += Cerrar_Click;
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
            GRILLA.Columns.AddRange(new DataGridViewColumn[] { _dni, nameDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn, mailDataGridViewTextBoxColumn, Notas, Faltas, edit, X });
            GRILLA.DataSource = personasBindingSource2;
            GRILLA.Location = new Point(45, 108);
            GRILLA.Name = "GRILLA";
            GRILLA.ReadOnly = true;
            GRILLA.RowHeadersWidth = 51;
            GRILLA.RowTemplate.Height = 25;
            GRILLA.Size = new Size(746, 379);
            GRILLA.TabIndex = 6;
            GRILLA.CellContentClick += GRILLA_CellContentClick;
            // 
            // personasBindingSource2
            // 
            personasBindingSource2.DataSource = typeof(Personas);
            // 
            // personasBindingSource
            // 
            personasBindingSource.DataSource = typeof(Personas);
            // 
            // personasBindingSource1
            // 
            personasBindingSource1.DataSource = typeof(Personas);
            // 
            // FiltroPersonas
            // 
            FiltroPersonas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FiltroPersonas.Font = new Font("Arial", 10.8F, FontStyle.Underline, GraphicsUnit.Point);
            FiltroPersonas.FormattingEnabled = true;
            FiltroPersonas.Items.AddRange(new object[] { "Profesores", "Alumnos", "Administracion" });
            FiltroPersonas.Location = new Point(57, 507);
            FiltroPersonas.Margin = new Padding(0);
            FiltroPersonas.MultiColumn = true;
            FiltroPersonas.Name = "FiltroPersonas";
            FiltroPersonas.Size = new Size(463, 27);
            FiltroPersonas.TabIndex = 7;
            // 
            // _dni
            // 
            _dni.DataPropertyName = "_dni";
            _dni.HeaderText = "DNI";
            _dni.MinimumWidth = 6;
            _dni.Name = "_dni";
            _dni.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            mailDataGridViewTextBoxColumn.HeaderText = "mail";
            mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Notas
            // 
            Notas.HeaderText = "Notas";
            Notas.MinimumWidth = 6;
            Notas.Name = "Notas";
            Notas.ReadOnly = true;
            Notas.Text = "Notas";
            Notas.UseColumnTextForLinkValue = true;
            // 
            // Faltas
            // 
            Faltas.HeaderText = "Faltas";
            Faltas.MinimumWidth = 6;
            Faltas.Name = "Faltas";
            Faltas.ReadOnly = true;
            Faltas.Text = "Faltas";
            Faltas.UseColumnTextForLinkValue = true;
            // 
            // edit
            // 
            edit.HeaderText = "edit";
            edit.MinimumWidth = 6;
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Text = "edit";
            edit.UseColumnTextForLinkValue = true;
            // 
            // X
            // 
            X.HeaderText = "Eliminar";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Text = "X";
            X.UseColumnTextForLinkValue = true;
            // 
            // BaseDeDatos
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            ClientSize = new Size(835, 555);
            Controls.Add(FiltroPersonas);
            Controls.Add(GRILLA);
            Controls.Add(Cerrar);
            Controls.Add(Label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(Button1);
            Name = "BaseDeDatos";
            WindowState = FormWindowState.Maximized;
            Load += BaseDeDatos_Load;
            ((System.ComponentModel.ISupportInitialize)GRILLA).EndInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Button1;
        private Button button2;
        private TextBox textBox1;
        private Label Label1;
        private Button Cerrar;

        private DataGridView GRILLA;
        private DataGridViewLinkColumn editar;
        private BindingSource personasBindingSource;
        private BindingSource personasBindingSource1;
        private BindingSource personasBindingSource2;
        private DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private CheckedListBox checkedListBox1;
        private CheckedListBox FiltroPersonas;
        private DataGridViewTextBoxColumn _dni;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private DataGridViewLinkColumn Notas;
        private DataGridViewLinkColumn Faltas;
        private DataGridViewLinkColumn edit;
        private DataGridViewLinkColumn X;
    }
}