namespace PRUEAS
{
    partial class FormGuardarPersonas
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
            cajitaSelector = new ComboBox();
            SuspendLayout();
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(219, 246);
            buttonGuardar.Margin = new Padding(3, 2, 3, 2);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(82, 22);
            buttonGuardar.TabIndex = 0;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(315, 246);
            buttonSalir.Margin = new Padding(3, 2, 3, 2);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(82, 22);
            buttonSalir.TabIndex = 1;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 67);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 95);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 132);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 4;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 162);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 5;
            label4.Text = "Mail";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(185, 59);
            textBoxName.Margin = new Padding(3, 2, 3, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(263, 23);
            textBoxName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(312, 112);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 7;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(185, 92);
            textBoxSurname.Margin = new Padding(3, 2, 3, 2);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(263, 23);
            textBoxSurname.TabIndex = 8;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(185, 129);
            textBoxDNI.Margin = new Padding(3, 2, 3, 2);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(263, 23);
            textBoxDNI.TabIndex = 9;
            // 
            // textBoxCiCLO
            // 
            textBoxCiCLO.Location = new Point(185, 159);
            textBoxCiCLO.Margin = new Padding(3, 2, 3, 2);
            textBoxCiCLO.Name = "textBoxCiCLO";
            textBoxCiCLO.Size = new Size(263, 23);
            textBoxCiCLO.TabIndex = 10;
            // 
            // cajitaSelector
            // 
            cajitaSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            cajitaSelector.FormattingEnabled = true;
            cajitaSelector.ImeMode = ImeMode.Off;
            cajitaSelector.Items.AddRange(new object[] { "Alumno", "Profesor" });
            cajitaSelector.Location = new Point(250, 201);
            cajitaSelector.Name = "cajitaSelector";
            cajitaSelector.Size = new Size(121, 23);
            cajitaSelector.TabIndex = 12;
            // 
            // AgregarData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 286);
            Controls.Add(cajitaSelector);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "AgregarData";
            Text = "Form1";
            Load += AgregarData_Load;
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
        private ComboBox cajitaSelector;
    }
}