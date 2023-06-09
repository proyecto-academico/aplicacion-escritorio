﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        int nivel = 3;
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







                Faltas formFaltas = new Faltas(int.Parse(GRILLA.Rows[e.RowIndex].Cells[0].Value.ToString()));
                formFaltas.ShowDialog();
            }

            /*HACER UNA EXCEPCION*/
            if (e.ColumnIndex==GRILLA.Columns["edit"].Index || e.ColumnIndex == GRILLA.Columns["X"].Index) { 
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
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            VaribleBuscador = Buscador.Text;
            curso.Visible = false;
            division.Visible = false;
            int entero;
            bool esEntero = int.TryParse(VaribleBuscador, out entero);
            if (esEntero)
            {
                int tranformacion = (int)Int64.Parse(VaribleBuscador);

                GRILLA.DataSource = _ManejoDeDB.BusquedaDePersonas(nivel, tranformacion);
            }
            else
            {
                GRILLA.DataSource = _ManejoDeDB.BusquedaDePersonas(nivel, VaribleBuscador);
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
            List<Personas> personas = _ManejoDeDB.TomaDePersonas(nivel);
            GRILLA.DataSource = personas;

        }



        #endregion







        private void AlumnoCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (AlumnoCheck.Checked)
            {
                nivel = 3;
                ProfesorCheck.Checked = false;
                AdminitracionCheck.Checked = false;
                Notas.Visible = true;
                Faltas.Visible = true;
                curso.Visible = true;
                division.Visible = true;
                edit.Visible = true;
                X.Visible = true;
                CargaDeContactos();
            }



        }

        private void ProfesorCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ProfesorCheck.Checked)
            {
                nivel = 2;
                AlumnoCheck.Checked = false;
                AdminitracionCheck.Checked = false;
                Notas.Visible = false;
                Faltas.Visible = false;
                curso.Visible = false;
                division.Visible = false;
                edit.Visible = true;
                X.Visible = true;
                CargaDeContactos();
            }
        }

        private void AdminitracionCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (AdminitracionCheck.Checked)
            {
                nivel = 1;
                ProfesorCheck.Checked = false;
                AlumnoCheck.Checked = false;
                Notas.Visible = false;
                Faltas.Visible = false;
                curso.Visible = false;
                division.Visible = false;
                edit.Visible = false;
                X.Visible = false;
                CargaDeContactos();
            }
        }

       
    }

}
