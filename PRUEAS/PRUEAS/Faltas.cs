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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void CargarFaltas(int persona_)
        {
            List<ClaseFaltas> faltas = _manejoDeDB.TomaDeFaltas(persona_); 
            GRILLA.DataSource = faltas;
        }
    }
}
