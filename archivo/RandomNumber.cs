﻿using System;

public class RandomNumber
{
    public static long Generar()
    {
        Random random = new Random();
        long numeroAleatorio = (long)(random.NextDouble() * 900000000000) + 100000000000;
        return numeroAleatorio;
    }
}