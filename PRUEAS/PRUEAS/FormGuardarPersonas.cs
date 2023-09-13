namespace PRUEAS
{
    public partial class FormGuardarPersonas : Form
    {
        public bool TeclaIf = false;
        public Acceso_Querys FuncionesQuerys;
        private ClasePersonas ObjPersona;
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public FormGuardarPersonas()
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {
            InitializeComponent();
            FuncionesQuerys = new Acceso_Querys();
        }
        #region Botones
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ClasePersonas personas = ObjPersona;

            Guardar();


#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            ((FormVerPersonas)this.Owner).CargaDeContactos();
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

        }
        #endregion

        #region Methods

        public void Guardar()
        {
            ClasePersonas personas = new ClasePersonas();

            personas.Name = textBoxName.Text;
            personas.Surname = textBoxSurname.Text;
            personas._dni = (int)long.Parse(textBoxDNI.Text);
            personas.mail = (textBoxCiCLO.Text);
            personas.Tipo = cajitaSelector.Text == "Alumno" ? 3 : 2;




            FuncionesQuerys.guardarPersonaEnDB(personas, TeclaIf);
        }

        public void CargarPersona(ClasePersonas personas, bool Verdades)
        {

            ObjPersona = personas;
            if (personas != null)
            {
                VaciarForm();
                textBoxName.Text = personas.Name;
                textBoxDNI.Text = personas._dni.ToString();
                textBoxSurname.Text = personas.Surname;
                textBoxCiCLO.Text = personas.mail;
                TeclaIf = Verdades;
            }

        }

        public void VaciarForm()
        {
            textBoxName.Text = string.Empty;
            textBoxDNI.Text = string.Empty;
            textBoxSurname.Text = string.Empty;
            textBoxCiCLO.Text = string.Empty;
        }
        #endregion



        private void AgregarData_Load(object sender, EventArgs e)
        {

        }
    }
}
