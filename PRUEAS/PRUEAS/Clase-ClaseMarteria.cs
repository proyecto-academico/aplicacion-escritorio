using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEAS
{
    internal class Clase_ClaseMarteria
    {
        public int Clase_ID { get; set; }
        public int Division_ID { get; set; }
        public string Materia_ID {get; set;}
        public string Profesor_ID { get; set; }
        public DateTime Fecha_Comienzo { get; set; }
        public DateTime Fecha_Final { get; set; }

        public Clase_ClaseMarteria() {}

    }
}
