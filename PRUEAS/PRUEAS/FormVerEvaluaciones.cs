using System.Security.AccessControl;

namespace PRUEAS
{
    public partial class FormVerEvaluaciones : Form
    {
        Acceso_Querys FuncionesQuerys;
        public FormVerEvaluaciones()
        {
            InitializeComponent();
            FuncionesQuerys = new Acceso_Querys();
        }



        private void Cerrar_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal formmenuprincipal = new FormMenuPrincipal();
            formmenuprincipal.Show();
            this.Close();
        }

        private void GRILLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGuardarEvaluaciones agregarEvaluaciones = new FormGuardarEvaluaciones();
            agregarEvaluaciones.ShowDialog(this);
        }

        private void FormVerEvaluaciones_Load(object sender, EventArgs e)
        {
            // Cambiar el color de fondo del formulario
            this.BackColor = Color.LightGray; // Puedes ajustar el color según tus preferencias

            // Cambiar el color de fondo del DataGridView (GRILLA)
            GRILLA.BackgroundColor = Color.White; // Cambia el color de fondo de la tabla

            DataGridViewCellStyle estiloCelda = new DataGridViewCellStyle();
            estiloCelda.BackColor = Color.LightBlue; // Cambia el color de fondo de las celdas
            estiloCelda.ForeColor = Color.Black; // Cambia el color del texto de las celdas

            GRILLA.DefaultCellStyle = estiloCelda;

            // También puedes personalizar columnas individuales si lo deseas.
            // Por ejemplo, si quieres personalizar la primera columna:
            GRILLA.Columns[0].DefaultCellStyle.BackColor = Color.Yellow;
            GRILLA.Columns[0].DefaultCellStyle.ForeColor = Color.Black;

            CargarEvaluaciones();
        }

        public void CargarEvaluaciones()
        {
            List<ClaseEvaluaciones> Evaluaciones = FuncionesQuerys.ClaseEvaluaciones();
            GRILLA.DataSource = Evaluaciones;
        }
    }
}
