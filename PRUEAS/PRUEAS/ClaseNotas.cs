 namespace PRUEAS
{
    public class Clasenotas : ClasePersonas
    {

        public int NotasID;
        public decimal Nota { get; set; }
        public int Evaluacion_ID { get; set; }
        public DateTime DateTime { get; set; }

        public Clasenotas(int notasID, decimal nota, int evaluacion_ID, DateTime dateTime)
        {
            NotasID = notasID;
            Nota = nota;
            Evaluacion_ID = evaluacion_ID;
            DateTime = dateTime;
        }
    }
}
