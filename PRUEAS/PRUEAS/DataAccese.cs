using System.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.CodeAnalysis;

namespace PRUEAS
{
    public class DataAccese
    {
//        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=proyecto_academico;Data Source=DESKTOP-QB22C4J\\SQLEXPRESS");
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Initial Catalog=proyecto_academico;Data Source=DESKTOP-QB22C4J\\SQLEXPRESS");

        #region Querry Personas
        public void insertarPersona(Personas Persona)
        {
            try
            {
                conn.Open();
                string querry = @"
                        INSERT INTO persona (DNI, Nombre, Apellido, Mail, Nivel)
                        VALUES (@DNI, @Nombre, @Apellido, @mail, @nivel)
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

                SqlParameter sqlParameter5 = new SqlParameter();
                sqlParameter5.ParameterName = "@nivel";
                sqlParameter5.Value = Persona.Tipo;
                sqlParameter5.DbType = System.Data.DbType.Int64;
                #endregion

                #region Comandos Sql
                SqlCommand sqlCommand = new SqlCommand(querry, conn);
                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.Parameters.Add(parametros2);
                sqlCommand.Parameters.Add(sqlParameter3);
                sqlCommand.Parameters.Add(sqlParameter4);
                sqlCommand.Parameters.Add(sqlParameter5);
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

        public void insertarFalta(ClaseFaltas falta)
        {
            try
            {
                conn.Open();
                string querry = @"
                        INSERT INTO faltas (Falta_ID, DNI_Alumno, Fecha, Tipo, jutificada)
                        VALUES (@Falta_ID, @DNI_Alumno, @Fecha, @Tipo, @jutificada)";

                SqlCommand sqlCommandForNetxID = new SqlCommand("SELECT MAX(Falta_ID) + 1 as FALTAID FROM faltas  ", conn);
                SqlDataReader readerForNetxID = sqlCommandForNetxID.ExecuteReader();
                readerForNetxID.Read();


                #region Parametros que pasamos
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Falta_ID";
                sqlParameter.Value = readerForNetxID["FALTAID"];
                sqlParameter.DbType = System.Data.DbType.Int64;

                SqlParameter sqlParameter9 = new SqlParameter();
                sqlParameter9.ParameterName = "@DNI_Alumno";
                sqlParameter9.Value = falta._dni;
                sqlParameter9.DbType = System.Data.DbType.Int64;

                SqlParameter parametros2 = new SqlParameter();
                parametros2.ParameterName = "@Fecha";
                parametros2.Value = falta.Fecha;
                parametros2.DbType = System.Data.DbType.DateTime;

                SqlParameter sqlParameter3 = new SqlParameter();
                sqlParameter3.ParameterName = "@Tipo";
                sqlParameter3.Value = falta.Tipo;
                sqlParameter3.DbType = System.Data.DbType.Int64;

                SqlParameter sqlParameter4 = new SqlParameter();
                sqlParameter4.ParameterName = "@jutificada";
                sqlParameter4.Value = falta.Justificado;
                sqlParameter4.DbType = System.Data.DbType.Int64;



                #endregion
                readerForNetxID.Close();
                #region Comandos Sql
                SqlCommand sqlCommand = new SqlCommand(querry, conn);
                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.Parameters.Add(parametros2);
                sqlCommand.Parameters.Add(sqlParameter3);
                sqlCommand.Parameters.Add(sqlParameter4);
                sqlCommand.Parameters.Add(sqlParameter9);

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



        public void UpdateFalta(ClaseFaltas falta)
        {
            try
            {
                conn.Open();
                string querry = @"
                        UPDATE falta 
                        SET Fecha=@Fecha, Tipo=@Tipo, justificada=@justificada WHERE Falta_ID = @Falta_ID
";
                #region Parametros que pasamos
                SqlParameter sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Fecha";
                sqlParameter.Value = falta.Fecha;
                sqlParameter.DbType = System.Data.DbType.String;

                SqlParameter parametros2 = new SqlParameter();
                parametros2.ParameterName = "@Tipo";
                parametros2.Value = falta.Tipo;
                parametros2.DbType = System.Data.DbType.String;

                SqlParameter sqlParameter3 = new SqlParameter();
                sqlParameter3.ParameterName = "@justificada";
                sqlParameter3.Value = falta.Justificado;
                sqlParameter3.DbType = System.Data.DbType.Int64;

                SqlParameter sqlParameter4 = new SqlParameter();
                sqlParameter4.ParameterName = "@Falta_ID";
                sqlParameter4.Value = falta.FaltasID;
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





        public List<Personas> GetPersonas(int nivel)
        {   List<Personas> personas = new List<Personas>();
            try
            {
                
                if (nivel > 2)
                {
                    conn.Open();

                    /*string querry = @" SELECT	DNI ,Nombre,Apellido, Mail, [division].Anio_Escolar, [division].Division_Escolar
                    FROM persona p
                    LEFT JOIN division_de_alumnos d ON p.DNI = d.DNI_Alumno INNER JOIN division  ON [division].Division_ID = d.Division_ID WHERE d.Anio_Calendario = 2023 AND @nivel = Nivel

                            ";*/


                    string querry = @" SELECT	p.DNI ,Nombre,Apellido, Mail, d.Anio_Calendario,[division].Anio_Escolar, [division].Division_Escolar
                    FROM persona p
                    LEFT JOIN (SELECT DNI, MAX(Anio_Calendario) as Anio_Calendario , MAX(Division_ID) as Division_ID from persona left join division_de_alumnos on persona.DNI=division_de_alumnos.DNI_Alumno GROUP BY DNI) d ON p.DNI = d.DNI left JOIN division  ON [division].Division_ID = d.Division_ID WHERE d.Anio_Calendario = 2023 AND @nivel = Nivel ";


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

        public void UpdatePersona(Personas Persona)
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

        public void DeletePersona(Personas personas) {


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
                        Justificado = Convert.ToBoolean(reader["jutificada"].ToString()),
                        

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
        public int NumGetFaltas(int persona_)
        {
            ClaseFaltas faltas = new ClaseFaltas();
            try
            {
                conn.Open();
                string querry3 = @$"Select  COUNT(faltas.Falta_ID) AS Faltas from faltas where DNI_Alumno = {persona_} ";
                SqlCommand command3 = new SqlCommand(querry3, conn);
                SqlDataReader reader3 = command3.ExecuteReader();
                while (reader3.Read())
                {
                    faltas.cantTotal = (int)Convert.ToInt64(reader3["Faltas"]);

                    

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
            return faltas.cantJusti;
        }
        public int NumGetFaltasJust(int persona_)
        {
            ClaseFaltas faltas = new ClaseFaltas();
            try
            {
                conn.Open();
                string querry2 = @$"Select  COUNT(faltas.Falta_ID) AS FaltasJust from faltas inner join persona on DNI=DNI_Alumno where jutificada = 1 and DNI_Alumno = {persona_}"; 
                SqlCommand command3 = new SqlCommand(querry2, conn);
                SqlDataReader reader3 = command3.ExecuteReader();
                while (reader3.Read())
                {
                    faltas.cantTotal = (int)Convert.ToInt64(reader3["FaltasJust"]);

               

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
            return faltas.cantTotal;
        }/*
        public  int GuardarFaltas (int persona_)
        {
            try
            {
                conn.Open();
                string query = @"INSERT INTO faltas (fecha, tipo, justificada,DNI) values (@fecha, @Tipo, @justificada, @DNi)";
                SqlCommand command2 = new SqlCommand(query, conn);
                SqlDataReader reader3 = command2.ExecuteReader();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
       */
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
                        FROM persona p
                        INNER JOIN division_de_alumnos d ON p.DNI = d.DNI_Alumno INNER JOIN division  ON [division].Division_ID = d.Division_ID WHERE nivel = @nivel
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
                        FROM persona p
                        INNER JOIN division_de_alumnos d ON p.DNI = d.DNI_Alumno INNER JOIN division  ON [division].Division_ID = d.Division_ID WHERE nivel = @nivel
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
