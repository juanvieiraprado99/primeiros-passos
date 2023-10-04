internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 7 - Condicionais");

        int idadeJuan = 16;
        int quantidadePessoas = 2;

        if (idadeJuan >= 18)
        {
            Console.WriteLine("Pode Entrar!");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Ele está acompanhado, pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }
        }

        Console.WriteLine("Tecle Enter para fechar");
        Console.ReadLine();
    }
}