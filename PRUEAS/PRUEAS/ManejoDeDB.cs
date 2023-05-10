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

    public Personas GuardarPersonas(Personas personas)
        {
            BaseDeDatos baseDeDatos = new BaseDeDatos();
            if (baseDeDatos.BotonesValue != "edit")
            {
                __DataAccese.insertarData(personas);
            }
            else {
                __DataAccese.UpdateData(personas);
                baseDeDatos.BotonesValue = "";
            }
            return personas;
        }
        public List<Personas> TomaDePersonas()
        {
            return __DataAccese.GetPersonas();
                
        }
    }
}
