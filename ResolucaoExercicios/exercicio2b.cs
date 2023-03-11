using System;
using System.Collections.Generic;

class Program3
{
    static void Main (string[] args)
    {
        List<string> guestsList = new List<string>();
        while (guestsList.Count < 5)
        {
            Console.WriteLine("Adicione um convidado: ");
            string guestName = Console.ReadLine();
            guestsList.Add(guestName);
        }
        if (guestsList.Count == 5)
        {
            Console.WriteLine("\nOs convidados selecionados foram: ");
            foreach (string guest in guestsList)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
