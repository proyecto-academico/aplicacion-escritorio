namespace PRUEAS
{
    public partial class FormVerClaseMateria : Form
    {
        public FormVerClaseMateria()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGuardarClaseMateria agrergarMateria = new FormGuardarClaseMateria();
            agrergarMateria.ShowDialog(this);
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

        private void GRILLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GRILLA.Columns["Evaluaciones"].Index && e.RowIndex >= 0)
            {
                FormVerEvaluaciones formVerEvaluaciones = new FormVerEvaluaciones(int.Parse(GRILLA.Rows[e.RowIndex].Cells[0].Value.ToString()));
                formVerEvaluaciones.ShowDialog();

            }
        }

        private void GRILLA_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
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
