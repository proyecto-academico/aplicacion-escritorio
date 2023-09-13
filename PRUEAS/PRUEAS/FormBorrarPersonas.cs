namespace PRUEAS
{
    public partial class FormBorrarPersonas : Form
    {
        public ClasePersonas _personas = new ClasePersonas();
        public Acceso_Querys manejoDeDB = new Acceso_Querys();

        public FormBorrarPersonas()
        {
            InitializeComponent();

        }
        private void btnNO_Click(object sender, EventArgs e)
        {
            this.Close();
            _personas = new ClasePersonas();
        }
        private void btnSI_Click(object sender, EventArgs e)
        {
            manejoDeDB.DeletePersona(_personas);
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
            ((FormVerPersonas)this.Owner).CargaDeContactos();
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL


            this.Close();
            _personas = new ClasePersonas();
        }

        public void CargarPersona(ClasePersonas personas)
        {

            _personas = personas;


        }

        private void btnNO_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
