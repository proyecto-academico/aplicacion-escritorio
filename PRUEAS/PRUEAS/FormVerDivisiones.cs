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

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FormGuardarDivisiones agregarDivisiones= new FormGuardarDivisiones(persona, false);
            //agregarDivisiones.ShowDialog(this);
        }

<<<<<<< HEAD
        private void FormVerDivisiones_Load(object sender, EventArgs e)
        {

        }

        private void buttonVolver2_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
            menuPrincipal.Show();
            this.Close();
=======
        private void GRILLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarDivisiones()
        {
            List<ClaseDivisiones> Divisiones = FuncionesQuerys.CargarDivisiones();
            GRILLA.DataSource = Divisiones;
        }

        private void FormVerDivisiones_Load(object sender, EventArgs e)
        {
            CargarDivisiones();
>>>>>>> 7d92c16edfd87db4cd448c12586d55176fab09df
        }
    }
}
