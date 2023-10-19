using SuizaSystem;

namespace PRUEAS
{
    public partial class FormVerDivisiones : Form
    {
        Acceso_Querys FuncionesQuerys;
        public FormVerDivisiones()
        {
            InitializeComponent();
            FuncionesQuerys = new Acceso_Querys();
        }

        public void Cerrar_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal formmenuprincipal = new FormMenuPrincipal();
            formmenuprincipal.Show();
            this.Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            FormGuardarDivisiones agregarDivisiones = new FormGuardarDivisiones();
            agregarDivisiones.ShowDialog(this);

        }




        public void buttonVolver2_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
            menuPrincipal.Show();
            this.Close();
        }
        public void FormVerDivisiones_Load(object sender, EventArgs e)
        {
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

            CargarDivisiones();
        }


        public void CargarDivisiones()
        {
            List<ClaseDivisiones> Divisiones = FuncionesQuerys.CargarDivisiones();
            GRILLA.DataSource = Divisiones;
        }

        private void GRILLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
