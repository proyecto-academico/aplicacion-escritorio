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
            this.Close();
        }

        private void GRILLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FormGuardarEvaluaciones agregarEvaluaciones = new FormGuardarEvaluaciones(persona, false);
            //agregarEvaluaciones.ShowDialog(this);
        }

        private void FormVerEvaluaciones_Load(object sender, EventArgs e)
        {
            CargarEvaluaciones();
        }

        public void CargarEvaluaciones()
        {
            List<ClaseEvaluaciones> Evaluaciones=FuncionesQuerys.ClaseEvaluaciones();
            GRILLA.DataSource = Evaluaciones;
        }
    }
}
