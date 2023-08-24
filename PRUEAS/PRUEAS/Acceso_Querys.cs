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
            if (ExisteFalta)
            {
                __DataAccese.insertarFalta(ObjFalta);
            }
            else
            {
                __DataAccese.UpdateFalta(ObjFalta);
            }

        }

        public List<Clase_ClaseMateria> GetClaseClaseMarterias(int ObjPersonas)
        {
            return __DataAccese.GetClaseClaseMaterias(ObjPersonas, Convert);
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


    }
}
