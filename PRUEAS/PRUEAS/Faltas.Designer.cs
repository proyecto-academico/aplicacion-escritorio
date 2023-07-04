namespace PRUEAS
{
    partial class Faltas
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
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            justificadoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)GRILLA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseFaltasBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataAcceseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseFaltasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)claseFaltasBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // GRILLA
            // 
            GRILLA.AllowUserToAddRows = false;
            GRILLA.AutoGenerateColumns = false;
            GRILLA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GRILLA.Columns.AddRange(new DataGridViewColumn[] { fechaDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, justificadoDataGridViewCheckBoxColumn });
            GRILLA.DataSource = claseFaltasBindingSource2;
            GRILLA.Location = new Point(25, 81);
            GRILLA.Name = "GRILLA";
            GRILLA.ReadOnly = true;
            GRILLA.RowHeadersWidth = 51;
            GRILLA.RowTemplate.Height = 25;
            GRILLA.Size = new Size(356, 336);
            GRILLA.TabIndex = 12;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // justificadoDataGridViewCheckBoxColumn
            // 
            justificadoDataGridViewCheckBoxColumn.DataPropertyName = "Justificado";
            justificadoDataGridViewCheckBoxColumn.HeaderText = "Justificado";
            justificadoDataGridViewCheckBoxColumn.Name = "justificadoDataGridViewCheckBoxColumn";
            justificadoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // claseFaltasBindingSource2
            // 
            claseFaltasBindingSource2.DataSource = typeof(ClaseFaltas);
            // 
            // dataAcceseBindingSource
            // 
            dataAcceseBindingSource.DataSource = typeof(DataAccese);
            // 
            // Cerrar
            // 
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Cerrar.Location = new Point(672, 385);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(75, 32);
            Cerrar.TabIndex = 11;
            Cerrar.Text = "SALIR";
            Cerrar.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label1.Location = new Point(127, 43);
            Label1.Name = "Label1";
            Label1.Size = new Size(58, 20);
            Label1.TabIndex = 10;
            Label1.Text = "Buscar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(191, 44);
            textBox1.MaxLength = 8;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(292, 23);
            textBox1.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(581, 40);
            button2.Name = "button2";
            button2.Size = new Size(75, 27);
            button2.TabIndex = 8;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Button1
            // 
            Button1.Location = new Point(500, 40);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(387, 81);
            label2.Name = "label2";
            label2.Size = new Size(151, 29);
            label2.TabIndex = 13;
            label2.Text = "Faltas totales: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(387, 113);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 14;
            label3.Text = "Faltas justificadas: ";
            label3.TextAlign = ContentAlignment.MiddleCenter;

            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(128, 255, 128);
            label4.Location = new Point(463, 228);
            label4.Name = "label4";
            label4.Size = new Size(221, 45);
            label4.TabIndex = 15;
            label4.Text = "NO LIBRE";
            label4.Click += label4_Click;
            // 
            // Faltas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 430);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
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
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn justificadoDataGridViewCheckBoxColumn;
        private BindingSource claseFaltasBindingSource2;
    }
}