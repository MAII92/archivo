using System;

public class CerosRellenar
{
    public static string Left(long number, int rellenar)
    {
        string cadena = number.ToString().PadLeft(rellenar, '0');
        return cadena;
    }
    public static string Right(long number, int rellenar)
    {
        string cadena = number.ToString().PadRight(rellenar, '0');
        return cadena;
}   }