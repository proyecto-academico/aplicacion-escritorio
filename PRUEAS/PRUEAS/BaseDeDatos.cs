using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
        private void GRILLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)GRILLA.Rows[4].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "edit")
            {

                AgregarData AgregarData = new AgregarData();
                AgregarData.CargarPersona(new Personas
                {
                    ID = int.Parse(s: GRILLA.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    DNI = int.Parse(s: GRILLA.Rows[e.RowIndex].Cells[1].Value.ToString()),
                    Name = GRILLA.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Surname = GRILLA.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Ciclo = int.Parse(s: GRILLA.Rows[e.RowIndex].Cells[4].Value.ToString())
                });
                AgregarData.ShowDialog(this);

            }
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
