﻿namespace PRUEAS
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
            personasBindingSource1 = new BindingSource(components);
            Button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            Label1 = new Label();
            Cerrar = new Button();
            personasBindingSource = new BindingSource(components);
            personasBindingSource2 = new BindingSource(components);
            personasBindingSource3 = new BindingSource(components);
            dataAcceseBindingSource = new BindingSource(components);
            personasBindingSource4 = new BindingSource(components);
            GRILLA = new DataGridView();
            personasBindingSource5 = new BindingSource(components);
            personasBindingSource6 = new BindingSource(components);
            edit = new DataGridViewLinkColumn();
            X = new DataGridViewLinkColumn();
            personasBindingSource7 = new BindingSource(components);
            manejoDeDBBindingSource = new BindingSource(components);
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cicloDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dNIDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataAcceseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GRILLA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)manejoDeDBBindingSource).BeginInit();
            SuspendLayout();
            // 
            // personasBindingSource1
            // 
            personasBindingSource1.DataSource = typeof(Personas);
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
            // personasBindingSource
            // 
            personasBindingSource.DataSource = typeof(Personas);
            // 
            // personasBindingSource2
            // 
            personasBindingSource2.DataSource = typeof(Personas);
            // 
            // personasBindingSource3
            // 
            personasBindingSource3.DataSource = typeof(Personas);
            // 
            // dataAcceseBindingSource
            // 
            dataAcceseBindingSource.DataSource = typeof(DataAccese);
            // 
            // personasBindingSource4
            // 
            personasBindingSource4.DataSource = typeof(Personas);
            // 
            // GRILLA
            // 
            GRILLA.AllowUserToDeleteRows = false;
            GRILLA.AutoGenerateColumns = false;
            GRILLA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GRILLA.Columns.AddRange(new DataGridViewColumn[] { edit, X, iDDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, cicloDataGridViewTextBoxColumn, dNIDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn });
            GRILLA.DataSource = personasBindingSource1;
            GRILLA.Location = new Point(45, 110);
            GRILLA.Name = "GRILLA";
            GRILLA.ReadOnly = true;
            GRILLA.RowTemplate.Height = 25;
            GRILLA.Size = new Size(749, 381);
            GRILLA.TabIndex = 6;
            GRILLA.CellContentClick += GRILLA_CellContentClick;
            // 
            // personasBindingSource5
            // 
            personasBindingSource5.DataSource = typeof(Personas);
            // 
            // personasBindingSource6
            // 
            personasBindingSource6.DataSource = typeof(Personas);
            // 
            // edit
            // 
            edit.Frozen = true;
            edit.HeaderText = "edit";
            edit.Name = "edit";
            edit.ReadOnly = true;
            edit.Text = "edit";
            edit.UseColumnTextForLinkValue = true;
            // 
            // X
            // 
            X.Frozen = true;
            X.HeaderText = "Eliminar";
            X.Name = "X";
            X.ReadOnly = true;
            X.Text = "X";
            X.UseColumnTextForLinkValue = true;
            // 
            // personasBindingSource7
            // 
            personasBindingSource7.DataSource = typeof(Personas);
            // 
            // manejoDeDBBindingSource
            // 
            manejoDeDBBindingSource.DataSource = typeof(ManejoDeDB);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cicloDataGridViewTextBoxColumn
            // 
            cicloDataGridViewTextBoxColumn.DataPropertyName = "Ciclo";
            cicloDataGridViewTextBoxColumn.HeaderText = "Ciclo";
            cicloDataGridViewTextBoxColumn.Name = "cicloDataGridViewTextBoxColumn";
            cicloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            dNIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            surnameDataGridViewTextBoxColumn.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)personasBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataAcceseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)GRILLA).EndInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource5).EndInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource6).EndInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource7).EndInit();
            ((System.ComponentModel.ISupportInitialize)manejoDeDBBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Button1;
        private Button button2;
        private TextBox textBox1;
        private Label Label1;
        private Button Cerrar;
        private BindingSource personasBindingSource1;
        private BindingSource personasBindingSource;
        private BindingSource dataAcceseBindingSource;
        private BindingSource personasBindingSource2;
        private BindingSource personasBindingSource3;
        private BindingSource personasBindingSource4;
        private DataGridView GRILLA;
        private BindingSource personasBindingSource5;
        private DataGridViewLinkColumn editar;
        private DataGridViewLinkColumn edit;
        private DataGridViewLinkColumn X;
        private BindingSource personasBindingSource6;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cicloDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private BindingSource personasBindingSource7;
        private BindingSource manejoDeDBBindingSource;
    }
}