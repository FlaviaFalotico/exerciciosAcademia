/*
Escreva uma classe Pessoa contendo todos os atributos de uma pessoa. 
Faça métodos para apresentar os dados.
*/

using exercicio1ClassePessoa;

Pessoa pessoa1;
Pessoa pessoa2;

pessoa1 = new Pessoa();
pessoa2 = new Pessoa();

Console.WriteLine("Dados da primeira pessoa:");
Console.WriteLine("Nome: ");
pessoa1.Nome = Console.ReadLine();
Console.WriteLine("Idade: ");
pessoa1.Idade = int.Parse(Console.ReadLine());
Console.WriteLine("Peso: ");
pessoa1.Peso = double.Parse(Console.ReadLine());
Console.WriteLine("Altura: ");
pessoa1.Altura = double.Parse(Console.ReadLine());

Console.WriteLine("Dados da primeira pessoa:");
Console.WriteLine("Nome: ");
pessoa2.Nome = Console.ReadLine();
Console.WriteLine("Idade: ");
pessoa2.Idade = int.Parse(Console.ReadLine());
Console.WriteLine("Peso: ");
pessoa2.Peso = double.Parse(Console.ReadLine());
Console.WriteLine("Altura: ");
pessoa2.Altura = double.Parse(Console.ReadLine());

pessoa1.exibirDados();
pessoa2.exibirDados();