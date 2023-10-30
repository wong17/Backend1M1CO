namespace MetodosConstructores.MetodosAtributosStatic.Metodos
{
    public class GestionFechaHora
    {
        public static DateTime ObtenerFechaHoraActual()
        {
            return DateTime.Now;
        }

        public static string ObtenerNombreDiaSemana(DateTime fecha)
        {
            return fecha.ToString("dddd");
        }

        public static int ObtenerNumeroDiaMes(DateTime fecha)
        {
            return fecha.Day;
        }

        public static string ObtenerNombreMes(DateTime fecha)
        {
            return fecha.ToString("MMMM");
        }

        public static int ObtenerAnio(DateTime fecha)
        {
            return fecha.Year;
        }

        public static bool EsAnioBisiesto(int anio)
        {
            return DateTime.IsLeapYear(anio);
        }
    }

}
