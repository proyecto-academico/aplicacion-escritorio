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

    public Personas GetFaltas(Personas personas, bool VerDades)
        {
           
            if (VerDades)
            {
                __DataAccese.UpdateData(personas);
            }
            else {
                __DataAccese.insertarData(personas);

            }
            return personas;
        }
        public List<Personas> TomaDePersonas(int nivel)
        {
            return __DataAccese.GetPersonas(nivel);
                
        }
        public void DeletePersona (Personas persona)
        {
            __DataAccese.DeleteData(persona);
            
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
