using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEAS
{
    internal class ClaseEvaluaciones
    {
        public int Division_ID { get; set; }
        public string Clase { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalles { get; set; }
        public int NotaPromedio { get; set; }
        public ClaseEvaluaciones() { }
    }
}
