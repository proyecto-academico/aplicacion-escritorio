namespace SuizaSystem
{
    partial class FormEleccion
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
            dataGridView1 = new DataGridView();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            mailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clasePersonasBindingSource = new BindingSource(components);
            GRILLA2 = new DataGridView();
            evaluacionIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            claseDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            claseNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detallesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            notaPromedioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            claseEvaluacionesBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clasePersonasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GRILLA2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dniDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn, mailDataGridViewTextBoxColumn });
            dataGridView1.DataSource = clasePersonasBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(447, 451);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dniDataGridViewTextBoxColumn
            // 
            dniDataGridViewTextBoxColumn.DataPropertyName = "_dni";
            dniDataGridViewTextBoxColumn.HeaderText = "DNI";
            dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            surnameDataGridViewTextBoxColumn.HeaderText = "Apellido";
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            mailDataGridViewTextBoxColumn.DataPropertyName = "mail";
            mailDataGridViewTextBoxColumn.HeaderText = "Email";
            mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // clasePersonasBindingSource
            // 
            clasePersonasBindingSource.DataSource = typeof(PRUEAS.ClasePersonas);
            // 
            // GRILLA2
            // 
            GRILLA2.AllowUserToAddRows = false;
            GRILLA2.AllowUserToDeleteRows = false;
            GRILLA2.AutoGenerateColumns = false;
            GRILLA2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GRILLA2.Columns.AddRange(new DataGridViewColumn[] { evaluacionIDDataGridViewTextBoxColumn, claseDataGridViewTextBoxColumn, claseNameDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn, detallesDataGridViewTextBoxColumn, notaPromedioDataGridViewTextBoxColumn });
            GRILLA2.DataSource = claseEvaluacionesBindingSource;
            GRILLA2.Dock = DockStyle.Fill;
            GRILLA2.Location = new Point(0, 0);
            GRILLA2.Name = "GRILLA2";
            GRILLA2.ReadOnly = true;
            GRILLA2.RowTemplate.Height = 25;
            GRILLA2.Size = new Size(447, 451);
            GRILLA2.TabIndex = 1;
            GRILLA2.CellContentClick += GRILLA2_CellContentClick;
            // 
            // evaluacionIDDataGridViewTextBoxColumn
            // 
            evaluacionIDDataGridViewTextBoxColumn.DataPropertyName = "Evaluacion_ID";
            evaluacionIDDataGridViewTextBoxColumn.HeaderText = "Evaluacion_ID";
            evaluacionIDDataGridViewTextBoxColumn.Name = "evaluacionIDDataGridViewTextBoxColumn";
            // 
            // claseDataGridViewTextBoxColumn
            // 
            claseDataGridViewTextBoxColumn.DataPropertyName = "Clase";
            claseDataGridViewTextBoxColumn.HeaderText = "Clase";
            claseDataGridViewTextBoxColumn.Name = "claseDataGridViewTextBoxColumn";
            // 
            // claseNameDataGridViewTextBoxColumn
            // 
            claseNameDataGridViewTextBoxColumn.DataPropertyName = "Clase_Name";
            claseNameDataGridViewTextBoxColumn.HeaderText = "Clase_Name";
            claseNameDataGridViewTextBoxColumn.Name = "claseNameDataGridViewTextBoxColumn";
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
            // claseEvaluacionesBindingSource
            // 
            claseEvaluacionesBindingSource.DataSource = typeof(PRUEAS.ClaseEvaluaciones);
            // 
            // FormEleccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 451);
            Controls.Add(GRILLA2);
            Controls.Add(dataGridView1);
            Name = "FormEleccion";
            Text = "FormEleccion";
            Load += FormEleccion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clasePersonasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)GRILLA2).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseEvaluacionesBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource clasePersonasBindingSource;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private DataGridView GRILLA2;
        private DataGridViewTextBoxColumn evaluacionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn claseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn claseNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn detallesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notaPromedioDataGridViewTextBoxColumn;
        private BindingSource claseEvaluacionesBindingSource;
    }
}