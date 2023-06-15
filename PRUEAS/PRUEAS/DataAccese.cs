using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PRUEAS
{
    public class DataAccese
    {
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=proyecto_academico;Data Source=DESKTOP-3B9J7H4\\MSSQLSERVER01");

        #region Querry Personas
        public void insertarData(Personas Persona)
        {
            try
            {
                conn.Open();
                string querry = @"
                        INSERT INTO alumno (DNI_Alumno, Nombre, Apellido, Mail)
                        VALUES (@DNI, @Nombre, @Apellido, @mail)
";
                #region Parametros que pasamos
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Nombre";
                sqlParameter.Value = Persona.Name;
                sqlParameter.DbType = System.Data.DbType.String;

                SqlParameter parametros2 = new SqlParameter();
                parametros2.ParameterName = "@Apellido";
                parametros2.Value = Persona.Surname;
                parametros2.DbType = System.Data.DbType.String;
 
                SqlParameter sqlParameter3 = new SqlParameter();
                sqlParameter3.ParameterName = "@DNI";
                sqlParameter3.Value = Persona._dni;
                sqlParameter3.DbType = System.Data.DbType.Int64;

                SqlParameter sqlParameter4 = new SqlParameter();
                sqlParameter4.ParameterName = "@Mail";
                sqlParameter4.Value = Persona.mail;
                sqlParameter4.DbType = System.Data.DbType.String;
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
                string querry = @" SELECT DNI_Alumno, Nombre, Apellido, Mail
                                FROM alumno
                            ";
                SqlCommand command = new SqlCommand(querry, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    personas.Add(new Personas
                    {
                        _dni = int.Parse(reader["DNI_Alumno"].ToString()),
                        Name = reader["Nombre"].ToString(), 
                        Surname = reader["Apellido"].ToString(),
                        mail = reader["Mail"].ToString()
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

        public void UpdateData(Personas Persona)
        {
            try
            {
                conn.Open();
                string querry = @"
                        UPDATE alumno 
                        SET Nombre=@Nombre, Apellido=@Apellido, Mail=@Mail WHERE DNI_Alumno = @DNI
";
                #region Parametros que pasamos
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Nombre";
                sqlParameter.Value = Persona.Name;
                sqlParameter.DbType = System.Data.DbType.String;

                SqlParameter parametros2 = new SqlParameter();
                parametros2.ParameterName = "@Apellido";
                parametros2.Value = Persona.Surname;
                parametros2.DbType = System.Data.DbType.String;

                SqlParameter sqlParameter3 = new SqlParameter();
                sqlParameter3.ParameterName = "@DNI";
                sqlParameter3.Value = Persona._dni;
                sqlParameter3.DbType = System.Data.DbType.Int64;

                SqlParameter sqlParameter4 = new SqlParameter();
                sqlParameter4.ParameterName = "@Mail";
                sqlParameter4.Value = Persona.mail;
                sqlParameter4.DbType = System.Data.DbType.String;
                
                #endregion

                #region Comandos Sql
                SqlCommand sqlCommand = new SqlCommand(querry, conn);
                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.Parameters.Add(parametros2);
                sqlCommand.Parameters.Add(sqlParameter3);
                sqlCommand.Parameters.Add(sqlParameter4);
              ;
                sqlCommand.ExecuteNonQuery();
                #endregion
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

                conn.Close();
            }
        }

        public void DeleteData(Personas personas) {


            try
            {
                conn.Open();
                string querry = @"DELETE alumno where DNI_Alumno = @DNI ";
                #region Parametros
                SqlParameter sqlParameter1 = new SqlParameter();
                sqlParameter1.ParameterName = "@DNI";
                sqlParameter1.Value = personas._dni;
                sqlParameter1.DbType = System.Data.DbType.Int64;
                #endregion
                #region Envios
                SqlCommand sqlCommand = new SqlCommand(querry, conn);
                sqlCommand.Parameters.Add(sqlParameter1);
                sqlCommand.ExecuteNonQuery();
                #endregion
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

                conn.Close();
            }


        }
        #endregion
        
        #region Querry Faltas
        public List<ClaseFaltas> GetFaltas(int persona_)
        {
            List<ClaseFaltas> faltas = new List<ClaseFaltas>();
            try
            {
                conn.Open();
                string querry = @$"SELECT Fecha, Tipo, CASE WHEN jutificada = 1 THEN 'True' ELSE 'False' END AS jutificada FROM alumno INNER JOIN faltas ON alumno.DNI_Alumno = faltas.DNI_Alumno WHERE alumno.DNI_Alumno = {persona_}";
                SqlCommand command = new SqlCommand(querry, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    faltas.Add(new ClaseFaltas
                    {
                        Fecha = DateTime.Parse(reader["Fecha"].ToString()),
                        Tipo = float.Parse(reader["Tipo"].ToString()),
                        Justificado = Convert.ToBoolean(reader["jutificada"].ToString())
                    });
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return faltas;
        }
        
        #endregion
    }
}
