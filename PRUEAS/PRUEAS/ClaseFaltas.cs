namespace PRUEAS
{
    public class ClaseFaltas : ClasePersonas
    {
        public int FaltasID { get; set; }
        public DateTime Fecha { get; set; }
#pragma warning disable CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
        public float Tipo { get; set; }
#pragma warning restore CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
        public bool Justificado { get; set; }
        public int cantJusti { get; set; }
        public int cantTotal { get; set; }

       /* public ClaseFaltas(int faltasID, DateTime fecha, float tipo, bool justificado)
        {
            FaltasID = faltasID;
            Fecha = fecha;
            Tipo = tipo;
            Justificado = justificado;

        }*/
    }
}
