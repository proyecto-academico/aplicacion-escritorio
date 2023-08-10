using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRUEAS
{
    public partial class AgregarFaltas : Form
    {
        public bool verdad = false;
        private ClaseFaltas _claseFaltas;
        public ManejoDeDB _ManejoDeDB;
        private int DNI;
        public AgregarFaltas(int persona, bool verdades)

        {
            DNI = persona;
            InitializeComponent();
            _ManejoDeDB = new ManejoDeDB();
            verdad = verdades;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ClaseFaltas faltas = _claseFaltas;
           
            Guardar();
            ((Faltas)this.Owner).CargarFaltas(DNI);

            this.Close();

        }

        public void Guardar()
        {
            ClaseFaltas faltas = new ClaseFaltas();
            faltas._dni = DNI;
            faltas.Fecha = dateTimePicker1.Value;
            faltas.Tipo = comboBox1.SelectedItem.ToString() == "1" ? 1 : 0.5f;
            faltas.Justificado = checkBox1.Checked;
            _ManejoDeDB.guardarFaltaEnDB(faltas, verdad);
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
