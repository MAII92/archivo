using System;
using System.Text;

public class RandomNumber
{
    public static string Tostring { get; internal set; }

    public static long Generar()
    {
        Random random = new Random();
        long numeroAleatorio = (long)(random.NextDouble() * 900000000000) + 100000000000;
        return numeroAleatorio;

    }
    private static bool SumatoriaMayorACero(long numero)
    {
        long sumatoria = 0;

        while (numero > 0)
        {
            sumatoria += numero % 10;
            numero /= 10;
        }

        return sumatoria > 0;
    }
    public static string GenerateNewCode(Int32 codeLength)
    {
        Random random = new Random();
        StringBuilder output = new StringBuilder();

        for (Decimal i = 0; i < codeLength; i++)
        {
            output.Append(random.Next(0, 10));
        }

        return output.ToString();
    }

   public static Decimal GenerarDecimal()
    {
        Random rnd = new Random();
        Int32 valorEntero = rnd.Next(1000000, 10000000);
        Decimal valorDecimal = rnd.Next(0, 10000) / 100m;
        Decimal val = new Decimal(valorEntero) + valorDecimal;
        return val;
   }
}



 