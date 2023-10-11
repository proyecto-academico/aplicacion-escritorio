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

            FormGuardarClaseMateria agrergarMateria = new FormGuardarClaseMateria();
            agrergarMateria.ShowDialog(this);

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


        

    }
}
