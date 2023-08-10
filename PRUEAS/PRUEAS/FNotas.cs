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
    public partial class FNotas : Form
    {
        ManejoDeDB _manejoDeDB;
        int persona;
        public FNotas(int persona_)
        {
            InitializeComponent();
            _manejoDeDB = new ManejoDeDB();
            this.persona = persona_;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void FNotas_Load(object sender, EventArgs e)
        {

        }
    }
}
