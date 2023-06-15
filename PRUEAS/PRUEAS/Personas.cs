using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEAS
{
    public class Personas
    {
        

        public string contrasenia { get; set; }
        public string Name { get; set; }
        public string mail{ get; set; }
        private int DNI;
        public int _dni{
            get => DNI;
            set {  if (value.ToString().Length < 9) { 
                        DNI = value;
                }
            else { throw new Exception("El DNI ESTA RE VOLADO AMIGO NO PODES INGRESAR MAS DE 8 DIGITOS GIL"); }
           }
        }

        public string Surname { get; set; }

        public Personas() { }
    }
}
