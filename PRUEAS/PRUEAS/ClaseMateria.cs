namespace PRUEAS
{
    public class ClaseMateria
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Anio_escolar { get; set; }
        public int Horas_semanales { get; set; }

        public ClaseMateria(int iD, string nombre, int anio_escolar, int horas_semanales)
        {
            ID = iD;
            this.Nombre = nombre;
            Anio_escolar = anio_escolar;
            Horas_semanales = horas_semanales;
        }
    }
}
