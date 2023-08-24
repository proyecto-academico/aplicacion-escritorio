namespace PRUEAS
{
    public partial class FormVerFaltas : Form
    {
        public bool TeclaDeIf;
        Acceso_Querys FuncionesQuerys;
        int persona;
        public FormVerFaltas(int persona_)
        {
            InitializeComponent();
            FuncionesQuerys = new Acceso_Querys();
            this.persona = persona_;
        }

        private void Faltas_Load(object sender, EventArgs e)
        {
            CargarFaltas(persona);

        }



        public void CargarFaltas(int persona_)
        {
            List<ClaseFaltas> faltas = FuncionesQuerys.ObetenerFaltas(persona_);
            if (FuncionesQuerys.ObtenerNumeroDeFaltas(persona_, 0) >= 25)
            {
                noLibre.Visible = false;
                Libre.Visible = true;
            }

            GRILLA.DataSource = faltas;
            Justificadas.Text = FuncionesQuerys.ObtenerNumeroDeFaltas(persona_, 1).ToString();

            Numero.Text = FuncionesQuerys.ObtenerNumeroDeFaltas(persona_, 0).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeclaDeIf = false;
            FormGuardarFaltas agregarFaltas = new FormGuardarFaltas(persona, false);
            DialogResult dialogResult = agregarFaltas.ShowDialog(this);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Libre_Click(object sender, EventArgs e)
        {

        }

        private void GRILLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TeclaDeIf = true;
            ClaseFaltas faltas = new ClaseFaltas();
            if (e.ColumnIndex == GRILLA.Columns["justificadoDataGridViewCheckBoxColumn"].Index && e.RowIndex >= 0)
            {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                faltas.FaltasID = (int.Parse(GRILLA.Rows[e.RowIndex].Cells[0].Value.ToString()));
#pragma warning restore CS8604 // Posible argumento de referencia nulo
                FuncionesQuerys.guardarFaltaEnDB(faltas, TeclaDeIf);
                CargarFaltas(persona);

            }
        }
    }
}
