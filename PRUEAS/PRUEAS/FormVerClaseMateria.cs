using SuizaSystem;

namespace PRUEAS
{
    public partial class FormVerClaseMateria : Form
    {
        public int ObjMateria;
        public Acceso_Querys FuncionesQuerys = new Acceso_Querys();
        public FormVerClaseMateria(int IDMateria)
        {

            InitializeComponent();
            ObjMateria = IDMateria;
            CargaDeMaterias();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            FormEleccion agrergarMateria = new FormEleccion();
            agrergarMateria.Show();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal formmenuprincipal = new FormMenuPrincipal();
            formmenuprincipal.Show();
            this.Close();
        }

        private void FormClaseMateria_Load(object sender, EventArgs e)
        {
            // Cambiar el color de fondo del formulario
            this.BackColor = Color.LightGray; // Puedes ajustar el color según tus preferencias

            // Cambiar el color de fondo del DataGridView (GRILLA)
            GRILLA.BackgroundColor = Color.White; // Puedes ajustar el color del fondo del DataGridView

            // Establecer estilos personalizados para las celdas del DataGridView
            DataGridViewCellStyle estiloCelda = new DataGridViewCellStyle();
            estiloCelda.BackColor = Color.LightBlue; // Cambia el color de fondo de las celdas
            estiloCelda.ForeColor = Color.Black; // Cambia el color del texto de las celdas

            // Aplicar el estilo a todas las celdas del DataGridView (GRILLA)
            GRILLA.DefaultCellStyle = estiloCelda;

            // También puedes personalizar columnas individuales si lo deseas.
            // Por ejemplo, si quieres personalizar la primera columna:
            GRILLA.Columns[0].DefaultCellStyle.BackColor = Color.Yellow;
            GRILLA.Columns[0].DefaultCellStyle.ForeColor = Color.Black;

            CargaDeMaterias();

        }

    public void CargaDeMaterias()
        {

            List<Clase_ClaseMateria> Materia = FuncionesQuerys.CargarMaterias(ObjMateria);
            GRILLA.DataSource = Materia;
        }


        private void GRILLA_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GRILLA.Columns["Evaluaciones"].Index && e.RowIndex >= 0)
            {
                FormVerEvaluaciones formVerEvaluaciones = new FormVerEvaluaciones();
                formVerEvaluaciones.ShowDialog();

            }
        }

        private void GRILLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
