namespace PRUEAS
{
    public class ClaseDivisiones
    {
        
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int turno { get; set; }
        public int divisions { get; set; }

        public ClaseDivisiones(int iD,string nombre, int turno, int divisions)
        {
            ID = iD;
            Nombre = nombre;
            this.turno = turno;
            this.divisions = divisions;
        }
    }
}
