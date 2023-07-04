using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEAS
{
    public class ClaseFaltas : Personas
    {
        public int FaltasID { get; set; } 
        public DateTime Fecha { get; set; }
        public float Tipo { get; set; }
        public bool Justificado { get; set; } 
        public ClaseFaltas() { }
    }

}
