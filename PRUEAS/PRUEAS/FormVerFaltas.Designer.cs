namespace PRUEAS
{
    partial class FormVerFaltas
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
            claseFaltasBindingSource2 = new BindingSource(components);
            dataAcceseBindingSource = new BindingSource(components);
            Cerrar = new Button();
            Label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            Button1 = new Button();
            DNI_alumno = new DataGridViewTextBoxColumn();
            claseFaltasBindingSource = new BindingSource(components);
            claseFaltasBindingSource1 = new BindingSource(components);
            faltasTotales = new Label();
            label3 = new Label();
            noLibre = new Label();
            Libre = new Label();
            Numero = new Label();
            Justificadas = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            justificadoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)GRILLA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseFaltasBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataAcceseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseFaltasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseFaltasBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // GRILLA
            // 
            GRILLA.AllowUserToDeleteRows = false;
            GRILLA.AutoGenerateColumns = false;
            GRILLA.BorderStyle = BorderStyle.Fixed3D;
            GRILLA.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            GRILLA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GRILLA.Columns.AddRange(new DataGridViewColumn[] { Column1, fechaDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, justificadoDataGridViewCheckBoxColumn });
            GRILLA.DataSource = claseFaltasBindingSource2;
            GRILLA.Location = new Point(12, 97);
            GRILLA.Name = "GRILLA";
            GRILLA.ReadOnly = true;
            GRILLA.RowHeadersWidth = 51;
            GRILLA.RowTemplate.Height = 25;
            GRILLA.Size = new Size(290, 321);
            GRILLA.TabIndex = 12;
            GRILLA.CellContentClick += GRILLA_CellContentClick;
            // 
            // claseFaltasBindingSource2
            // 
            claseFaltasBindingSource2.DataSource = typeof(ClaseFaltas);
            // 
            // dataAcceseBindingSource
            // 
            dataAcceseBindingSource.DataSource = typeof(DB_Querys);
            // 
            // Cerrar
            // 
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Cerrar.Location = new Point(572, 385);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(75, 32);
            Cerrar.TabIndex = 11;
            Cerrar.Text = "SALIR";
            Cerrar.UseVisualStyleBackColor = true;
            Cerrar.Click += Cerrar_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label1.Location = new Point(78, 56);
            Label1.Name = "Label1";
            Label1.Size = new Size(58, 20);
            Label1.TabIndex = 10;
            Label1.Text = "Buscar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(142, 57);
            textBox1.MaxLength = 8;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 23);
            textBox1.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(532, 53);
            button2.Name = "button2";
            button2.Size = new Size(75, 27);
            button2.TabIndex = 8;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Button1
            // 
            Button1.Location = new Point(451, 53);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 28);
            Button1.TabIndex = 7;
            Button1.Text = "Buscar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // DNI_alumno
            // 
            DNI_alumno.HeaderText = "DNI_alumno";
            DNI_alumno.Name = "DNI_alumno";
            DNI_alumno.ReadOnly = true;
            // 
            // claseFaltasBindingSource
            // 
            claseFaltasBindingSource.DataSource = typeof(ClaseFaltas);
            // 
            // claseFaltasBindingSource1
            // 
            claseFaltasBindingSource1.DataSource = typeof(ClaseFaltas);
            // 
            // faltasTotales
            // 
            faltasTotales.AutoSize = true;
            faltasTotales.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            faltasTotales.Location = new Point(308, 97);
            faltasTotales.Name = "faltasTotales";
            faltasTotales.Size = new Size(151, 29);
            faltasTotales.TabIndex = 13;
            faltasTotales.Text = "Faltas totales: ";
            faltasTotales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(308, 126);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 14;
            label3.Text = "Faltas justificadas: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // noLibre
            // 
            noLibre.AutoSize = true;
            noLibre.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            noLibre.ForeColor = Color.FromArgb(128, 255, 128);
            noLibre.Location = new Point(371, 228);
            noLibre.Name = "noLibre";
            noLibre.Size = new Size(221, 45);
            noLibre.TabIndex = 15;
            noLibre.Text = "NO LIBRE";
            // 
            // Libre
            // 
            Libre.AutoSize = true;
            Libre.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            Libre.ForeColor = Color.Red;
            Libre.Location = new Point(408, 228);
            Libre.Name = "Libre";
            Libre.Size = new Size(146, 45);
            Libre.TabIndex = 16;
            Libre.Text = "LIBRE";
            Libre.UseMnemonic = false;
            Libre.Visible = false;
            Libre.Click += Libre_Click;
            // 
            // Numero
            // 
            Numero.AutoSize = true;
            Numero.Location = new Point(454, 109);
            Numero.Name = "Numero";
            Numero.Size = new Size(0, 15);
            Numero.TabIndex = 17;
            // 
            // Justificadas
            // 
            Justificadas.AutoSize = true;
            Justificadas.Location = new Point(465, 134);
            Justificadas.Name = "Justificadas";
            Justificadas.Size = new Size(0, 15);
            Justificadas.TabIndex = 18;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "FaltasID";
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.ReadOnly = true;
            fechaDataGridViewTextBoxColumn.Width = 63;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            tipoDataGridViewTextBoxColumn.Width = 55;
            // 
            // justificadoDataGridViewCheckBoxColumn
            // 
            justificadoDataGridViewCheckBoxColumn.DataPropertyName = "Justificado";
            justificadoDataGridViewCheckBoxColumn.HeaderText = "Justificado";
            justificadoDataGridViewCheckBoxColumn.Name = "justificadoDataGridViewCheckBoxColumn";
            justificadoDataGridViewCheckBoxColumn.ReadOnly = true;
            justificadoDataGridViewCheckBoxColumn.Width = 69;
            // 
            // Faltas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 430);
            Controls.Add(Justificadas);
            Controls.Add(Numero);
            Controls.Add(Libre);
            Controls.Add(noLibre);
            Controls.Add(label3);
            Controls.Add(faltasTotales);
            Controls.Add(GRILLA);
            Controls.Add(Cerrar);
            Controls.Add(Label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(Button1);
            Name = "Faltas";
            Text = "Form1";
            Load += Faltas_Load;
            ((System.ComponentModel.ISupportInitialize)GRILLA).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseFaltasBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataAcceseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseFaltasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)claseFaltasBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GRILLA;
        private BindingSource dataAcceseBindingSource;
        private Button Cerrar;
        private Label Label1;
        private TextBox textBox1;
        private Button button2;
        private Button Button1;
        private DataGridViewTextBoxColumn DNI_alumno;
        private BindingSource claseFaltasBindingSource;
        private BindingSource claseFaltasBindingSource1;
        private Label label2;
        private Label label3;
        private Label label4;
        private BindingSource claseFaltasBindingSource2;
        private Label Libre;
        private Label Numero;
        private Label Justificadas;
        private Label faltasTotales;
        private Label noLibre;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn justificadoDataGridViewCheckBoxColumn;
    }
}