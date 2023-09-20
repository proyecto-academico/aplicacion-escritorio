namespace PRUEAS
{
    public partial class FormVerClaseMateria : Form
    {
        public Acceso_Querys FuncionesQuerys = new Acceso_Querys();
        public FormVerClaseMateria()
        {
            InitializeComponent();
            CargaDeMaterias();
        }

        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            FormGuardarClaseMateria agrergarMateria = new FormGuardarClaseMateria();
            agrergarMateria.ShowDialog(this);
=======

>>>>>>> 7d92c16edfd87db4cd448c12586d55176fab09df
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormClaseMateria_Load(object sender, EventArgs e)
        {

        }

        public void CargaDeMaterias()
        {
            List<Clase_ClaseMateria> Materia = FuncionesQuerys.CargarMaterias();
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
<<<<<<< HEAD

        private void GRILLA_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
=======
>>>>>>> 7d92c16edfd87db4cd448c12586d55176fab09df
        /*private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
   if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() == "Email me")
   {
       MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
   }
   else
   {
       MessageBox.Show("You Clicked another Cell");
   }
}*/
    }
}
