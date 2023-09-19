namespace PRUEAS
{
    public partial class FormVerNotas : Form
    {
        Acceso_Querys _manejoDeDB;
        int persona;
        public bool BotonesValue = false;
        public FormVerNotas(int persona_)
        {
            InitializeComponent();
            _manejoDeDB = new Acceso_Querys();
            this.persona = persona_;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FNotas_Load(object sender, EventArgs e)
        {
            CargarNotas();
        }

        private void GRILLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            AgregarData();
        }
        private void AgregarData()
        {
            FormGuardarNotas notas = new FormGuardarNotas();
            notas.ShowDialog(this);
        }

        private void buscar_Click(object sender, EventArgs e)
        {

        }
        public void CargarNotas()
        {
            List<Clasenotas> clasenotas = _manejoDeDB.GetClasenotas(persona);
            GRILLA.DataSource = clasenotas;

        }
    }
}
