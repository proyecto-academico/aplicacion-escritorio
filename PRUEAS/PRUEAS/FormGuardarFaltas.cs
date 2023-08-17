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
    public partial class FormGuardarFaltas : Form
    {
        public bool TeclaIF = false;
        private ClaseFaltas ObjFaltas;
        public Acceso_Querys FuncionesQuerys;
        private int DNI;
        public FormGuardarFaltas(int persona, bool verdades)

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
            ((FormVerFaltas)this.Owner).CargarFaltas(DNI);

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
