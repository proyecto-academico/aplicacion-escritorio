﻿namespace PRUEAS
{
    public class ClaseEvaluaciones
    {
        public int Division_ID { get; set; }
        public string Clase { get; set; }
        public DateTime Fecha { get; set; }
        public string Detalles { get; set; }
        public int NotaPromedio { get; set; }
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public ClaseEvaluaciones() { }
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.

        public ClaseEvaluaciones(int division_ID, string clase, DateTime fecha, string detalles, int notaPromedio)
        {
            Division_ID = division_ID;
            Clase = clase;
            Fecha = fecha;
            Detalles = detalles;
            NotaPromedio = notaPromedio;
        }
    }
}
