namespace PRUEAS
{
    public partial class FormGuardarFaltas : Form
    {
        public bool TeclaIF = false;
#pragma warning disable CS0649 // El campo 'FormGuardarFaltas.ObjFaltas' nunca se asigna y siempre tendrá el valor predeterminado null
        private ClaseFaltas ObjFaltas;
#pragma warning restore CS0649 // El campo 'FormGuardarFaltas.ObjFaltas' nunca se asigna y siempre tendrá el valor predeterminado null
        public Acceso_Querys FuncionesQuerys;
        private int DNI;
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public FormGuardarFaltas(int persona, bool verdades)
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.

        {
            DNI = persona;
            InitializeComponent();
            FuncionesQuerys = new Acceso_Querys();
            TeclaIF = verdades;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ClaseFaltas faltas = ObjFaltas;

            Guardar();
#pragma warning disable CS8602 // Desreferencia de una referencia posiblemente NULL.
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
            ((FormVerFaltas)this.Owner).CargarFaltas(DNI);
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
#pragma warning restore CS8602 // Desreferencia de una referencia posiblemente NULL.

            this.Close();

        }

        public void Guardar()
        {
            ClaseFaltas faltas = new ClaseFaltas();
            faltas._dni = DNI;
            faltas.Fecha = dateTimePicker1.Value;
            faltas.Tipo = comboBox1.SelectedItem.ToString() == "1" ? 1 : 0.5f;
            faltas.Justificado = checkBox1.Checked;
            FuncionesQuerys.guardarFaltaEnDB(faltas, TeclaIF);
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
