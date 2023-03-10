using System;

public class Program4
{
static void Main(string[] args)
{
    int convidadosNoivo = 300;
    int convidadosNoiva = 600;
    int convidadosPresentesNoivo = 400;
    int convidadosPresentesNoiva = 400;

    void Convidados()
    {
        if (convidadosNoiva > convidadosNoivo)
        {
            Console.WriteLine("A Noiva tem mais convidados que o Noivo");
        }
        else if (convidadosNoiva < convidadosNoivo)
        {
            Console.WriteLine("O Noivo tem mais convidados que a Noiva");
        }
        else
        {
            Console.WriteLine("Ambos tem a mesma quantidade de convidados");
        }
    }
    Convidados();

    void ConvidadosPresentes()
    {
        if (convidadosPresentesNoiva > convidadosPresentesNoivo)
        {
            Console.WriteLine("A Noiva tem mais convidados presentes que o Noivo");
        }
        else if (convidadosPresentesNoiva > convidadosPresentesNoivo)
        {
            Console.WriteLine("O Noivo tem mais convidados presentes que a Noiva");
        }
        else
        {
            Console.WriteLine("Ambos tem a mesma quantidade de convidados presentes");
        }
    }
    ConvidadosPresentes();
}
}