using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcula Poupança");

        double investimento = 1000;

        // Rendimento de 0.5% ao mês

        //investimento = investimento + investimento * 0.05;
        //Console.WriteLine(investimento);

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine(investimento);
            mes ++;
        }

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}