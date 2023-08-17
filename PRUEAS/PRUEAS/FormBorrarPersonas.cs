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
            ((FormPantallaUsuarios)this.Owner).CargaDeContactos();


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
