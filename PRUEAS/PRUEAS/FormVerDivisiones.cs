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
    public partial class FormVerDivisiones : Form
    {
        Acceso_Querys FuncionesQuerys;
        public FormVerDivisiones()
        {
            InitializeComponent();
            FuncionesQuerys = new Acceso_Querys();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FormGuardarDivisiones agregarDivisiones= new FormGuardarDivisiones(persona, false);
            //agregarDivisiones.ShowDialog(this);
        }

        private void GRILLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarDivisiones()
        {
            List<ClaseDivisiones> Divisiones = FuncionesQuerys.CargarDivisiones();
            GRILLA.DataSource = Divisiones;
        }

        private void FormVerDivisiones_Load(object sender, EventArgs e)
        {
            CargarDivisiones();
        }
    }
}
