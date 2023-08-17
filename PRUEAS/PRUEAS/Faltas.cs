using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRUEAS
{
    public partial class Faltas : Form
    {
        public bool verdad;
        ManejoDeDB _manejoDeDB;
        int persona;
        public Faltas(int persona_)
        {
            InitializeComponent();
            _manejoDeDB = new ManejoDeDB();
            this.persona = persona_;
        }

        private void Faltas_Load(object sender, EventArgs e)
        {
            CargarFaltas(persona);

        }



        public void CargarFaltas(int persona_)
        {
            List<ClaseFaltas> faltas = _manejoDeDB.TomaDeFaltas(persona_);
            if (_manejoDeDB.TomaDeNumFaltas(persona_, 0) >= 25)
            {
                noLibre.Visible = false;
                Libre.Visible = true;
            }

            GRILLA.DataSource = faltas;
            Justificadas.Text = _manejoDeDB.TomaDeNumFaltas(persona_, 1).ToString();

            Numero.Text = _manejoDeDB.TomaDeNumFaltas(persona_, 0).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            verdad = false;
            AgregarFaltas agregarFaltas = new AgregarFaltas(persona, false);
            DialogResult dialogResult = agregarFaltas.ShowDialog(this);
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Libre_Click(object sender, EventArgs e)
        {

        }

        private void GRILLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            verdad = true;
            ClaseFaltas faltas = new ClaseFaltas();
            if (e.ColumnIndex == GRILLA.Columns["justificadoDataGridViewCheckBoxColumn"].Index && e.RowIndex >= 0)
            {
                faltas.FaltasID = (int.Parse(GRILLA.Rows[e.RowIndex].Cells[0].Value.ToString()));
                _manejoDeDB.guardarFaltaEnDB(faltas, verdad);
                CargarFaltas(persona);

            }
        }
    }
}
