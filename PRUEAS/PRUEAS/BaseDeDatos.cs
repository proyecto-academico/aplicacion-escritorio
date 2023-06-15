using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRUEAS
{
    public partial class BaseDeDatos : Form
    {
        public string VaribleBuscador;
        public Borrar borrar = new Borrar();
        public bool BotonesValue = false;
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
            if (e.ColumnIndex == GRILLA.Columns["Faltas"].Index && e.RowIndex >= 0)
            {

                // Abrir el formulario "faltas.cs"
                Faltas formFaltas = new Faltas(int.Parse(GRILLA.Rows[e.RowIndex].Cells[0].Value.ToString()));
                formFaltas.ShowDialog();
            }

            /*HACER UNA EXCEPCION*/
            DataGridViewLinkCell cell = (DataGridViewLinkCell)GRILLA.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "edit")
            {
                BotonesValue = true;
            }
            else if (cell.Value.ToString() == "X")
            {

                borrar.CargarPersona(new Personas
                {

                    _dni = int.Parse(s: GRILLA.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    Name = GRILLA.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Surname = GRILLA.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    mail = GRILLA.Rows[e.RowIndex].Cells[3].Value.ToString()

                });
                borrar.ShowDialog(this);

            }

            if (BotonesValue)
            {

                AgregarData AgregarData = new AgregarData();
                AgregarData.CargarPersona(new Personas
                {

                    _dni = int.Parse(s: GRILLA.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    Name = GRILLA.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Surname = GRILLA.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    mail = GRILLA.Rows[e.RowIndex].Cells[3].Value.ToString()

                }, BotonesValue);

                BotonesValue = false;


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





        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            VaribleBuscador = textBox1.Text.ToString();
            if (VaribleBuscador == textBox1.Text)
            {

            }
        }
    }

}
