internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 8 - Condicionais 2");

        int idadeJuan = 16;
        int quantidadePessoas = 2;

        bool acompanahado = quantidadePessoas > 1;
        bool grupo = true;

        if (idadeJuan >= 18 && acompanahado)
        {
            Console.WriteLine("Pode Entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }

        if (idadeJuan >= 18 || acompanahado)
        {
            Console.WriteLine("Pode Entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }

        Console.WriteLine("Tecle Enter para fechar");
        Console.ReadLine();
    }
}