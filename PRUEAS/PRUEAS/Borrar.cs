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
    public partial class Borrar : Form
    {
        public Personas _personas = new Personas();
        public ManejoDeDB manejoDeDB = new ManejoDeDB();

        public Borrar()
        {
            InitializeComponent();

        }
        private void btnNO_Click(object sender, EventArgs e)
        {
            this.Close();
            _personas = new Personas();
        }
        private void btnSI_Click(object sender, EventArgs e)
        {
            manejoDeDB.DeletePersona(_personas);
            ((BaseDeDatos)this.Owner).CargaDeContactos();
           

            this.Close();
            _personas = new Personas();
        }

        public void CargarPersona(Personas personas)
        {

            _personas = personas;


        }
    }
}
