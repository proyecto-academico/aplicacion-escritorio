namespace PRUEAS
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPantallaUsuarios Alumno_BaseDeDatos = new FormPantallaUsuarios();
            Alumno_BaseDeDatos.Show();
            this.Close();
        }
    }
}
