namespace Exercicio6;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Formato completo: " + DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss"));
        Console.WriteLine("Data no formato dd/MM/yyyy: " + DateTime.Now.ToString("dd/MM/yyyy"));
        Console.WriteLine("Hora no formato 24 horas: " + DateTime.Now.ToString("HH:mm"));
        Console.WriteLine("Data com mês por extenso: " + DateTime.Now.ToString("dd 'de' MMMM 'de' yyyy"));
    }
}