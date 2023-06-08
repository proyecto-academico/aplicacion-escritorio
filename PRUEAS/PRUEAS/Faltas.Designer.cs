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
            Cerrar = new Button();
            Label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            Button1 = new Button();
            DNI_alumno = new DataGridViewTextBoxColumn();
            dataAcceseBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)GRILLA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataAcceseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // GRILLA
            // 
            GRILLA.AutoGenerateColumns = false;
            GRILLA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GRILLA.DataSource = dataAcceseBindingSource;
            GRILLA.Location = new Point(88, 93);
            GRILLA.Name = "GRILLA";
            GRILLA.ReadOnly = true;
            GRILLA.RowHeadersWidth = 51;
            GRILLA.RowTemplate.Height = 25;
            GRILLA.Size = new Size(749, 379);
            GRILLA.TabIndex = 12;
            // 
            // Cerrar
            // 
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Cerrar.Location = new Point(782, 488);
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
            Label1.Location = new Point(88, 39);
            Label1.Name = "Label1";
            Label1.Size = new Size(58, 20);
            Label1.TabIndex = 10;
            Label1.Text = "Buscar";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 40);
            textBox1.MaxLength = 8;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(507, 23);
            textBox1.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(762, 39);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 8;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Button1
            // 
            Button1.Location = new Point(681, 39);
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
            // dataAcceseBindingSource
            // 
            dataAcceseBindingSource.DataSource = typeof(DataAccese);
            // 
            // Faltas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 558);
            Controls.Add(GRILLA);
            Controls.Add(Cerrar);
            Controls.Add(Label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(Button1);
            Name = "Faltas";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GRILLA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataAcceseBindingSource).EndInit();
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
    }
}