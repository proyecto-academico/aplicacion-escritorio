using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEAS
{   
    public class ManejoDeDB
    {
  
        public int Dato;
        public DataAccese __DataAccese;

        public ManejoDeDB() {
            __DataAccese = new DataAccese();
        }

        public Personas guardarPersonaEnDB(Personas personas, bool personaYaExiste)
        {
           
            if (personaYaExiste)
            {
                __DataAccese.UpdatePersona(personas);
            }
            else {
                __DataAccese.insertarPersona(personas);

            }
            return personas;
        }


        public Personas guardarFaltaEnDB(ClaseFaltas falta, bool faltaYaExiste)
        {

            if (faltaYaExiste)
            {
                __DataAccese.UpdateFalta(falta);
            }
            else
            {
                __DataAccese.insertarFalta(falta);

            }
            return falta;
        }



        public List<Personas> TomaDePersonas(int nivel)
        {
            return __DataAccese.GetPersonas(nivel);
                
        }
        public void DeletePersona (Personas persona)
        {
            __DataAccese.DeletePersona(persona);
            
        }
        public List<ClaseFaltas> TomaDeFaltas(int persona_)
        {
            return __DataAccese.GetFaltas(persona_);

        }
        public List<Personas> BusquedaDePersonas(int nivel, string Busqueda)
        {
            return __DataAccese.BuscarPersona(nivel, Busqueda);

        }

        public List<Personas> BusquedaDePersonas(int nivel, int Busqueda)
        {
            return __DataAccese.BuscarPersona(nivel, Busqueda);

        }

        public int TomaDeNumFaltas(int persona_, int tipo)
        {
            if (tipo == 0)
            {
                return __DataAccese.NumGetFaltas(persona_);
            }
            else
            {
                return __DataAccese.NumGetFaltasJust(persona_);
            }
        }

       
    }
}
