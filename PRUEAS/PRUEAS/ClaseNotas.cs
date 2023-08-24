namespace PRUEAS
{
    public class Clasenotas : ClasePersonas
    {

        public int NotasID;
        public decimal Nota { get; set; }
        public int Evaluacion_ID { get; set; }
        public DateTime DateTime { get; set; }
        public Clasenotas() { }
    }
}
