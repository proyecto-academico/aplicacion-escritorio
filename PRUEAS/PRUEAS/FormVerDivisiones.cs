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
            this.Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            FormGuardarDivisiones agregarDivisiones= new FormGuardarDivisiones();
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
            CargarDivisiones();

        }


        public void CargarDivisiones()
        {
            List<ClaseDivisiones> Divisiones = FuncionesQuerys.CargarDivisiones();
            GRILLA.DataSource = Divisiones;
        }
    }
}
