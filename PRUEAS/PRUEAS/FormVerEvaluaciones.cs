namespace PRUEAS
{
    public partial class FormVerEvaluaciones : Form
    {
        public FormVerEvaluaciones()
        {
            InitializeComponent();
        }

        public FormVerEvaluaciones(int v)
        {
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
    }
}
