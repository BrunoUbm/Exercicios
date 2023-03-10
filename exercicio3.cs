using System;
using System.Collections.Generic;

public class Exerc3
{
    public static void Main()
    {
        string entrada = "maca,banana,limao,abacaxi,banana";
        List<String> fruits = new List<string>(entrada.Split(','));
        
        for (int i = 0; i < fruits.Count; i++)
        {
            string PrimeiraLetra = fruits[i].Substring(0, 1);
            string Restante = fruits[i].Substring(1);
            fruits[i] = PrimeiraLetra.ToUpper() + Restante;
        }
        
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
