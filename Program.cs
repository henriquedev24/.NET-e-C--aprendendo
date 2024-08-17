using exfund.Models;

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual);


// string apresentacao = "Iae galera";
// int quantidade = 5;
// double altura = 1.50;

// decimal preco = 1.70M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor de quantidade: " + quantidade);
// Console.WriteLine("Valor da altura: " + altura);
// Console.WriteLine("Valor de double: " + preco);
// Console.WriteLine("Valor de condicao: " + condicao);

Console.WriteLine("Digite uma letra:");
string letra = Console.ReadLine();

// if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else 
// {
//     Console.WriteLine("Não é vogal");
// }

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default: 
        Console.WriteLine("Não é vogal");
        break;
}

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Gabriel";
// pessoa1.Idade = 20;
// pessoa1.Apresentar();

// Cast Casting
// int a = Convert.ToInt32(null);
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

// if (possivelVenda)
// {
//     Console.WriteLine("Venda feita.");
// }
// else
// {
//     Console.WriteLine("Não temos esse tanto no estoque.");
// }

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");