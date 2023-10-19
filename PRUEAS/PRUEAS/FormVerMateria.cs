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
            // Cambiar el color de fondo del formulario
            this.BackColor = Color.LightGray; // Puedes ajustar el color según tus preferencias

            // Cambiar el color de fondo del DataGridView (GRILLA)
            GRILLA.BackgroundColor = Color.White; // Cambia el color de fondo de la tabla

            DataGridViewCellStyle estiloCelda = new DataGridViewCellStyle();
            estiloCelda.BackColor = Color.LightBlue; // Cambia el color de fondo de las celdas
            estiloCelda.ForeColor = Color.Black; // Cambia el color del texto de las celdas

            GRILLA.DefaultCellStyle = estiloCelda;

            // También puedes personalizar columnas individuales si lo deseas.
            // Por ejemplo, si quieres personalizar la primera columna:
            GRILLA.Columns[0].DefaultCellStyle.BackColor = Color.Yellow;
            GRILLA.Columns[0].DefaultCellStyle.ForeColor = Color.Black;

        }
    }
}
