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

    public Personas GuardarPersonas(Personas personas, bool VerDades)
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
    }
}
