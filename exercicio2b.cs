using System;
using System.Collections.Generic;

void list ()
{
    List<String> convidados = new List<string>();
    while (convidados.Count < 5)
    {
        Console.WriteLine("Adicione um convidado: ");
        string convidado = Console.ReadLine();
        convidados.Add(convidado);
    }
    if (convidados.Count == 5)
    {
        Console.WriteLine("\nOs convidados selecionados foram: ");
        for (int i = 0; i < convidados.Count; i++)
        {
            Console.WriteLine(convidados[i]);
        }
    }
}
list();