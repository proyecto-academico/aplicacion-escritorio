using System.Data.SqlClient;

namespace PRUEAS
{
    public class DB_Querys
    {

        private SqlConnection conn = new SqlConnection("Server=10.120.0.176;Database=proyecto_academico;User Id=123;Password=456;");

        #region Querry Personas

        public void insertarPersona(ClasePersonas Persona)
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            finally
            {

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
                sqlParameter3.DbType = System.Data.DbType.Decimal;

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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
                        UPDATE faltas 
                        SET jutificada = IIF(jutificada = 1 ,0,1)  Where Falta_ID = @Falta_ID
";
                #region Parametros que pasamos




                SqlParameter sqlParameter4 = new SqlParameter();
                sqlParameter4.ParameterName = "@Falta_ID";
                sqlParameter4.Value = falta.FaltasID;
                sqlParameter4.DbType = System.Data.DbType.String;

                #endregion

                #region Comandos Sql
                SqlCommand sqlCommand = new SqlCommand(querry, conn);


                sqlCommand.Parameters.Add(sqlParameter4);
                ;
                sqlCommand.ExecuteNonQuery();
                #endregion
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {

                conn.Close();
            }
        }





        public List<ClasePersonas> GetPersonas(int nivel)
        {
            List<ClasePersonas> personas = new List<ClasePersonas>();
            try
            {

                if (nivel > 2)
                {
                    conn.Open();

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

                        personas.Add(new ClasePersonas
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
#pragma warning disable CS8604 // Posible argumento de referencia nulo
#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8601 // Posible asignación de referencia nula
                        personas.Add(new ClasePersonas
                        {
                            _dni = int.Parse(reader["DNI"].ToString()),
                            Name = reader["Nombre"].ToString(),
                            Surname = reader["Apellido"].ToString(),
                            mail = reader["Mail"].ToString(),

                        });
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8604 // Posible argumento de referencia nulo
                    }
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return personas;
        }

        public void UpdatePersona(ClasePersonas Persona)
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {

                conn.Close();
            }
        }

        public void DeletePersona(ClasePersonas personas)
        {


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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {

                conn.Close();
            }


        }

        #endregion

        #region Querry ClaseMateria
        public List<Clase_ClaseMateria> GetClaseClaseMaterias(int ObjMateria)
        {
            List<Clase_ClaseMateria> materia= new List<Clase_ClaseMateria>();
          
            try
            {
                conn.Open();
                string querry = @$"SELECT  [Clase_ID],CONCAT(division.Anio_Escolar, '° ', division.Division_Escolar, '° ')AS Division,division.Division_ID,CONCAT(persona.Nombre,' ',persona.Apellido)AS Profesor,[clase].[Materia_ID],[Profesor_ID],[Fecha_Comienzo],[Fecha_Final], materia.Nombre FROM [proyecto_academico].[dbo].[clase] LEFT JOIN materia on clase.Materia_ID=materia.Materia_ID LEFT JOIN division on clase.Division_ID = division.Division_ID LEFT JOIN persona on clase.Profesor_ID = persona.DNI WHERE clase.Materia_ID = {ObjMateria} ";
                SqlCommand command = new SqlCommand(querry, conn);

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
#pragma warning disable CS8604 // Posible argumento de referencia nulo
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                    materia.Add(new Clase_ClaseMateria
                    (
                        reader["Clase_ID"].ToString(),
                        reader["Division"].ToString(),
                        (reader["Materia_ID"].ToString()),
                        (reader["Profesor"].ToString()),
                        reader["Fecha_Comienzo"].ToString(),
                        reader["Fecha_Final"].ToString(),
                        reader["Nombre"].ToString()
                        
                        
                    )) ; 
#pragma warning restore CS8604 // Posible argumento de referencia nulo
#pragma warning restore CS8604 // Posible argumento de referencia nulo
#pragma warning restore CS8604 // Posible argumento de referencia nulo

                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return materia;
        }
        #endregion  // hay que poner un refrascar para finalizar los del año actual para copiarlos de nuevo y poner el nuevo año

        #region Querry Divisiones
        public List<ClaseDivisiones> GetDivisiones()
        {
            List<ClaseDivisiones> divisiones = new List<ClaseDivisiones>();

            try
            {
                conn.Open();
                string querry = @$"SELECT Division_ID, Turno, CONCAT(Anio_Escolar , '° ' , Division_Escolar , '°') as division_nombre FROM division";
                SqlCommand command = new SqlCommand(querry, conn);

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
#pragma warning disable CS8604 // Posible argumento de referencia nulo
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                    divisiones.Add(new ClaseDivisiones
                    (
                        int.Parse(reader["Division_ID"].ToString()),
                        (reader["Turno"].ToString()),
                        reader["division_nombre"].ToString()
                        
                    ));
#pragma warning restore CS8604 // Posible argumento de referencia nulo
#pragma warning restore CS8604 // Posible argumento de referencia nulo
#pragma warning restore CS8604 // Posible argumento de referencia nulo

                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return divisiones;
        }
        #endregion

        #region Querry Materia
        public List<ClaseMateria> GetMaterias()
        {
            List<ClaseMateria> a = new List<ClaseMateria>();

            try
            {
                conn.Open();
                string querry = @$"SELECT materia.Materia_ID, materia.Nombre, Anio_escolar, Horas_Semanales FROM materia";
                SqlCommand command = new SqlCommand(querry, conn);

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
#pragma warning disable CS8604 // Posible argumento de referencia nulo
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                    a.Add(new ClaseMateria
                    (

                     
                        int.Parse(reader["Materia_ID"].ToString()),
                        (reader["Nombre"].ToString()),
                        int.Parse(reader["Anio_escolar"].ToString()),
                        int.Parse(reader["Horas_semanales"].ToString())
                    ));

                    

#pragma warning restore CS8604 // Posible argumento de referencia nulo
#pragma warning restore CS8604 // Posible argumento de referencia nulo
#pragma warning restore CS8604 // Posible argumento de referencia nulo

                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return a;
        }
        #endregion

        #region Querry Notas
        public List<Clasenotas> GetClasenotas(int persona_)
        {
            List<Clasenotas> clasenotas = new();

            try
            {
                conn.Open();
                string querry = @$"SELECT notas.Notas_ID, notas.DNI_Alumno, CONCAT(persona.Nombre, ' ', persona.Apellido) as nombre_alumno, nota, clase.Clase_ID , CONCAT(materia.Nombre, ' ', division.Anio_Escolar, '° ', division.Division_Escolar, '°') as clase_nombre, evaluaciones.Fecha, evaluaciones.Evaluacion_ID FROM notas INNER JOIN persona ON notas.DNI_Alumno = persona.DNI INNER JOIN clase ON clase.Clase_ID = notas.Notas_ID INNER JOIN division ON clase.Division_ID = division.Division_ID INNER JOIN materia ON materia.Materia_ID = clase.Materia_ID INNER JOIN evaluaciones ON notas.Evaluacion_ID = evaluaciones.Evaluacion_ID WHERE persona.DNI = {persona_}";
                SqlCommand command = new SqlCommand(querry, conn);

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
#pragma warning disable CS8604 // Posible argumento de referencia nulo
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                    clasenotas.Add(new Clasenotas {
                    
                        NotasID = int.Parse(reader["Notas_ID"].ToString()),
                        Nota =decimal.Parse(reader["nota"].ToString()),
                        clase =(reader["clase_nombre"].ToString()),
                        Name=(reader["nombre_alumno"].ToString()),
                        DateT=DateTime.Parse(reader["Fecha"].ToString())
                        
                        })  ;
#pragma warning restore CS8604 // Posible argumento de referencia nulo
#pragma warning restore CS8604 // Posible argumento de referencia nulo
#pragma warning restore CS8604 // Posible argumento de referencia nulo

                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return clasenotas;
        }

        #endregion

        #region Querry Evaluaciones 
        public List<ClaseEvaluaciones> GetEvaluaciones()
        {
            List<ClaseEvaluaciones> evaluaciones = new List<ClaseEvaluaciones>();

            try
            {
                conn.Open();
                string querry = @$"SELECT evaluaciones.Evaluacion_ID, MAX(evaluaciones.Clase_ID) as Clase_ID, MAX(Fecha) as Fecha, MAX(Detalles) as Detalles, MAX(CONCAT(materia.Nombre, ' ',  division.Anio_Escolar , '° ' , Division_Escolar , '° ', YEAR( Fecha_Comienzo ))) as clase_name,  AVG(notas.Nota) as nota_promedio from evaluaciones INNER JOIN clase on clase.Clase_ID =evaluaciones.Clase_ID inner join materia on materia.Materia_ID=clase.Materia_ID INNER JOIN division ON clase.Division_ID=division.Division_ID INNER JOIN notas ON notas.Evaluacion_ID = evaluaciones.Evaluacion_ID GROUP BY evaluaciones.Evaluacion_ID";
                SqlCommand command = new SqlCommand(querry, conn);

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
#pragma warning disable CS8604 // Posible argumento de referencia nulo
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                    evaluaciones.Add(new ClaseEvaluaciones
                    (
                        int.Parse(reader["Evaluacion_ID"].ToString()),
                        (reader["clase_name"].ToString()),
                        reader["Clase_ID"].ToString(),
                        reader["Fecha"].ToString(),
                        (reader["Detalles"].ToString()),
                        float.Parse(reader["nota_promedio"].ToString())
                    ));
#pragma warning restore CS8604 // Posible argumento de referencia nulo
#pragma warning restore CS8604 // Posible argumento de referencia nulo
#pragma warning restore CS8604 // Posible argumento de referencia nulo

                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return evaluaciones;
        }

        #endregion

        #region Querry Faltas
        public List<ClaseFaltas> GetFaltas(int persona_)
        {
            List<ClaseFaltas> faltas = new List<ClaseFaltas>();
            try
            {
                conn.Open();
                string querry = @$"SELECT Falta_ID,Fecha, Tipo, CASE WHEN jutificada = 1 THEN 'True' ELSE 'False' END AS jutificada FROM persona INNER JOIN faltas ON persona.DNI = faltas.DNI_Alumno WHERE persona.DNI = {persona_}";

                SqlCommand command = new SqlCommand(querry, conn);

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
#pragma warning disable CS8604 // Posible argumento de referencia nulo
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                    faltas.Add(new ClaseFaltas
                    {
                        FaltasID = int.Parse(reader["Falta_ID"].ToString()),
                        Fecha = DateTime.Parse(reader["Fecha"].ToString()),
                        Tipo = float.Parse(reader["Tipo"].ToString()),
                        Justificado = Convert.ToBoolean(reader["jutificada"].ToString())

                    });

#pragma warning restore CS8604 // Posible argumento de referencia nulo
#pragma warning restore CS8604 // Posible argumento de referencia nulo
#pragma warning restore CS8604 // Posible argumento de referencia nulo

                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
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
                string querry3 = @$"SELECT IIF(SUM(tipo) is null, 0, SUM(tipo)) AS Faltas from faltas WHERE DNI_Alumno={persona_} ";
                SqlCommand command3 = new SqlCommand(querry3, conn);
                SqlDataReader reader3 = command3.ExecuteReader();

                while (reader3.Read())
                {
                    faltas.cantTotal = (int)Convert.ToInt64(reader3["Faltas"]);



                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return faltas.cantTotal;
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
                    faltas.cantJusti = (int)Convert.ToInt64(reader3["FaltasJust"]);



                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return faltas.cantJusti;
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
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
       */
        #endregion

        #region Querry Varios 

        public List<ClasePersonas> BuscarPersona(int nivel, string Busqueda)
        {
            List<ClasePersonas> personas = new List<ClasePersonas>();
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
#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                    personas.Add(new ClasePersonas
                    {
                        _dni = int.Parse(reader["DNI"].ToString()),
                        Name = reader["Nombre"].ToString(),
                        Surname = reader["Apellido"].ToString(),
                        mail = reader["Mail"].ToString()

                    });
#pragma warning restore CS8604 // Posible argumento de referencia nulo
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8601 // Posible asignación de referencia nula
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return personas;

        }

        public List<ClasePersonas> BuscarPersona(int nivel, int Busqueda)
        {
            List<ClasePersonas> personas = new List<ClasePersonas>();
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
#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8604 // Posible argumento de referencia nulo
                    personas.Add(new ClasePersonas
                    {
                        _dni = int.Parse(reader["DNI"].ToString()),
                        Name = reader["Nombre"].ToString(),
                        Surname = reader["Apellido"].ToString(),
                        mail = reader["Mail"].ToString()

                    });
#pragma warning restore CS8604 // Posible argumento de referencia nulo
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8601 // Posible asignación de referencia nula
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return personas;

        }
        #endregion

        #region
        public List<ClaseEvaluaciones> evaluacionesPersona(int dni, int division)
        {
            List<ClaseEvaluaciones> evaluaciones = new List<ClaseEvaluaciones>();
            try
            {
                string querry;
                conn.Open();

                querry = @"SELECT Evaluacion_ID, evaluaciones.Clase_ID, Fecha, Detalles, CONCAT(materia.Nombre, ' ',  division.Anio_Escolar , '° ' , Division_Escolar , '° ', YEAR( Fecha_Comienzo )) as nombre_de_clase FROM persona											
                            INNER JOIN division_de_alumnos ON persona.DNI = division_de_alumnos.DNI_Alumno											
                            INNER JOIN division ON division_de_alumnos.Division_ID = division.Division_ID											
                            INNER JOIN clase ON clase.Division_ID = division.Division_ID											
                            INNER JOIN evaluaciones ON evaluaciones.Clase_ID = clase.Clase_ID											
                            INNER JOIN materia ON materia.Materia_ID = clase.Materia_ID											
                            WHERE nivel=3											
                            AND persona.DNI = {@dni}											
                            AND division.Division_ID = {@division}
							";

                SqlParameter sqlParameter3 = new SqlParameter();
                sqlParameter3.ParameterName = "@DNI";
                sqlParameter3.Value = dni;
                sqlParameter3.DbType = System.Data.DbType.Int64;
                SqlParameter sqlParameter1 = new SqlParameter();
                sqlParameter1.ParameterName = "@division";
                sqlParameter1.Value = division;
                sqlParameter1.DbType = System.Data.DbType.Int64;

                SqlCommand command = new SqlCommand(querry, conn);
                command.Parameters.Add(sqlParameter3);
                command.Parameters.Add(sqlParameter1);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    evaluaciones.Add( new ClaseEvaluaciones( 
                    
                        int.Parse(reader["Evaluacion_ID"].ToString()),
                         reader["nombre_de_clase"].ToString(),
                         reader["Detalles"].ToString(),
                        reader["Fecha"].ToString(),
                        reader["Detalles"].ToString(),
                         float.Parse(reader[""].ToString())
                         )
                    );

                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return evaluaciones;

        }

        #endregion

        #region prueba de los listbox

        public List<int> GetDni()
        {
            List<int> personas = new List<int>();
            try
            {

               
                    conn.Open();

                   
                
                
              
                 
                    string querry = @"  Select DNI from persona where Nivel = 2
                            ";
                   
                    SqlCommand command = new SqlCommand(querry, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
#pragma warning disable CS8604 // Posible argumento de referencia nulo
#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8601 // Posible asignación de referencia nula
#pragma warning disable CS8601 // Posible asignación de referencia nula
                        personas.Add(
                        
                            int.Parse(reader["DNI"].ToString())

                        );
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8601 // Posible asignación de referencia nula
#pragma warning restore CS8604 // Posible argumento de referencia nulo
                    }
                

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
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
