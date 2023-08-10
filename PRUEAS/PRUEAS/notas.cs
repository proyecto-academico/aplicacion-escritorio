using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEAS
{
    internal class notas : Personas
    {

        public int NotasID;
        public float Nota{ get; set; }
        public int Evaluacion_ID { get; set; }
        public notas() { }
    }
}
