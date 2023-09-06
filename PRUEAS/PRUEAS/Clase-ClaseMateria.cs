namespace PRUEAS
{
    public class Clase_ClaseMateria : ClasePersonas
    {
        public int Clase_ID { get; set; }
        public int Division_ID { get; set; }
        public string Materia_ID { get; set; }
        public string Profesor_ID { get; set; }
        public DateTime Fecha_Comienzo { get; set; }
        public DateTime Fecha_Final { get; set; }
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.

        public Clase_ClaseMateria(int clase_ID, int division_ID, string materia_ID, string profesor_ID, DateTime fecha_Comienzo, DateTime fecha_Final)
        {
            Clase_ID = clase_ID;
            Division_ID = division_ID;
            Materia_ID = materia_ID;
            Profesor_ID = profesor_ID;
            Fecha_Comienzo = fecha_Comienzo;
            Fecha_Final = fecha_Final;
        }
    }
}
