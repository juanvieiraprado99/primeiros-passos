internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 8 - Condicionais 2");

        int idadeJuan = 16;
        int quantidadePessoas = 2;

        bool acompanahado = quantidadePessoas > 1;

        string textoAdicional;

        if (acompanahado == true)
        {
            textoAdicional = "João está acompanhado";
        } 
        else
        {
            textoAdicional = "João não está acompanhado";
        }

        if (idadeJuan >= 18 && acompanahado)
        {
            Console.WriteLine("Pode Entrar!");
            Console.WriteLine(textoAdicional);

        }
        else
        {
            Console.WriteLine("Não pode entrar!");
            Console.WriteLine(textoAdicional);
        }

        Console.WriteLine("Tecle Enter para fechar");
        Console.ReadLine();
    }
}