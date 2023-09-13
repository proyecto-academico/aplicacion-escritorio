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
    public partial class FormVerDivisiones : Form
    {
        public FormVerDivisiones()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FormGuardarDivisiones agregarDivisiones= new FormGuardarDivisiones(persona, false);
            //agregarDivisiones.ShowDialog(this);
        }
    }
}
