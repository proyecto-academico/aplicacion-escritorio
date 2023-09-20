namespace PRUEAS
{
    public class Clase_ClaseMateria : ClasePersonas
    {
        private DateTime Date;
        public string NombreMateria { get; set; }
        public string Clase_ID { get; set; }
        public string Division_ID { get; set; }
        public string Materia_ID { get; set; }
        public string Profesor_ID { get; set; }
        public DateTime Fecha_Comienzo { get ; set; }
        public DateTime Fecha_Final { get; set; }
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.

        public Clase_ClaseMateria(string clase_ID, string division_ID, string materia_ID, string profesor_ID, string fecha_Comienzo, string fecha_Final, string Name)
        {
            NombreMateria = Name;
            Clase_ID = clase_ID;
            Division_ID = division_ID;
            Materia_ID = materia_ID;
            Profesor_ID = profesor_ID;
            if (DateTime.TryParse(fecha_Comienzo, out Date))
            {
                Fecha_Comienzo = DateTime.Parse(fecha_Comienzo);
            }
            if (DateTime.TryParse(fecha_Final, out Date))
            {
                Fecha_Final = DateTime.Parse(fecha_Final);
            }
        }
    }
}
