namespace PRUEAS
{
    public partial class FormVerPersonas : Form
    {
        int nivel = 3;
        public string Cadena_Buscar;
        public FormBorrarPersonas FormBorrar = new FormBorrarPersonas();
        public bool TeclaIF = false;
        private Acceso_Querys FuncionesQuerys;
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public FormVerPersonas()
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {
            InitializeComponent();
            FuncionesQuerys = new Acceso_Querys();
        }

        #region Botones
        private void BaseDeDatos_Load(object sender, EventArgs e)
        {
            CargaDeContactos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarData();

        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            FormInicioSesion login = new FormInicioSesion();
            login.Show();
            Close();
        }
        private void GRILLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GRILLA.Columns["Notas"].Index && e.RowIndex >= 0)
            {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                FormVerNotas formNotas = new FormVerNotas(int.Parse(GRILLA.Rows[e.RowIndex].Cells[0].Value.ToString()));
#pragma warning restore CS8604 // Posible argumento de referencia nulo
                formNotas.ShowDialog();
            }
            if (e.ColumnIndex == GRILLA.Columns["Faltas"].Index && e.RowIndex >= 0)
            {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                FormVerFaltas formFaltas = new FormVerFaltas(int.Parse(GRILLA.Rows[e.RowIndex].Cells[0].Value.ToString()));
#pragma warning restore CS8604 // Posible argumento de referencia nulo
                formFaltas.ShowDialog();
            }

            /*HACER UNA EXCEPCION*/
            if (e.ColumnIndex == GRILLA.Columns["edit"].Index || e.ColumnIndex == GRILLA.Columns["X"].Index)
            {
                DataGridViewLinkCell cell = (DataGridViewLinkCell)GRILLA.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (cell.Value.ToString() == "edit")
                {
                    TeclaIF = true;
                }
                else if (cell.Value.ToString() == "X")
                {

#pragma warning disable CS8604 // Posible argumento de referencia nulo
#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8601 // Posible asignación de referencia nula
                    FormBorrar.CargarPersona(new ClasePersonas
                    {

                        _dni = int.Parse(s: GRILLA.Rows[e.RowIndex].Cells[0].Value.ToString()),
                        Name = GRILLA.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        Surname = GRILLA.Rows[e.RowIndex].Cells[2].Value.ToString(),
                        mail = GRILLA.Rows[e.RowIndex].Cells[3].Value.ToString()

                    });
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8604 // Posible argumento de referencia nulo
                    FormBorrar.ShowDialog(this);

                }

                if (TeclaIF)
                {

                    FormGuardarPersonas AgregarData = new FormGuardarPersonas();
#pragma warning disable CS8604 // Posible argumento de referencia nulo
#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8601 // Posible asignación de referencia nula
                    AgregarData.CargarPersona(new ClasePersonas
                    {

                        _dni = int.Parse(s: GRILLA.Rows[e.RowIndex].Cells[0].Value.ToString()),
                        Name = GRILLA.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        Surname = GRILLA.Rows[e.RowIndex].Cells[2].Value.ToString(),
                        mail = GRILLA.Rows[e.RowIndex].Cells[3].Value.ToString()

                    }, TeclaIF);
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8604 // Posible argumento de referencia nulo

                    TeclaIF = false;


                    AgregarData.ShowDialog(this);

                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Cadena_Buscar = Buscador.Text;
            curso.Visible = false;
            division.Visible = false;
            int entero;
            bool esEntero = int.TryParse(Cadena_Buscar, out entero);
            if (esEntero)
            {
                int tranformacion = (int)Int64.Parse(Cadena_Buscar);

                GRILLA.DataSource = FuncionesQuerys.BusquedaDePersonas(nivel, tranformacion);
            }
            else
            {
                GRILLA.DataSource = FuncionesQuerys.BusquedaDePersonas(nivel, Cadena_Buscar);
            }

        }

        #endregion


        #region Methods

        public void AgregarData()
        {
            FormGuardarPersonas agregarData = new FormGuardarPersonas();
            agregarData.ShowDialog(this);

        }


        public void CargaDeContactos()
        {
            List<ClasePersonas> personas = FuncionesQuerys.ObetenerPersona(nivel);
            GRILLA.DataSource = personas;

        }

        #endregion

        private void AlumnoCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (AlumnoCheck.Checked)
            {
                nivel = 3;
                ProfesorCheck.Checked = false;
                AdminitracionCheck.Checked = false;
                Notas.Visible = true;
                Faltas.Visible = true;
                curso.Visible = true;
                division.Visible = true;
                edit.Visible = true;
                X.Visible = true;
                CargaDeContactos();
            }



        }

        private void ProfesorCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ProfesorCheck.Checked)
            {
                nivel = 2;
                AlumnoCheck.Checked = false;
                AdminitracionCheck.Checked = false;
                Notas.Visible = false;
                Faltas.Visible = false;
                curso.Visible = false;
                division.Visible = false;
                edit.Visible = true;
                X.Visible = true;
                CargaDeContactos();
            }
        }

        private void AdminitracionCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (AdminitracionCheck.Checked)
            {
                nivel = 1;
                ProfesorCheck.Checked = false;
                AlumnoCheck.Checked = false;
                Notas.Visible = false;
                Faltas.Visible = false;
                curso.Visible = false;
                division.Visible = false;
                edit.Visible = false;
                X.Visible = false;
                CargaDeContactos();
            }
        }


    }

}
