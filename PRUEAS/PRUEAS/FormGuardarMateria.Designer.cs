namespace PRUEAS
{
    partial class FormGuardarMateria
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            textBoxCiCLO = new TextBox();
            textBoxDNI = new TextBox();
            textBoxSurname = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            buttonSalir = new Button();
            buttonGuardar = new Button();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // textBoxCiCLO
            // 
            textBoxCiCLO.Location = new Point(244, 117);
            textBoxCiCLO.Margin = new Padding(3, 2, 3, 2);
            textBoxCiCLO.Name = "textBoxCiCLO";
            textBoxCiCLO.Size = new Size(263, 23);
            textBoxCiCLO.TabIndex = 19;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(244, 87);
            textBoxDNI.Margin = new Padding(3, 2, 3, 2);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(263, 23);
            textBoxDNI.TabIndex = 18;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(244, 50);
            textBoxSurname.Margin = new Padding(3, 2, 3, 2);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(263, 23);
            textBoxSurname.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(371, 70);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 120);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 14;
            label4.Text = "Horas Semanales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 90);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 13;
            label3.Text = "Anio Escolar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 53);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 12;
            label2.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 153);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 23);
            textBox1.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(125, 156);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 20;
            label6.Text = "Clases";
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(323, 209);
            buttonSalir.Margin = new Padding(3, 2, 3, 2);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(82, 22);
            buttonSalir.TabIndex = 23;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(227, 209);
            buttonGuardar.Margin = new Padding(3, 2, 3, 2);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(82, 22);
            buttonGuardar.TabIndex = 22;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // FormGuardarMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 278);
            Controls.Add(buttonSalir);
            Controls.Add(buttonGuardar);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(textBoxCiCLO);
            Controls.Add(textBoxDNI);
            Controls.Add(textBoxSurname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "FormGuardarMateria";
            Text = "FormGuardarMateria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox textBoxCiCLO;
        private TextBox textBoxDNI;
        private TextBox textBoxSurname;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Label label6;
        private Button buttonSalir;
        private Button buttonGuardar;
    }
}