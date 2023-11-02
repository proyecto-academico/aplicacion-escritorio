namespace PRUEAS
{
    partial class FormGuardarNotas
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
            alumno = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonSalir = new Button();
            buttonGuardar = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBoxEvaluacion = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(218, 134);
            textBoxSurname.Margin = new Padding(3, 2, 3, 2);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(263, 23);
            textBoxSurname.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(345, 142);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 16;
            // 
            // alumno
            // 
            alumno.Location = new Point(218, 107);
            alumno.Margin = new Padding(3, 2, 3, 2);
            alumno.Name = "alumno";
            alumno.Size = new Size(263, 23);
            alumno.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 170);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 14;
            label4.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 142);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 12;
            label2.Text = "Nota";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 115);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 11;
            label1.Text = "Alumno";
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(287, 246);
            buttonSalir.Margin = new Padding(3, 2, 3, 2);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(82, 22);
            buttonSalir.TabIndex = 21;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(191, 246);
            buttonGuardar.Margin = new Padding(3, 2, 3, 2);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(82, 22);
            buttonGuardar.TabIndex = 20;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(218, 162);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(263, 23);
            dateTimePicker1.TabIndex = 22;
            // 
            // textBoxEvaluacion
            // 
            textBoxEvaluacion.Location = new Point(218, 190);
            textBoxEvaluacion.Margin = new Padding(3, 2, 3, 2);
            textBoxEvaluacion.Name = "textBoxEvaluacion";
            textBoxEvaluacion.Size = new Size(263, 23);
            textBoxEvaluacion.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 198);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 23;
            label6.Text = "Evaluaciones";
            // 
            // FormGuardarNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 315);
            Controls.Add(textBoxEvaluacion);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonSalir);
            Controls.Add(buttonGuardar);
            Controls.Add(textBoxSurname);
            Controls.Add(label5);
            Controls.Add(alumno);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormGuardarNotas";
            Text = "FormGuardarNotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxSurname;
        private Label label5;
        private TextBox textBoxName;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button buttonSalir;
        private Button buttonGuardar;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private Label label6;
        private TextBox alumno;
        private TextBox textBoxEvaluacion;
    }
}