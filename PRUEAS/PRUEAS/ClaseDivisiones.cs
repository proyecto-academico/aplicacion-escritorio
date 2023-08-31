namespace PRUEAS
{
    public class ClaseDivisiones
    {
        public string Nombre { get; set; }
        public int ID { get; set; }
        public int turno { get; set; }
        public int divisions { get; set; }

        public ClaseDivisiones(string nombre, int iD, int turno, int divisions)
        {
            Nombre = nombre;
            ID = iD;
            this.turno = turno;
            this.divisions = divisions;
        }
    }
}
