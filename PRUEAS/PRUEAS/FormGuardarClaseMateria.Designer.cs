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
            textBoxCiCLO = new TextBox();
            textBoxDNI = new TextBox();
            textBoxSurname = new TextBox();
            label5 = new Label();
            Fecha = new Label();
            Clase = new Label();
            buttonSalir = new Button();
            buttonGuardar = new Button();
            Nota = new Label();
            SuspendLayout();
            // 
            // textBoxCiCLO
            // 
            textBoxCiCLO.Location = new Point(333, 233);
            textBoxCiCLO.Margin = new Padding(3, 2, 3, 2);
            textBoxCiCLO.Name = "textBoxCiCLO";
            textBoxCiCLO.Size = new Size(263, 23);
            textBoxCiCLO.TabIndex = 23;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(333, 196);
            textBoxDNI.Margin = new Padding(3, 2, 3, 2);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(263, 23);
            textBoxDNI.TabIndex = 22;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(333, 159);
            textBoxSurname.Margin = new Padding(3, 2, 3, 2);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(263, 23);
            textBoxSurname.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 117);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 20;
            // 
            // Fecha
            // 
            Fecha.AutoSize = true;
            Fecha.Location = new Point(214, 236);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(66, 15);
            Fecha.TabIndex = 18;
            Fecha.Text = "Fecha Final";
            // 
            // Clase
            // 
            Clase.AutoSize = true;
            Clase.Location = new Point(214, 199);
            Clase.Name = "Clase";
            Clase.Size = new Size(95, 15);
            Clase.TabIndex = 17;
            Clase.Text = "Fecha Comienzo";
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(411, 300);
            buttonSalir.Margin = new Padding(3, 2, 3, 2);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(82, 22);
            buttonSalir.TabIndex = 14;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(315, 300);
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
            Nota.Location = new Point(214, 162);
            Nota.Name = "Nota";
            Nota.Size = new Size(110, 15);
            Nota.TabIndex = 16;
            Nota.Text = "Nombre de Materia";
            Nota.Click += Nota_Click;
            // 
            // FormGuardarClaseMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxCiCLO);
            Controls.Add(textBoxDNI);
            Controls.Add(textBoxSurname);
            Controls.Add(label5);
            Controls.Add(Fecha);
            Controls.Add(Clase);
            Controls.Add(Nota);
            Controls.Add(buttonSalir);
            Controls.Add(buttonGuardar);
            Name = "FormGuardarClaseMateria";
            Text = "FormGuardarClaseMateria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxCiCLO;
        private TextBox textBoxDNI;
        private TextBox textBoxSurname;
        private Label label5;
        private Label Fecha;
        private Label Clase;
        private Button buttonSalir;
        private Button buttonGuardar;
        private Label Nota;
    }
}