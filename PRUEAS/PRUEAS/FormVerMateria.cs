namespace PRUEAS
{
    public partial class FormVerMateria : Form
    {
        public FormVerMateria()
        {
            InitializeComponent();
        }

        private void FormVerClaseMateria_Load(object sender, EventArgs e)
        { 
           //CargaDeContactos();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarData();
        }
        public void AgregarData()
        {
           FormGuardarClaseMateria claseMateria= new FormGuardarClaseMateria();
            claseMateria.ShowDialog(this);

        }
    }
}
