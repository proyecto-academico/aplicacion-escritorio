
namespace PRUEAS
{
    public partial class FormGuardarNotas : Form
    {
        int DNI;
        int Evaluacion;
        public FormGuardarNotas(int dni, int evaluacion)
        {
            InitializeComponent();
            textBoxEvaluacion.Text= evaluacion.ToString();
            textBoxEvaluacion.Enabled = false;
            alumno.Enabled = false;
            alumno.Text = dni.ToString();
            Evaluacion = evaluacion;
            
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
