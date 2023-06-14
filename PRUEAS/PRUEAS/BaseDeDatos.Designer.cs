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
            Button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            Label1 = new Label();
            Cerrar = new Button();
            GRILLA = new DataGridView();
            dNIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Notas = new DataGridViewLinkColumn();
            Faltas = new DataGridViewLinkColumn();
            edit = new DataGridViewLinkColumn();
            X = new DataGridViewLinkColumn();
            personasBindingSource2 = new BindingSource(components);
            personasBindingSource = new BindingSource(components);
            personasBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)GRILLA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.Location = new Point(638, 58);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 28);
            Button1.TabIndex = 1;
            Button1.Text = "Buscar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(719, 58);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 2;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 59);
            textBox1.MaxLength = 8;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(507, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label1.Location = new Point(45, 58);
            Label1.Name = "Label1";
            Label1.Size = new Size(58, 20);
            Label1.TabIndex = 4;
            Label1.Text = "Buscar";
            // 
            // Cerrar
            // 
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Cerrar.Location = new Point(739, 507);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(75, 32);
            Cerrar.TabIndex = 5;
            Cerrar.Text = "SALIR";
            Cerrar.UseVisualStyleBackColor = true;
            Cerrar.Click += Cerrar_Click;
            // 
            // GRILLA
            // 
            GRILLA.AllowUserToDeleteRows = false;
            GRILLA.AutoGenerateColumns = false;
            GRILLA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GRILLA.Columns.AddRange(new DataGridViewColumn[] { dNIDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn, mailDataGridViewTextBoxColumn, Notas, Faltas, edit, X });
            GRILLA.DataSource = personasBindingSource2;
            GRILLA.Location = new Point(45, 112);
            GRILLA.Name = "GRILLA";
            GRILLA.ReadOnly = true;
            GRILLA.RowHeadersWidth = 51;
            GRILLA.RowTemplate.Height = 25;
            GRILLA.Size = new Size(749, 379);
            GRILLA.TabIndex = 6;
            GRILLA.CellContentClick += GRILLA_CellContentClick;
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            dNIDataGridViewTextBoxColumn.MinimumWidth = 6;
            dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            dNIDataGridViewTextBoxColumn.ReadOnly = true;
            dNIDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            surnameDataGridViewTextBoxColumn.ReadOnly = true;
            surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            mailDataGridViewTextBoxColumn.HeaderText = "mail";
            mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            mailDataGridViewTextBoxColumn.ReadOnly = true;
            mailDataGridViewTextBoxColumn.Width = 125;
            // 
            // Notas
            // 
            Notas.HeaderText = "Notas";
            Notas.MinimumWidth = 6;
            Notas.Name = "Notas";
            Notas.ReadOnly = true;
            Notas.Text = "Notas";
            Notas.UseColumnTextForLinkValue = true;
            Notas.Width = 125;
            // 
            // Faltas
            // 
            Faltas.HeaderText = "Faltas";
            Faltas.MinimumWidth = 6;
            Faltas.Name = "Faltas";
            Faltas.ReadOnly = true;
            Faltas.Text = "Faltas";
            Faltas.UseColumnTextForLinkValue = true;
            Faltas.Width = 125;
            // 
            // edit
            // 
            edit.HeaderText = "edit";
            edit.MinimumWidth = 6;
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Text = "edit";
            edit.UseColumnTextForLinkValue = true;
            edit.Width = 125;
            // 
            // X
            // 
            X.HeaderText = "Eliminar";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Text = "X";
            X.UseColumnTextForLinkValue = true;
            X.Width = 125;
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
            // BaseDeDatos
            // 
            ClientSize = new Size(814, 547);
            Controls.Add(GRILLA);
            Controls.Add(Cerrar);
            Controls.Add(Label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(Button1);
            Name = "BaseDeDatos";
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
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private DataGridViewLinkColumn Notas;
        private DataGridViewLinkColumn Faltas;
        private DataGridViewLinkColumn edit;
        private DataGridViewLinkColumn X;
    }
}