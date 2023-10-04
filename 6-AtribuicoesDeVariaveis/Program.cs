internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 6 - Atribuições de variaveis");

        int idade = 30;
        int idadeAna = idade;

        // Aqui via imprimir 30 pois está mostrando antes de atribuir 25 a variavel idade
        Console.WriteLine(idadeAna);

        idade = 25;

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}