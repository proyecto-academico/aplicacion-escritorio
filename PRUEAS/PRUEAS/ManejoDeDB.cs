﻿using System;
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
        public List<Personas> TomaDePersonas()
        {
            return __DataAccese.GetPersonas();
                
        }
        public void DeletePersona (Personas persona)
        {
            __DataAccese.DeleteData(persona);
            
        }
    }
}
