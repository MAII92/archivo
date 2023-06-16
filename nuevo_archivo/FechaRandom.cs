using System;


public class FechaRandom
{
    public static string Fecha()
    {
        DateTime fechaActual = DateTime.Now;
        Random random = new Random();
        int diasAleatorios = (Math.Abs(random.Next(1, 31)) * -1) + -30;
        DateTime fechaAleatoria = fechaActual.AddDays(diasAleatorios);
        return fechaAleatoria.ToString("yyyyMMdd");
    }
}