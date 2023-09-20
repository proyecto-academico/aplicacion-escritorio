using System.Data;

namespace PRUEAS
{
    public partial class FormVerMateria : Form
    {

        private Acceso_Querys Acceso_Querys = new();
        public FormVerMateria()
        {
            InitializeComponent();
        }

        private void FormVerClaseMateria_Load(object sender, EventArgs e)
        {
            CargaDeMateria();
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
            if (e.ColumnIndex == GRILLA.Columns["Clases"].Index && e.RowIndex >= 0)
            {
                
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                FormVerClaseMateria formVerClaseMateria = new FormVerClaseMateria(int.Parse(GRILLA.Rows[e.RowIndex].Cells[0].Value.ToString()));
#pragma warning restore CS8604 // Posible argumento de referencia nulo
                formVerClaseMateria.ShowDialog();
            }
        }
        public void CargaDeMateria()
        {
            List<ClaseMateria> claseMaterias = new();
            claseMaterias = Acceso_Querys.GetMaterias();
            GRILLA.DataSource = claseMaterias;
        }
    }
}
