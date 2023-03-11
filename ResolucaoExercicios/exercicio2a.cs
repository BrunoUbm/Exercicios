using System;
using System.Collections.Generic;
class Program2
{
    static void Main (string[] args)
    {
        string[] guestsArray = new string[5];
        int count = 0;
        while (count < 5)
        {
            Console.WriteLine("Adicione um convidado: ");
            string guestName = Console.ReadLine();
            guestsArray[count] = guestName;
            count++;
        }
        if (count == 5)
        {
            Console.WriteLine("\nOs convidados selecionados foram: ");
            foreach (string guest in guestsArray)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
