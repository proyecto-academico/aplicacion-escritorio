namespace PRUEAS
{
    public class ClasePersonas
    {



        public int Tipo;
        public string Name { get; set; }
        public string mail { get; set; }

        private int DNI;
        public int _dni
        {
            get => DNI;
            set
            {
                if (value.ToString().Length < 9)
                {
                    DNI = value;
                }
                else { throw new Exception("El DNI ESTA RE VOLADO AMIGO NO PODES INGRESAR MAS DE 8 DIGITOS GIL"); }
            }
        }
        public int curso { get; set; }
        public int division { get; set; }

        public string Surname { get; set; }

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.

        public ClasePersonas() { }

#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
    }
}
