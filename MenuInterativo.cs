
string opcao;
bool exibirMenu = false;

while (true)
{
    Console.WriteLine("Digite sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1": 
        Console.WriteLine("Cadastro de cliente");
        break;

        case "2": 
        Console.WriteLine("Busca de cliente");
        break;

        case "3":
        Console.WriteLine("Apagar cliente");
        break;

        case "4":
        Console.WriteLine("Encerrar");
        exibirMenu = false;
        // Environment.Exit(0);
        break;

        default:
        Console.WriteLine("Opção inválida");
        break;
    }
}

Console.WriteLine("Encerrado o programa");
