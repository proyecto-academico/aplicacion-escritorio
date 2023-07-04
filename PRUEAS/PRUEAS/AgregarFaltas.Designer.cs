namespace PRUEAS
{
    partial class AgregarFaltas
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
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonSalir = new Button();
            buttonGuardar = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            checkBox1 = new CheckBox();
            No = new CheckBox();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(304, 161);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 119);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 12;
            label3.Text = "Justificada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 82);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 11;
            label2.Text = "Tipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 54);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 10;
            label1.Text = "Fecha";
            // 
            // buttonSalir
            // 
            buttonSalir.Location = new Point(271, 164);
            buttonSalir.Margin = new Padding(3, 2, 3, 2);
            buttonSalir.Name = "buttonSalir";
            buttonSalir.Size = new Size(82, 22);
            buttonSalir.TabIndex = 16;
            buttonSalir.Text = "Salir";
            buttonSalir.UseVisualStyleBackColor = true;
            buttonSalir.Click += buttonSalir_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(175, 164);
            buttonGuardar.Margin = new Padding(3, 2, 3, 2);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(82, 22);
            buttonGuardar.TabIndex = 15;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(131, 46);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(265, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "0.5" });
            comboBox1.Location = new Point(131, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(265, 23);
            comboBox1.TabIndex = 18;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(131, 119);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(35, 19);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Si";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // No
            // 
            No.AutoSize = true;
            No.Location = new Point(174, 118);
            No.Name = "No";
            No.Size = new Size(42, 19);
            No.TabIndex = 20;
            No.Text = "No";
            No.UseVisualStyleBackColor = true;
            No.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // AgregarFaltas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 227);
            Controls.Add(No);
            Controls.Add(checkBox1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(buttonSalir);
            Controls.Add(buttonGuardar);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarFaltas";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonSalir;
        private Button buttonGuardar;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private CheckBox No;
    }
}