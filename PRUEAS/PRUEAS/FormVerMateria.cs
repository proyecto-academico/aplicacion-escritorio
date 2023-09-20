using System.Data;

namespace PRUEAS
{
    public partial class FormVerMateria : Form
    {
        public DataTable DataSource { get; internal set; }

        public FormVerMateria()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menuPrincipal231 = new FormMenuPrincipal();
            menuPrincipal231.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGuardarMateria Materia = new FormGuardarMateria();
            Materia.ShowDialog(this);
        }

        private void GRILLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
            menuPrincipal.Show();
            this.Close();
        }

        private void FormVerMateria_Load(object sender, EventArgs e)
        {

        }
    }
}
