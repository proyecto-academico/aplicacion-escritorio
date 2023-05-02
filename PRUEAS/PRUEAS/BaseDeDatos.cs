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
        public BaseDeDatos()
        {
            InitializeComponent();
        }


        #region Methods
        private void button2_Click(object sender, EventArgs e)
        {
            AgregarData();

        }
        public void AgregarData()
        {
            AgregarData agregarData = new AgregarData();
            agregarData.ShowDialog();

        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }
        #endregion
    }

}
