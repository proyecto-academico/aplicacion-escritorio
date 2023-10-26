// omg que lindo form  😳😳😳😋😋🤤🤤🤤🤤🤤🤤🤤🤤 existe consenso respecto alr etraso argentino en desarrollar su industria textil hasta la decada del 30 .todavia en 1923, una encuesta oficial determino que el consumo de textiles estaba abastecido en un 73% por las importaciones. los textiles, junto con los productos de acero, constituian entre la mitad y un tercio de las importaciones
namespace PRUEAS
{
    public partial class FormGuardarNotas : Form
    {
        int DNI;
        int Evaluacion;
        public FormGuardarNotas(int dni, int evaluacion)
        {
            InitializeComponent();
            DNI = dni;
            Evaluacion = evaluacion;

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
