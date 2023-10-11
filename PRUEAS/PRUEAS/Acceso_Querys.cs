namespace PRUEAS
{
    public class Acceso_Querys
    {

        public int Dato;
        public DB_Querys __DataAccese;

        public Acceso_Querys()
        {
            __DataAccese = new DB_Querys();
        }

        public ClasePersonas guardarPersonaEnDB(ClasePersonas ObjPersonas, bool personaYaExiste)
        {

            if (personaYaExiste)
            {
                __DataAccese.UpdatePersona(ObjPersonas);
            }
            else
            {
                __DataAccese.insertarPersona(ObjPersonas);

            }
            return ObjPersonas;
        }


        public void guardarFaltaEnDB(ClaseFaltas ObjFalta, bool ExisteFalta)
        {
            if (!ExisteFalta)
            {
                __DataAccese.insertarFalta(ObjFalta);
            }
            else
            {
                __DataAccese.UpdateFalta(ObjFalta);
            }

        }

        

        public List<ClasePersonas> ObetenerPersona(int nivel)
        {
            return __DataAccese.GetPersonas(nivel);

        }
        public void DeletePersona(ClasePersonas ObjPersonas)
        {
            __DataAccese.DeletePersona(ObjPersonas);

        }
        public List<ClaseFaltas> ObetenerFaltas(int ObjPersonas)
        {
            return __DataAccese.GetFaltas(ObjPersonas);

        }
        public List<ClasePersonas> BusquedaDePersonas(int nivel, string StringBusqueda)
        {
            return __DataAccese.BuscarPersona(nivel, StringBusqueda);

        }

        public List<ClasePersonas> BusquedaDePersonas(int nivel, int IntBusqueda)
        {
            return __DataAccese.BuscarPersona(nivel, IntBusqueda);

        }

        public int ObtenerNumeroDeFaltas(int ObjPersona, int tipo)
        {
            if (tipo == 0)
            {
                return __DataAccese.NumGetFaltas(ObjPersona);
            }
            else
            {
                return __DataAccese.NumGetFaltasJust(ObjPersona);
            }
        }

        public List<Clase_ClaseMateria> CargarMaterias(int ObjMateria)
        {
            return __DataAccese.GetClaseClaseMaterias(ObjMateria);
        }

        public List<ClaseDivisiones> CargarDivisiones()
        {
            return __DataAccese.GetDivisiones();
        }
        public List<ClaseEvaluaciones> ClaseEvaluaciones()
        {
            return __DataAccese.GetEvaluaciones();
        }

        public List<Clasenotas> GetClasenotas(int _persona)
        {
            return  __DataAccese.GetClasenotas(_persona);
        }

        public List<ClaseMateria> GetMaterias()
        {
            return __DataAccese.GetMaterias();
        }
        public List<int> GetDNI()
        {
            return __DataAccese.GetDni();
        }
    }
}
