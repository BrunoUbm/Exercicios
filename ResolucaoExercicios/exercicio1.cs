using System;

public class Exercicio1
{
    static void Main(string[] args)
    {
        int numGuestsGroom = 300;
        int numGuestsBride = 600;
        int numGuestsPresentGroom = 400;
        int numGuestsPresentBride = 400;

        void CheckGuests()
        {
            if (numGuestsBride > numGuestsGroom)
            {
                Console.WriteLine("A Noiva tem mais convidados que o Noivo");
            }
            else if (numGuestsBride < numGuestsGroom)
            {
                Console.WriteLine("O Noivo tem mais convidados que a Noiva");
            }
            else
            {
                Console.WriteLine("Ambos têm a mesma quantidade de convidados");
            }
        }
        CheckGuests();

        void CheckPresentGuests()
        {
            if (numGuestsPresentBride > numGuestsPresentGroom)
            {
                Console.WriteLine("A Noiva tem mais convidados presentes que o Noivo");
            }
            else if (numGuestsPresentBride < numGuestsPresentGroom)
            {
                Console.WriteLine("O Noivo tem mais convidados presentes que a Noiva");
            }
            else
            {
                Console.WriteLine("Ambos têm a mesma quantidade de convidados presentes");
            }
        }
        CheckPresentGuests();
    }
}

