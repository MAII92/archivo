using System;

public class RandomNumber
{
    public static string Tostring { get; internal set; }

    public static long Generar()
    {
        Random random = new Random();
        long numeroAleatorio = (long)(random.NextDouble() * 900000000000) + 100000000000;
        return numeroAleatorio;

        Decimal GenerarDecimal()
        {
            Random rnd = new Random();
            Int32 valorEntero = rnd.Next(1000000, 10000000);
            Decimal valorDecimal = rnd.Next(0, 10000) / 100m;
            Decimal val = new Decimal(valorEntero) + valorDecimal;
            return val;
        }
    }
}