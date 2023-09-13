namespace PRUEAS
{
    partial class FormVerNotas
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
            GRILLA = new DataGridView();
            dniDataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            notaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            divisionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            clasenotasBindingSource5 = new BindingSource(components);
            clasenotasBindingSource3 = new BindingSource(components);
            clasenotasBindingSource4 = new BindingSource(components);
            clasenotasBindingSource = new BindingSource(components);
            Cerrar = new Button();
            Label1 = new Label();
            listbuscador = new TextBox();
            agregar = new Button();
            buscar = new Button();
            clasenotasBindingSource1 = new BindingSource(components);
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            Profesor = new DataGridViewTextBoxColumn();
            dateTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clasenotasBindingSource2 = new BindingSource(components);
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            evaluacionIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dateTimeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            divisionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dateTimeDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            evaluacionIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dateTimeDataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            evaluacionIDDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dateTimeDataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dniDataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)GRILLA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clasenotasBindingSource5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clasenotasBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clasenotasBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clasenotasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clasenotasBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clasenotasBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // GRILLA
            // 
            GRILLA.AllowUserToDeleteRows = false;
            GRILLA.AutoGenerateColumns = false;
            GRILLA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GRILLA.Columns.AddRange(new DataGridViewColumn[] { dniDataGridViewTextBoxColumn4, nameDataGridViewTextBoxColumn, notaDataGridViewTextBoxColumn, divisionDataGridViewTextBoxColumn1, Fecha });
            GRILLA.DataSource = clasenotasBindingSource5;
            GRILLA.Location = new Point(39, 76);
            GRILLA.Name = "GRILLA";
            GRILLA.ReadOnly = true;
            GRILLA.RowHeadersWidth = 51;
            GRILLA.RowTemplate.Height = 25;
            GRILLA.Size = new Size(555, 403);
            GRILLA.TabIndex = 24;
            GRILLA.CellContentClick += GRILLA_CellContentClick;
            // 
            // dniDataGridViewTextBoxColumn4
            // 
            dniDataGridViewTextBoxColumn4.DataPropertyName = "_dni";
            dniDataGridViewTextBoxColumn4.HeaderText = "DNI";
            dniDataGridViewTextBoxColumn4.Name = "dniDataGridViewTextBoxColumn4";
            dniDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Persona";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notaDataGridViewTextBoxColumn
            // 
            notaDataGridViewTextBoxColumn.DataPropertyName = "Nota";
            notaDataGridViewTextBoxColumn.HeaderText = "Nota";
            notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            notaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // divisionDataGridViewTextBoxColumn1
            // 
            divisionDataGridViewTextBoxColumn1.DataPropertyName = "division";
            divisionDataGridViewTextBoxColumn1.HeaderText = "Clase";
            divisionDataGridViewTextBoxColumn1.Name = "divisionDataGridViewTextBoxColumn1";
            divisionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "DateTime";
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // clasenotasBindingSource5
            // 
            clasenotasBindingSource5.DataSource = typeof(Clasenotas);
            // 
            // clasenotasBindingSource3
            // 
            clasenotasBindingSource3.DataSource = typeof(Clasenotas);
            // 
            // clasenotasBindingSource4
            // 
            clasenotasBindingSource4.DataSource = typeof(Clasenotas);
            // 
            // clasenotasBindingSource
            // 
            clasenotasBindingSource.DataSource = typeof(Clasenotas);
            // 
            // Cerrar
            // 
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Cerrar.Location = new Point(570, 485);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(75, 32);
            Cerrar.TabIndex = 23;
            Cerrar.Text = "SALIR";
            Cerrar.UseVisualStyleBackColor = true;
            Cerrar.Click += Cerrar_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label1.Location = new Point(39, 46);
            Label1.Name = "Label1";
            Label1.Size = new Size(58, 20);
            Label1.TabIndex = 22;
            Label1.Text = "Buscar";
            // 
            // listbuscador
            // 
            listbuscador.Location = new Point(103, 47);
            listbuscador.MaxLength = 8;
            listbuscador.Name = "listbuscador";
            listbuscador.Size = new Size(314, 23);
            listbuscador.TabIndex = 21;
            // 
            // agregar
            // 
            agregar.Location = new Point(504, 47);
            agregar.Name = "agregar";
            agregar.Size = new Size(90, 27);
            agregar.TabIndex = 20;
            agregar.Text = "Agregar";
            agregar.UseVisualStyleBackColor = true;
            agregar.Click += agregar_Click;
            // 
            // buscar
            // 
            buscar.Location = new Point(423, 46);
            buscar.Name = "buscar";
            buscar.Size = new Size(75, 28);
            buscar.TabIndex = 19;
            buscar.Text = "Buscar";
            buscar.UseVisualStyleBackColor = true;
            buscar.Click += buscar_Click;
            // 
            // clasenotasBindingSource1
            // 
            clasenotasBindingSource1.DataSource = typeof(Clasenotas);
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "DNI";
            dataGridViewTextBoxColumn2.Frozen = true;
            dataGridViewTextBoxColumn2.HeaderText = "DNI";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Division";
            dataGridViewTextBoxColumn3.Frozen = true;
            dataGridViewTextBoxColumn3.HeaderText = "Division";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Materia
            // 
            Materia.Frozen = true;
            Materia.HeaderText = "Materia";
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            // 
            // Profesor
            // 
            Profesor.Frozen = true;
            Profesor.HeaderText = "Profesor";
            Profesor.Name = "Profesor";
            Profesor.ReadOnly = true;
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            dateTimeDataGridViewTextBoxColumn.DataPropertyName = "Fecha Comienzo";
            dateTimeDataGridViewTextBoxColumn.Frozen = true;
            dateTimeDataGridViewTextBoxColumn.HeaderText = "Fecha Comienzo";
            dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // clasenotasBindingSource2
            // 
            clasenotasBindingSource2.DataSource = typeof(Clasenotas);
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "DNI";
            dataGridViewTextBoxColumn4.HeaderText = "DNI";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Division";
            dataGridViewTextBoxColumn5.HeaderText = "Division";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // evaluacionIDDataGridViewTextBoxColumn
            // 
            evaluacionIDDataGridViewTextBoxColumn.DataPropertyName = "Evaluacion_ID";
            evaluacionIDDataGridViewTextBoxColumn.HeaderText = "Evaluacion_ID";
            evaluacionIDDataGridViewTextBoxColumn.Name = "evaluacionIDDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Profesor";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dateTimeDataGridViewTextBoxColumn1
            // 
            dateTimeDataGridViewTextBoxColumn1.DataPropertyName = "Fecha Comienzo";
            dateTimeDataGridViewTextBoxColumn1.HeaderText = "Fecha Comienzo";
            dateTimeDataGridViewTextBoxColumn1.Name = "dateTimeDataGridViewTextBoxColumn1";
            // 
            // dniDataGridViewTextBoxColumn
            // 
            dniDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            dniDataGridViewTextBoxColumn.HeaderText = "DNI";
            dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // divisionDataGridViewTextBoxColumn
            // 
            divisionDataGridViewTextBoxColumn.DataPropertyName = "Division";
            divisionDataGridViewTextBoxColumn.HeaderText = "Division";
            divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Materia";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Profesor";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dateTimeDataGridViewTextBoxColumn2
            // 
            dateTimeDataGridViewTextBoxColumn2.DataPropertyName = "Fecha Final";
            dateTimeDataGridViewTextBoxColumn2.HeaderText = "Fecha Final";
            dateTimeDataGridViewTextBoxColumn2.Name = "dateTimeDataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Profesor";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dniDataGridViewTextBoxColumn1
            // 
            dniDataGridViewTextBoxColumn1.DataPropertyName = "DNI";
            dniDataGridViewTextBoxColumn1.HeaderText = "DNI";
            dniDataGridViewTextBoxColumn1.Name = "dniDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "Nota";
            dataGridViewTextBoxColumn9.HeaderText = "Nota";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // evaluacionIDDataGridViewTextBoxColumn1
            // 
            evaluacionIDDataGridViewTextBoxColumn1.DataPropertyName = "Evaluacion_ID";
            evaluacionIDDataGridViewTextBoxColumn1.HeaderText = "Evaluacion_ID";
            evaluacionIDDataGridViewTextBoxColumn1.Name = "evaluacionIDDataGridViewTextBoxColumn1";
            // 
            // dateTimeDataGridViewTextBoxColumn3
            // 
            dateTimeDataGridViewTextBoxColumn3.DataPropertyName = "DateTime";
            dateTimeDataGridViewTextBoxColumn3.HeaderText = "DateTime";
            dateTimeDataGridViewTextBoxColumn3.Name = "dateTimeDataGridViewTextBoxColumn3";
            // 
            // dniDataGridViewTextBoxColumn2
            // 
            dniDataGridViewTextBoxColumn2.DataPropertyName = "_dni";
            dniDataGridViewTextBoxColumn2.HeaderText = "_dni";
            dniDataGridViewTextBoxColumn2.Name = "dniDataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Profesor";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "Nota";
            dataGridViewTextBoxColumn11.HeaderText = "Nota";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // evaluacionIDDataGridViewTextBoxColumn2
            // 
            evaluacionIDDataGridViewTextBoxColumn2.DataPropertyName = "Evaluacion_ID";
            evaluacionIDDataGridViewTextBoxColumn2.HeaderText = "Evaluacion_ID";
            evaluacionIDDataGridViewTextBoxColumn2.Name = "evaluacionIDDataGridViewTextBoxColumn2";
            // 
            // dateTimeDataGridViewTextBoxColumn4
            // 
            dateTimeDataGridViewTextBoxColumn4.DataPropertyName = "DateTime";
            dateTimeDataGridViewTextBoxColumn4.HeaderText = "DateTime";
            dateTimeDataGridViewTextBoxColumn4.Name = "dateTimeDataGridViewTextBoxColumn4";
            // 
            // dniDataGridViewTextBoxColumn3
            // 
            dniDataGridViewTextBoxColumn3.DataPropertyName = "_dni";
            dniDataGridViewTextBoxColumn3.HeaderText = "_dni";
            dniDataGridViewTextBoxColumn3.Name = "dniDataGridViewTextBoxColumn3";
            // 
            // FormVerNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 527);
            Controls.Add(GRILLA);
            Controls.Add(Cerrar);
            Controls.Add(Label1);
            Controls.Add(listbuscador);
            Controls.Add(agregar);
            Controls.Add(buscar);
            Name = "FormVerNotas";
            Text = "Form1";
            Load += FNotas_Load;
            ((System.ComponentModel.ISupportInitialize)GRILLA).EndInit();
            ((System.ComponentModel.ISupportInitialize)clasenotasBindingSource5).EndInit();
            ((System.ComponentModel.ISupportInitialize)clasenotasBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)clasenotasBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)clasenotasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clasenotasBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)clasenotasBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GRILLA;
        private Button Cerrar;
        private Label Label1;
        private TextBox listbuscador;
        private Button agregar;
        private Button buscar;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;
        private BindingSource clasenotasBindingSource;
        private BindingSource clasenotasBindingSource2;
        private BindingSource clasenotasBindingSource1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewTextBoxColumn Profesor;
        private DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn evaluacionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn1;
        private BindingSource clasenotasBindingSource3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn2;
        private BindingSource clasenotasBindingSource4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn evaluacionIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn evaluacionIDDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn3;
        private BindingSource clasenotasBindingSource5;
        private DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Fecha;
    }
}