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
            personasBindingSource = new BindingSource(components);
            personasBindingSource1 = new BindingSource(components);
            personasBindingSource2 = new BindingSource(components);
            dNIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contraseniaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            edit = new DataGridViewLinkColumn();
            X = new DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)GRILLA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource2).BeginInit();
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
            GRILLA.Columns.AddRange(new DataGridViewColumn[] { dNIDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn, mailDataGridViewTextBoxColumn, contraseniaDataGridViewTextBoxColumn, edit, X });
            GRILLA.DataSource = personasBindingSource2;
            GRILLA.Location = new Point(45, 112);
            GRILLA.Name = "GRILLA";
            GRILLA.ReadOnly = true;
            GRILLA.RowTemplate.Height = 25;
            GRILLA.Size = new Size(749, 379);
            GRILLA.TabIndex = 6;
            GRILLA.CellContentClick += GRILLA_CellContentClick;
            // 
            // personasBindingSource
            // 
            personasBindingSource.DataSource = typeof(Personas);
            // 
            // personasBindingSource1
            // 
            personasBindingSource1.DataSource = typeof(Personas);
            // 
            // personasBindingSource2
            // 
            personasBindingSource2.DataSource = typeof(Personas);
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            dNIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            mailDataGridViewTextBoxColumn.HeaderText = "mail";
            mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contraseniaDataGridViewTextBoxColumn
            // 
            contraseniaDataGridViewTextBoxColumn.DataPropertyName = "contrasenia";
            contraseniaDataGridViewTextBoxColumn.HeaderText = "contrasenia";
            contraseniaDataGridViewTextBoxColumn.Name = "contraseniaDataGridViewTextBoxColumn";
            contraseniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edit
            // 
            edit.HeaderText = "edit";
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Text = "edit";
            edit.UseColumnTextForLinkValue = true;
            // 
            // X
            // 
            X.HeaderText = "Eliminar";
            X.Name = "X";
            X.ReadOnly = true;
            X.Text = "X";
            X.UseColumnTextForLinkValue = true;
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
            ((System.ComponentModel.ISupportInitialize)personasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource2).EndInit();
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
        private DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contraseniaDataGridViewTextBoxColumn;
        private DataGridViewLinkColumn edit;
        private DataGridViewLinkColumn X;
        private BindingSource personasBindingSource2;
    }
}