namespace PRUEAS
{
    public class Clasenotas : ClasePersonas
    {
        private DateTime Date;
        public int NotasID { get; set; }
        public string clase { get; set; }
        public decimal Nota { get; set; }
        public DateTime DateT { get; set; }

        public Clasenotas()
        {
            
        }
    }
}
