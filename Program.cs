using exfund.Models;

// int numero = 10;

// for (int contador = 0; contador <= 10; contador++)
// {
//    Console.WriteLine($"{numero} x {contador} = {numero * contador}"); 
// }
// int contador = 0;
// while (contador <= 10)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}"); 
//     contador++;

//     if (contador == 5)
//     {
//         break;
//     }
// }


int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um número(0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());
    
    soma += numero;

} while (numero != 0);
Console.WriteLine($"Total da soma dos números é: {soma}");

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

// Console.WriteLine("Digite uma letra:");
// string letra = Console.ReadLine();

// if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else 
// {
//     Console.WriteLine("Não é vogal");
// }

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default: 
//         Console.WriteLine("Não é vogal");
//         break;
// }

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

// Calculadora calc = new Calculadora();

// calc.Somar(15, 30);
// calc.Subtrair(15, 30);
// calc.Multiplicar(15, 30);
// calc.Dividir(15, 30);
// calc.Potencia(3, 4);
// calc.Seno(90);
// calc.Cosseno(90);
// calc.Tangente(90);
// calc.RaizQuadrada(36);

// int num = 10;

// Console.WriteLine(num);

// Console.WriteLine("Incrementando 10");
// num++;
// Console.WriteLine(num);

// int num2 = 50;
// Console.WriteLine("Retrocendendo 50");
// num2--;

// Console.WriteLine(num2);

