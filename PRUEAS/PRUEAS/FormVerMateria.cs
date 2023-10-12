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
            
            if (e.ColumnIndex == GRILLA.Columns["Clases"].Index && e.RowIndex >= 0)
            {
                int variabletempo = int.Parse(GRILLA.Rows[e.RowIndex].Cells[0].Value.ToString());
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                FormVerClaseMateria formVerClaseMateria = new FormVerClaseMateria(variabletempo);
#pragma warning restore CS8604 // Posible argumento de referencia nulo
                formVerClaseMateria.ShowDialog();
                this.Hide();
            }
        }
        public void CargaDeMateria()
        {
            List<ClaseMateria> claseMaterias = new();
            claseMaterias = Acceso_Querys.GetMaterias();
            GRILLA.DataSource = claseMaterias;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal menuPrincipal = new FormMenuPrincipal();
            menuPrincipal.Show();
            this.Close();
        }

        private void FormVerMateria_Load(object sender, EventArgs e)
        {
            CargaDeMateria();
        }
    }
}
