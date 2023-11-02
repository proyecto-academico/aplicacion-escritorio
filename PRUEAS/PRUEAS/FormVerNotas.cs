using SuizaSystem;
using System.Net;

namespace PRUEAS
{
    public partial class FormVerNotas : Form
    {
        Acceso_Querys _manejoDeDB;
        private int persona;
        private int Division;
        public bool BotonesValue = false;
        public FormVerNotas(int persona_, int division_id)
        {
            InitializeComponent();
            _manejoDeDB = new Acceso_Querys();
            this.persona = persona_;
            this.Division = division_id;
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
        {   // el argumento tipo es un argumento necesario para saber que eleccion necesito
            FormEleccion notas = new FormEleccion(1,persona, Division);
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
