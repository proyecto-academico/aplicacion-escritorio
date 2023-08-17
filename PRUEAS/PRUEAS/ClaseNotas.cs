using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEAS
{
    internal class Clasenotas : ClasePersonas
    {

        public int NotasID;
        public float Nota{ get; set; }
        public int Evaluacion_ID { get; set; }
        public Clasenotas() { }
    }
}
