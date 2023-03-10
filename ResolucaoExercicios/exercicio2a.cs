using System;
using System.Collections.Generic;

class Program2
{
    static void Main (string[] args)
    {
        string[] convidados = { };
        while (convidados.Length < 5)
        {
            Console.WriteLine("Adicione um convidado: ");
            string convidado = Console.ReadLine();
            Array.Resize(ref convidados, convidados.Length + 1);
            convidados[convidados.Length -1] = convidado;
        }
        if (convidados.Length == 5)
        {
            Console.WriteLine("\nOs convidados selecionados foram: ");
            for (int i = 0; i < convidados.Length; i++)
            {
                Console.WriteLine(convidados[i]);
            }
        }
    }
}