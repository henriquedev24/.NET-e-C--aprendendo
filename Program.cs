using exfund.Models;

DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual);


string apresentacao = "Iae galera";
int quantidade = 5;
double altura = 1.50;

decimal preco = 1.70M;

bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor de quantidade: " + quantidade);
Console.WriteLine("Valor da altura: " + altura);
Console.WriteLine("Valor de double: " + preco);
Console.WriteLine("Valor de condicao: " + condicao);



Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Gabriel";
pessoa1.Idade = 20;
pessoa1.Apresentar();


