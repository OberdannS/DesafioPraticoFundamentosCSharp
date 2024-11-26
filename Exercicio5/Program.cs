namespace Exercicio5;

internal class Program
{
    static void Main(string[] args)
    {
        bool e1, e2, e3, e4, e5, e6, e7;
        Console.WriteLine("Digite a placa do veiculo:");
        char[] placa = Console.ReadLine().ToCharArray();
        if (char.IsLetter(placa[0]))
        {
            e1 = true;
        }
        else
        {
            e1 = false;
        }
        if (char.IsLetter(placa[1]))
        {
            e2 = true;
        }
        else
        {
            e2 = false;
        }
        if (char.IsLetter(placa[2]))
        {
            e3 = true;
        }
        else
        {
            e3 = false;
        }
        if (char.IsNumber(placa[3]))
        {
            e4 = true;
        }
        else
        {
            e4 = false;
        }
        if (char.IsNumber(placa[4]))
        {
            e5 = true;
        }
        else
        {
            e5 = false;
        }
        if (char.IsNumber(placa[5]))
        {
            e6 = true;
        }
        else
        {
            e6 = false;
        }
        if (char.IsNumber(placa[6]))
        {
            e7 = true;
        }
        else
        {
            e7 = false;
        }
        if (e1 && e2 && e3 && e4 && e5 && e6 && e7)
        {
            Console.WriteLine("Placa valida!");
        }
        else
        {
            Console.WriteLine("Placa invalida!");
        }
    }
}