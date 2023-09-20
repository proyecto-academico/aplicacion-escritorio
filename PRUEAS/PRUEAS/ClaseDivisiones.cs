namespace PRUEAS
{
    public class ClaseDivisiones
    {

        public int ID { get; set; }
        public string turno { get; set; }
        public string divisions { get; set; }

<<<<<<< HEAD
        public ClaseDivisiones(int iD, string nombre, int turno, int divisions)
=======
        public ClaseDivisiones(int iD, string turno, string divisions)
>>>>>>> 7d92c16edfd87db4cd448c12586d55176fab09df
        {
            ID = iD;
            this.turno = turno;
            this.divisions = divisions;
        }
    }
}
