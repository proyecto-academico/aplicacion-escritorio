namespace PRUEAS
{
    public class ClaseEvaluacionesMaterias
    {
        public int ID { get; set; }
        public int Evaluacion_ID { get; set; }
        public DateTime fecha { get; set; }
        public string detalles { get; set; }
        public string Nombre { get; set; }

        public ClaseEvaluacionesMaterias(int id, int evaluacion_id, DateTime fecha, string detalles, string Nombre)
        {
            ID = id;
            this.Nombre = Nombre;
            this.Evaluacion_ID = evaluacion_id;
            this.detalles = detalles;
            this.fecha = fecha;
        }

    }
}
