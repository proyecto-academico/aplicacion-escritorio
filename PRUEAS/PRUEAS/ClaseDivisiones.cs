namespace PRUEAS
{
    public class ClaseDivisiones
    {
        
        public int ID { get; set; }
        public string turno { get; set; }
        public string divisions { get; set; }

        public ClaseDivisiones(int iD, string turno, string divisions)
        {
            ID = iD;
            this.turno = turno;
            this.divisions = divisions;
        }
    }
}
