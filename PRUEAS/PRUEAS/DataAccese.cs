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
            try
            {
                conn.Open();
                string querry = @"
                        INSERT INTO Personas (DNI, Nombre, Apellido, ciclo)
                        VALUES (@DNI, @Nombre, @Apellido, @ciclo)
";
                #region Parametros que pasamos
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Name";
                sqlParameter.Value = Persona.Name;
                sqlParameter.DbType = System.Data.DbType.String;

                SqlParameter parametros2 = new SqlParameter();
                parametros2.ParameterName = "@Apellido";
                parametros2.Value = Persona.Surname;
                parametros2.DbType = System.Data.DbType.String;
 
                SqlParameter sqlParameter3 = new SqlParameter();
                sqlParameter3.ParameterName = "@DNI";
                sqlParameter3.Value = Persona.DNI;
                sqlParameter3.DbType = System.Data.DbType.Int64;

                SqlParameter sqlParameter4 = new SqlParameter();
                sqlParameter4.ParameterName = "@ciclo";
                sqlParameter4.Value = Persona.Ciclo;
                sqlParameter4.DbType = System.Data.DbType.Int64;
                #endregion

                #region Comandos Sql
                SqlCommand sqlCommand = new SqlCommand(querry, conn);
                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.Parameters.Add(parametros2);
                sqlCommand.Parameters.Add(sqlParameter3);
                sqlCommand.Parameters.Add(sqlParameter4);
                sqlCommand.ExecuteNonQuery();
                #endregion
            }
            catch (Exception)
            {   
                throw; 
            }
            finally{ 
            
            conn.Close();
            }

    
        }
    
        public List<Personas> GetPersonas()
        {   List<Personas> personas = new List<Personas>();
            try
            {  
                conn.Open();
                string querry = @" SELECT ID, DNI,Nombre, Apellido, Ciclo
                                FROM Personas
                            ";
                SqlCommand command = new SqlCommand(querry, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    personas.Add(new Personas
                    {
                        ID = int.Parse(reader["ID"].ToString()),
                        DNI = int.Parse(reader["DNI"].ToString()),
                        Name = reader["Nombre"].ToString(), 
                        Surname = reader["Apellido"].ToString(),
                        Ciclo = int.Parse(reader["Ciclo"].ToString())
                    });
                }

            }
            catch(Exception) {

                throw;
            }
            finally { 
                conn.Close(); 
            }
                return personas;
        }
    }
}
