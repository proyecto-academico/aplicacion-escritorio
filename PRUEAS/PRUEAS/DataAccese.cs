﻿using System.Data.SqlClient;
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
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;User ID=sa;Initial Catalog=proyecto_academico;Data Source=DESKTOP-QB22C4J\\SQLEXPRESS\r\n");

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
                sqlParameter3.Value = Persona.DNI;
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
                        DNI = int.Parse(reader["DNI_Alumno"].ToString()),
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
                sqlParameter3.Value = Persona.DNI;
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
                sqlParameter1.Value = personas.DNI;
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
        public List<ClaseFaltas> GetFaltas()
        {
            List<ClaseFaltas> personas = new List<ClaseFaltas>();
            try
            {
                conn.Open();
                string querry = @" SELECT Falta_ID, DNI_Alumno, Fecha, Tipo, jutificada
                                FROM faltas
                            ";
                SqlCommand command = new SqlCommand(querry, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    personas.Add(new ClaseFaltas
                    {
                        FaltasID = int.Parse(reader["DNI_Alumno"].ToString()),
                        DNI = int.Parse(reader["DNI_Alumno"].ToString()),
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
