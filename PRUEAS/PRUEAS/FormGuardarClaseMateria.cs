namespace PRUEAS
{
    public partial class FormGuardarClaseMateria : Form
    {
        private Acceso_Querys Acceso_Querys;
        public FormGuardarClaseMateria()
        {
            InitializeComponent();
            Acceso_Querys = new Acceso_Querys();
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

            List<int> list = Acceso_Querys.GetDNI();
            comboBox1.DataSource = list;
            
        }
    }
}
