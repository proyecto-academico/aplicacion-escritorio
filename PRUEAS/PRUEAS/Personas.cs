using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEAS
{
    public class Personas
    {
        private int _dni;

        public int ID { get; set; }
        public string Name { get; set; }
        public int Ciclo { get; set; }
        public int DNI{ get; set;
           
           /* corregi las exepciones no funcionan como deben
            * get =>  _dni;
            set
            {
                if (value.ToString().Length >= 8 )
                {
                    throw new ArgumentException("El DNI debe tener 8 caracteres.");

                    _dni = value;
                }
            }*/
        }
        public string Surname { get; set; }

        public Personas() { }
    }
}
