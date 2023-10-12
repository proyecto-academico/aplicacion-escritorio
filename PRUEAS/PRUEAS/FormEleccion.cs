using PRUEAS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuizaSystem
{
    public partial class FormEleccion : Form
    {
        private Acceso_Querys Acceso_Querys { get; set; }
        public FormEleccion()
        {
            InitializeComponent();
            Acceso_Querys = new Acceso_Querys();

        }

        private void FormEleccion_Load(object sender, EventArgs e)
        {
            CargarPersonas();

        }

        private void CargarPersonas()
        {
            List<ClasePersonas> clasePersonas = Acceso_Querys.ObetenerPersona(2);
            dataGridView1.DataSource = clasePersonas;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            int variabletempo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
#pragma warning disable CS8604 // Posible argumento de referencia nulo
            FormGuardarClaseMateria form = new FormGuardarClaseMateria(variabletempo);
#pragma warning restore CS8604 // Posible argumento de referencia nulo
            FormVerMateria ver = new FormVerMateria();
            form.Show();
            ver.Close();
            this.Close();



        }
    }
}
