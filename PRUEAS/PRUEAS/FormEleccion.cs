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
        int Tipo;
        int? DNI;
        int? Division;
        private Acceso_Querys Acceso_Querys { get; set; }
        public FormEleccion(int tipo, int? dni = null, int? division = null)
        {

            InitializeComponent();
            Acceso_Querys = new Acceso_Querys();
            DNI = dni;
            Division = division;
            this.Tipo = tipo;
          
        }

        private void FormEleccion_Load(object sender, EventArgs e)
        {

            switch (Tipo)
            {
                case 0:
                    GRILLA2.Hide();
                    dataGridView1.Show();
                    CargarPersonas();
                    break;
                case 1:
                    GRILLA2.Show();
                    dataGridView1.Hide();
                    CargzarEvalucionesPersonas();
                    break;

            }



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
        private void CargzarEvalucionesPersonas()
        {
            List<ClaseEvaluaciones> claseEvaluaciones = Acceso_Querys.ObtenerEvaluacionesAlumno(int.Parse(DNI.ToString()), int.Parse(Division.ToString()));
            GRILLA2.DataSource = claseEvaluaciones;
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
            int Evaluacion = int.Parse(GRILLA2.Rows[e.RowIndex].Cells[0].Value.ToString());
            FormGuardarNotas formGuardarNotas = new(int.Parse(DNI.ToString()), Evaluacion);
            formGuardarNotas.Show();
            this.Close();
        }
    }
}
