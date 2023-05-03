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
    public partial class BaseDeDatos : Form
    {
        private ManejoDeDB _ManejoDeDB;
        public BaseDeDatos()
        {
            InitializeComponent();
            _ManejoDeDB = new ManejoDeDB();
        }
        
        #region Botones
        private void BaseDeDatos_Load(object sender, EventArgs e)
        {
            CargaDeContactos();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            AgregarData();

        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }
        #endregion
     
        
        #region Methods

        public void AgregarData()
        {
            AgregarData agregarData = new AgregarData();
            agregarData.ShowDialog(this);

        }
        

        public void CargaDeContactos()
        {
            List<Personas> personas = _ManejoDeDB.TomaDePersonas();
            GRILLA.DataSource = personas;

        }


        #endregion




    }

}
