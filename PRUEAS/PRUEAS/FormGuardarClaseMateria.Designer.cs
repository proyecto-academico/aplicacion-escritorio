namespace PRUEAS
{
    partial class FormGuardarClaseMateria
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
            textBoxSurname = new TextBox();
            label5 = new Label();
            Clase = new Label();
            buttonSalir = new Button();
            buttonGuardar = new Button();
            Nota = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            Fecha = new Label();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(277, 166);
            textBoxSurname.Margin = new Padding(3, 2, 3, 2);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(263, 23);
            textBoxSurname.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 124);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 20;
            // 
            // Clase
            // 
            Clase.AutoSize = true;
            Clase.Location = new Point(158, 206);
            Clase.Name = "Clase";
            Clase.Size = new Size(95, 15);
            Clase.TabIndex = 17;
            Clase.Text = "Fecha Comienzo";
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(415, 333);
            buttonSalir.Margin = new Padding(3, 2, 3, 2);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(82, 22);
            buttonSalir.TabIndex = 14;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(319, 333);
            buttonGuardar.Margin = new Padding(3, 2, 3, 2);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(82, 22);
            buttonGuardar.TabIndex = 13;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // Nota
            // 
            Nota.AutoSize = true;
            Nota.Location = new Point(158, 169);
            Nota.Name = "Nota";
            Nota.Size = new Size(110, 15);
            Nota.TabIndex = 16;
            Nota.Text = "Nombre de Materia";
            Nota.Click += Nota_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(277, 279);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 23);
            textBox1.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(277, 200);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(263, 23);
            dateTimePicker1.TabIndex = 25;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Fecha
            // 
            Fecha.AutoSize = true;
            Fecha.Location = new Point(158, 243);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(66, 15);
            Fecha.TabIndex = 18;
            Fecha.Text = "Fecha Final";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(277, 237);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(263, 23);
            dateTimePicker2.TabIndex = 26;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // FormGuardarClaseMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(textBoxSurname);
            Controls.Add(label5);
            Controls.Add(Fecha);
            Controls.Add(Clase);
            Controls.Add(Nota);
            Controls.Add(buttonSalir);
            Controls.Add(buttonGuardar);
            Name = "FormGuardarClaseMateria";
            Text = "FormGuardarClaseMateria";
            Load += FormGuardarClaseMateria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxSurname;
        private Label label5;
        private Label Clase;
        private Button buttonSalir;
        private Button buttonGuardar;
        private Label Nota;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label Fecha;
        private DateTimePicker dateTimePicker2;
    }
}