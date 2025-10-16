namespace BackEnd;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao sistema.");

        //Entrada de Dados
        Console.ReadLine("Digite seu nome");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"\n Ola, {nome}! Voce tem {idade} anos");

        if (idade < 18)
            Console.WriteLine("Voce eh menor de idade");
        else
            Console.WriteLine("Voce ja eh maior de idade");

        //switch case
        Console.WriteLine("\n escolha uma opcao: ");
        Console.WriteLine("1 - Ver a tabuada de um numero: ");
        Console.WriteLine("2 - Contar ate um numero");
        Console.WriteLine("3 - Sair");
        Console.WriteLine("Digite a sua opcao");

        int opcao = int.Parse(Console.ReadLine());

    }
}
