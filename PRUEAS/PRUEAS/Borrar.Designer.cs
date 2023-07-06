namespace PRUEAS
{
    partial class Borrar
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
            btnSI = new Button();
            btnNO = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSI
            // 
            btnSI.Location = new Point(174, 88);
            btnSI.Name = "btnSI";
            btnSI.Size = new Size(77, 23);
            btnSI.TabIndex = 0;
            btnSI.Text = "Si";
            btnSI.UseVisualStyleBackColor = true;
            btnSI.Click += btnSI_Click;
            // 
            // btnNO
            // 
            btnNO.Location = new Point(347, 88);
            btnNO.Name = "btnNO";
            btnNO.Size = new Size(79, 23);
            btnNO.TabIndex = 1;
            btnNO.Text = "No";
            btnNO.UseVisualStyleBackColor = true;
            btnNO.Click += btnNO_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 41);
            label1.Name = "label1";
            label1.Size = new Size(477, 32);
            label1.TabIndex = 2;
            label1.Text = "¿Estas seguro en elimirnar esta persona?";
            // 
            // Borrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 146);
            Controls.Add(label1);
            Controls.Add(btnNO);
            Controls.Add(btnSI);
            Name = "Borrar";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSI;
        private Button btnNO;
        private Label label1;
    }
}