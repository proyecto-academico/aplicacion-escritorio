namespace PRUEAS
{
    partial class BaseDeDatos
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
            personasBindingSource1 = new BindingSource(components);
            Button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            Label1 = new Label();
            Cerrar = new Button();
            personasBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)GRILLA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // GRILLA
            // 
            GRILLA.AutoGenerateColumns = false;
            GRILLA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GRILLA.DataSource = personasBindingSource1;
            GRILLA.Location = new Point(65, 103);
            GRILLA.Name = "GRILLA";
            GRILLA.RowHeadersWidth = 51;
            GRILLA.RowTemplate.Height = 25;
            GRILLA.Size = new Size(648, 392);
            GRILLA.TabIndex = 0;
            // 
            // personasBindingSource1
            // 
            personasBindingSource1.DataSource = typeof(Personas);
            // 
            // Button1
            // 
            Button1.Location = new Point(638, 58);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 28);
            Button1.TabIndex = 1;
            Button1.Text = "Buscar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(719, 58);
            button2.Name = "button2";
            button2.Size = new Size(75, 28);
            button2.TabIndex = 2;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(125, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(507, 27);
            textBox1.TabIndex = 3;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label1.Location = new Point(45, 58);
            Label1.Name = "Label1";
            Label1.Size = new Size(74, 25);
            Label1.TabIndex = 4;
            Label1.Text = "Buscar";
            // 
            // Cerrar
            // 
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Cerrar.Location = new Point(739, 507);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(75, 32);
            Cerrar.TabIndex = 5;
            Cerrar.Text = "SALIR";
            Cerrar.UseVisualStyleBackColor = true;
            Cerrar.Click += Cerrar_Click;
            // 
            // personasBindingSource
            // 
            personasBindingSource.DataSource = typeof(Personas);
            // 
            // BaseDeDatos
            // 
            ClientSize = new Size(823, 547);
            Controls.Add(Cerrar);
            Controls.Add(Label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(Button1);
            Controls.Add(GRILLA);
            Name = "BaseDeDatos";
            Load += BaseDeDatos_Load;
            ((System.ComponentModel.ISupportInitialize)GRILLA).EndInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personasBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GRILLA;
        private Button Button1;
        private Button button2;
        private TextBox textBox1;
        private Label Label1;
        private Button Cerrar;
        private BindingSource personasBindingSource1;
        private BindingSource personasBindingSource;
    }
}