using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEAS
{
    internal class ManejoDeDB
    {
        public int Dato;
        public DataAccese __DataAccese;

        public ManejoDeDB() {
            __DataAccese = new DataAccese();
    }

    public Personas GuardarPersonas(Personas personas)
        {
            if (Dato==0)
            {
                __DataAccese.insertarData(personas);
            }
            else {
                //__DataAccese.UpdateData(personas);           
            }
            return personas;
        }

    }
}
