using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 11 - Calcula Poupança 2");

        double investimento = 1000;

        int mes = 12;

        for (int i = 0; i < mes; i++)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine(investimento);
        }

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}