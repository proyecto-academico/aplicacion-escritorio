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
            FormGuardarClaseMateria claseMateria = new FormGuardarClaseMateria();
            claseMateria.ShowDialog(this);
        }

        private void GRILLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
