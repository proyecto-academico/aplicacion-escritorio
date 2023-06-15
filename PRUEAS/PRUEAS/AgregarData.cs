using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRUEAS
{
    public partial class AgregarData : Form
    {
        public bool verdad = false;
        public ManejoDeDB _ManejoDeDB;
        private Personas _personas;
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
            Personas personas = _personas;

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
            personas._dni = (int)long.Parse(textBoxDNI.Text);
            personas.mail = (textBoxCiCLO.Text);





            _ManejoDeDB.GuardarPersonas(personas, verdad);
        }

        public void CargarPersona(Personas personas, bool Verdades)
        {

            _personas = personas;
            if (personas != null)
            {
                VaciarForm();
                textBoxName.Text = personas.Name;
                textBoxDNI.Text = personas._dni.ToString();
                textBoxSurname.Text = personas.Surname;
                textBoxCiCLO.Text = personas.mail;
                verdad = Verdades;
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
