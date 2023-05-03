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
    public partial class AgregarData : Form
    {
        public ManejoDeDB _ManejoDeDB;
        public AgregarData()
        {
            InitializeComponent();
            _ManejoDeDB = new ManejoDeDB();
        }
        #region Botones
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
                Guardar();
            ((BaseDeDatos)this.Owner).CargaDeContactos();

        }
        #endregion

        #region Methods
        
        public void Guardar()
        {
            Personas personas = new Personas();
            personas.Name = textBoxName.Text;
            personas.Surname = textBoxSurname.Text;
            personas.DNI = (int)long.Parse(textBoxDNI.Text);
            personas.Ciclo = (int)long.Parse(textBoxCiCLO.Text);

            _ManejoDeDB.GuardarPersonas(personas);
        }
        #endregion


    }
}
