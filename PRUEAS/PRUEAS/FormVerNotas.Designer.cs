namespace PRUEAS
{
    partial class FormVerNotas
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
            GRILLA = new DataGridView();
            Cerrar = new Button();
            Label1 = new Label();
            listbuscador = new TextBox();
            agregar = new Button();
            buscar = new Button();
            ((System.ComponentModel.ISupportInitialize)GRILLA).BeginInit();
            SuspendLayout();
            // 
            // GRILLA
            // 
            GRILLA.AllowUserToAddRows = false;
            GRILLA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GRILLA.Location = new Point(39, 78);
            GRILLA.Name = "GRILLA";
            GRILLA.ReadOnly = true;
            GRILLA.RowHeadersWidth = 51;
            GRILLA.RowTemplate.Height = 25;
            GRILLA.Size = new Size(740, 336);
            GRILLA.TabIndex = 24;
            GRILLA.CellContentClick += GRILLA_CellContentClick;
            // 
            // Cerrar
            // 
            Cerrar.FlatStyle = FlatStyle.Flat;
            Cerrar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Cerrar.Location = new Point(740, 420);
            Cerrar.Name = "Cerrar";
            Cerrar.Size = new Size(75, 32);
            Cerrar.TabIndex = 23;
            Cerrar.Text = "SALIR";
            Cerrar.UseVisualStyleBackColor = true;
            Cerrar.Click += Cerrar_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Historic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Label1.Location = new Point(39, 41);
            Label1.Name = "Label1";
            Label1.Size = new Size(58, 20);
            Label1.TabIndex = 22;
            Label1.Text = "Buscar";
            // 
            // listbuscador
            // 
            listbuscador.Location = new Point(103, 41);
            listbuscador.MaxLength = 8;
            listbuscador.Name = "listbuscador";
            listbuscador.Size = new Size(514, 23);
            listbuscador.TabIndex = 21;
            // 
            // agregar
            // 
            agregar.Location = new Point(704, 37);
            agregar.Name = "agregar";
            agregar.Size = new Size(75, 27);
            agregar.TabIndex = 20;
            agregar.Text = "Agregar";
            agregar.UseVisualStyleBackColor = true;
            // 
            // buscar
            // 
            buscar.Location = new Point(623, 37);
            buscar.Name = "buscar";
            buscar.Size = new Size(75, 28);
            buscar.TabIndex = 19;
            buscar.Text = "Buscar";
            buscar.UseVisualStyleBackColor = true;
            // 
            // FormVerNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 462);
            Controls.Add(GRILLA);
            Controls.Add(Cerrar);
            Controls.Add(Label1);
            Controls.Add(listbuscador);
            Controls.Add(agregar);
            Controls.Add(buscar);
            Name = "FormVerNotas";
            Text = "Form1";
            Load += FNotas_Load;
            ((System.ComponentModel.ISupportInitialize)GRILLA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GRILLA;
        private Button Cerrar;
        private Label Label1;
        private TextBox listbuscador;
        private Button agregar;
        private Button buscar;
    }
}