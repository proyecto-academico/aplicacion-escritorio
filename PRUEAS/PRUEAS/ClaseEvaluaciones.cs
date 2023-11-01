namespace PRUEAS
{
    public class ClaseEvaluaciones
    {
        DateTime Date;
        public int? Evaluacion_ID { get; set; }
        public string? Clase { get; set; }
        public string? Clase_Name { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Detalles { get; set; }
        public float? NotaPromedio { get; set; }
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public ClaseEvaluaciones(int? evaluacion_ID, string? Clase_name, string? clase, string? fecha, string? detalles, float? notaPromedio)
        {
            Evaluacion_ID = evaluacion_ID;
            Clase = clase;
            Clase_Name = Clase_name;
            if (DateTime.TryParse(fecha, out Date))
            {
                Fecha = DateTime.Parse(fecha);
            }
            Detalles = detalles;
            NotaPromedio = notaPromedio;

        }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.


    }
}
