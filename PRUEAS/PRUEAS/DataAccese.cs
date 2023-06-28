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
                        INSERT INTO persona (DNI, Nombre, Apellido, Mail)
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
    
        public List<Personas> GetPersonas(int nivel)
        {   List<Personas> personas = new List<Personas>();
            try
            {  if (nivel > 2)
                {
                    conn.Open();
                    string querry = @" SELECT	DNI ,Nombre,Apellido, Mail, [division].Anio_Escolar, [division].Division_Escolar
                    FROM persona p
                    INNER JOIN division_de_alumnos d ON p.DNI = d.DNI_Alumno INNER JOIN division  ON [division].Division_ID = d.Division_ID WHERE d.Anio_Calendario = 2023

                            ";
                    SqlCommand command = new SqlCommand(querry, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        personas.Add(new Personas
                        {
                            _dni = int.Parse(reader["DNI"].ToString()),
                            Name = reader["Nombre"].ToString(),
                            Surname = reader["Apellido"].ToString(),
                            mail = reader["Mail"].ToString(),
                            division = int.Parse(reader["Anio_Escolar"].ToString()),
                            curso = int.Parse(reader["Division_Escolar"].ToString()),
                        });
                    }
                }
                else
                {
                    conn.Open();
                    string querry = @"  Select DNI, Nombre, Apellido, Mail from persona where @nivel = Nivel
                            ";
                    SqlParameter sqlParameter3 = new SqlParameter();
                    sqlParameter3.ParameterName = "@nivel";
                    sqlParameter3.Value = nivel;
                    sqlParameter3.DbType = System.Data.DbType.Int64;
                    SqlCommand command = new SqlCommand(querry, conn);
                    command.Parameters.Add(sqlParameter3);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        personas.Add(new Personas
                        {
                            _dni = int.Parse(reader["DNI"].ToString()),
                            Name = reader["Nombre"].ToString(),
                            Surname = reader["Apellido"].ToString(),
                            mail = reader["Mail"].ToString(),
                    
                        });
                    }
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
                        UPDATE persona 
                        SET Nombre=@Nombre, Apellido=@Apellido, Mail=@Mail WHERE DNI = @DNI
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
                string querry = @"DELETE persona where DNI = @DNI ";
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
                string querry = @$"SELECT Fecha, Tipo, CASE WHEN jutificada = 1 THEN 'True' ELSE 'False' END AS jutificada FROM persona INNER JOIN faltas ON persona.DNI = faltas.DNI_Alumno WHERE persona.DNI = {persona_}";
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
       
        #region Querry Varios 

        public List<Personas> BuscarPersona(int nivel, string Busqueda)
        {
            List<Personas> personas = new List<Personas>();
            try
            {
                string querry;
                conn.Open();

                querry = @" SELECT DNI, Nombre, Apellido, Mail 
                        FROM persona WHERE nivel = @nivel
                        AND (Nombre LIKE '%' + @busqueda + '%'
                        OR Apellido LIKE '%' + @busqueda + '%'
                        OR Mail LIKE '%' + @busqueda + '%')

                            ";

                SqlParameter sqlParameter3 = new SqlParameter();
                sqlParameter3.ParameterName = "@nivel";
                sqlParameter3.Value = nivel;
                sqlParameter3.DbType = System.Data.DbType.Int64;
                SqlParameter sqlParameter1 = new SqlParameter();
                sqlParameter1.ParameterName = "@busqueda";
                sqlParameter1.Value = Busqueda;
                sqlParameter1.DbType = System.Data.DbType.String;

                SqlCommand command = new SqlCommand(querry, conn);
                command.Parameters.Add(sqlParameter3);
                command.Parameters.Add(sqlParameter1);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    personas.Add(new Personas
                    {
                        _dni = int.Parse(reader["DNI"].ToString()),
                        Name = reader["Nombre"].ToString(),
                        Surname = reader["Apellido"].ToString(),
                        mail = reader["Mail"].ToString()
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
            return personas;

        }
        public List<Personas> BuscarPersona(int nivel, int Busqueda)
        {
            List<Personas> personas = new List<Personas>();
            try
            {
                string querry;
                conn.Open();

                querry = @" SELECT DNI, Nombre, Apellido, Mail 
                        FROM persona WHERE nivel = @nivel
                        AND DNI = @busqueda 
                            ";

                SqlParameter sqlParameter3 = new SqlParameter();
                sqlParameter3.ParameterName = "@nivel";
                sqlParameter3.Value = nivel;
                sqlParameter3.DbType = System.Data.DbType.Int64;
                SqlParameter sqlParameter1 = new SqlParameter();
                sqlParameter1.ParameterName = "@busqueda";
                sqlParameter1.Value = Busqueda;
                sqlParameter1.DbType = System.Data.DbType.Int64;

                SqlCommand command = new SqlCommand(querry, conn);
                command.Parameters.Add(sqlParameter3);
                command.Parameters.Add(sqlParameter1);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    personas.Add(new Personas
                    {
                        _dni = int.Parse(reader["DNI"].ToString()),
                        Name = reader["Nombre"].ToString(),
                        Surname = reader["Apellido"].ToString(),
                        mail = reader["Mail"].ToString()
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
            return personas;

        }
        #endregion
    }
}
