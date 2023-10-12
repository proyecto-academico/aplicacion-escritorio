namespace PRUEAS
{
    public partial class FormGuardarClaseMateria : Form
    {
        private Acceso_Querys Acceso_Querys;
        private int DNI;
        public FormGuardarClaseMateria(int variableDni)
        {
            InitializeComponent();
            Acceso_Querys = new Acceso_Querys();
            DNI = variableDni;
        }

        private void Nota_Click(object sender, EventArgs e)
        {

        }

        private void FormGuardarClaseMateria_Load(object sender, EventArgs e)
        {
            CargarDNI();
        }


        private void CargarDNI()
        {

            textBox1.Text = DNI.ToString();

        }



        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

