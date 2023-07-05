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
        public AgregarFaltas()
        {
            InitializeComponent();
            _ManejoDeDB = new ManejoDeDB();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ClaseFaltas faltas = _claseFaltas;

            Guardar();


            ((BaseDeDatos)this.Owner).CargaDeContactos();
        }

        public void Guardar()
        {
            ClaseFaltas faltas = new ClaseFaltas();

            faltas.Fecha = dateTimePicker1.Value;
            faltas.Tipo = (float)long.Parse(comboBox1.SelectedItem.ToString());
            faltas.Justificado = checkBox1.Checked ;
            _ManejoDeDB.GuardarPersonas(faltas, verdad);
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
