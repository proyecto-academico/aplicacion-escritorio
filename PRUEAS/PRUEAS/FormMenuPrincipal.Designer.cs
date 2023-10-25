namespace PRUEAS
{
    partial class FormMenuPrincipal
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(254, 418);
            button1.Name = "button1";
            button1.Size = new Size(336, 23);
            button1.TabIndex = 0;
            button1.Text = "Alumno/Base de datos";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.Transparent;
            button2.Location = new Point(254, 447);
            button2.Name = "button2";
            button2.Size = new Size(336, 23);
            button2.TabIndex = 1;
            button2.Text = "Materias";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.BackColor = Color.Transparent;
            button3.Location = new Point(254, 476);
            button3.Name = "button3";
            button3.Size = new Size(336, 23);
            button3.TabIndex = 2;
            button3.Text = "Divisiones";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.Transparent;
            button4.Location = new Point(406, 632);
            button4.Name = "button4";
            button4.Size = new Size(201, 23);
            button4.TabIndex = 3;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.Font = new Font("Sitka Small", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(555, 320);
            label1.Name = "label1";
            label1.Size = new Size(738, 31);
            label1.TabIndex = 4;
            label1.Text = "Welcome to \"La suiza sistem\" from to administrator of the school";
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top;
            button6.BackColor = Color.Transparent;
            button6.Location = new Point(254, 505);
            button6.Name = "button6";
            button6.Size = new Size(336, 23);
            button6.TabIndex = 6;
            button6.Text = "Evaluaciones";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = SuizaSystem.Properties.Resources.suiza;
            ClientSize = new Size(1001, 586);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormMenuPrincipal";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormMenuPrincipal";
            WindowState = FormWindowState.Maximized;
            Load += FormMenuPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button button5;
        private Button button6;
    }
}