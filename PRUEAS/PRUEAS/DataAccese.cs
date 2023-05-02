using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PRUEAS
{
    public class DataAccese
    {
        private SqlConnection conn = new SqlConnection("SQLOLEDB.1; Password=123;Persist Security Info=True;User ID = sa; Initial Catalog = Personas; Data Source = DESKTOP - QB22C4J\\SQLEXPRESS");


        public void insertarData(Personas Persona)
        {
            try { 
                conn.Open();
                string querry = @"
                        INSERT INTO Personas (DNI, Nombre, Apellido, ciclo)
                        VALUES (@DNI, @Nombre, @Apellido, @ciclo)
";

                SqlParameter sqlParameter = new SqlParameter(); 
            } 
            catch (Exception)
            {   
                throw; 
            }
        }
    }
}
