namespace PRUEAS
{
    partial class AgregarData
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
            buttonGuardar = new Button();
            buttonSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            label5 = new Label();
            textBoxSurname = new TextBox();
            textBoxDNI = new TextBox();
            textBoxCiCLO = new TextBox();
            SuspendLayout();
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(271, 382);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(94, 29);
            buttonGuardar.TabIndex = 0;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(381, 382);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(94, 29);
            buttonSalir.TabIndex = 1;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 163);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 215);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 262);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 4;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 305);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 5;
            label4.Text = "Mail";
  
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(230, 160);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(300, 27);
            textBoxName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(375, 215);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 7;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(230, 215);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(300, 27);
            textBoxSurname.TabIndex = 8;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(230, 259);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(300, 27);
            textBoxDNI.TabIndex = 9;
            // 
            // textBoxCiCLO
            // 
            textBoxCiCLO.Location = new Point(230, 305);
            textBoxCiCLO.Name = "textBoxCiCLO";
            textBoxCiCLO.Size = new Size(300, 27);
            textBoxCiCLO.TabIndex = 10;
            // 
            // AgregarData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 450);
            Controls.Add(textBoxCiCLO);
            Controls.Add(textBoxDNI);
            Controls.Add(textBoxSurname);
            Controls.Add(label5);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSalir);
            Controls.Add(buttonGuardar);
            Name = "AgregarData";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGuardar;
        private Button buttonSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxName;
        private Label label5;
        private TextBox textBoxSurname;
        private TextBox textBoxDNI;
        private TextBox textBoxCiCLO;
    }
}