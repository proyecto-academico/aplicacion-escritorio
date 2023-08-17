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
    public partial class FormVerNotas : Form
    {
        Acceso_Querys _manejoDeDB;
        int persona;
        public bool BotonesValue = false;
        public FormVerNotas(int persona_)
        {
            InitializeComponent();
            _manejoDeDB = new Acceso_Querys();
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

        private void GRILLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* if (e.ColumnIndex == GRILLA.Columns["edit"].Index || e.ColumnIndex == GRILLA.Columns["X"].Index)
            {
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
            }*/
        }
    }
}
