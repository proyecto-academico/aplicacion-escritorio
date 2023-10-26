using PRUEAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuizaSystem
{
    public partial class FormEleccion : Form
    {
        int? DNI;
        int? Division;
        private Acceso_Querys Acceso_Querys { get; set; }
        public FormEleccion(int? dni = null, int? division = null)
        { 
            InitializeComponent();
            Acceso_Querys = new Acceso_Querys();
            DNI = dni;
            Division = division;
        }

        private void FormEleccion_Load(object sender, EventArgs e)
        {
            CargarPersonas();

            // Cambiar el color de fondo del DataGridView (GRILLA)
            dataGridView1.BackgroundColor = Color.White; // Cambia el color de fondo de la tabla

            DataGridViewCellStyle estiloCelda = new DataGridViewCellStyle();
            estiloCelda.BackColor = Color.LightBlue; // Cambia el color de fondo de las celdas
            estiloCelda.ForeColor = Color.Black; // Cambia el color del texto de las celdas

            dataGridView1.DefaultCellStyle = estiloCelda;

            // También puedes personalizar columnas individuales si lo deseas.
            // Por ejemplo, si quieres personalizar la primera columna:
            dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.Yellow;
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Black;

        }

        private void CargarPersonas()
        {
            List<ClasePersonas> clasePersonas = Acceso_Querys.ObetenerPersona(2);
            dataGridView1.DataSource = clasePersonas;
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Configurar el DockStyle para que el DataGridView ocupe todo el espacio
            dataGridView1.Dock = DockStyle.Fill;



            int variabletempo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
#pragma warning disable CS8604 // Posible argumento de referencia nulo
            FormGuardarClaseMateria form = new FormGuardarClaseMateria(variabletempo);
#pragma warning restore CS8604 // Posible argumento de referencia nulo
            FormVerMateria ver = new FormVerMateria();
            form.Show();
            ver.Close();
            this.Close();



        }

        private void GRILLA2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int variabletempo = int.Parse(GRILLA2.Rows[e.RowIndex].Cells[0].Value.ToString());
             
        }
    }
}
