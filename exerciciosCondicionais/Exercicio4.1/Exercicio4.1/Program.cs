/*
4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor 
por hora recebido por cada um deles. Mostrar na tela qual dos professores tem o maior salário total.
*/

double horaAula1, horaAula2, valor1, valor2, salario1, salario2;

Console.WriteLine("Informe o número de horas aula do primeiro Professor:");
horaAula1 = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor da hora aula do primeiro Professor:");
valor1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o número de horas aula do segundo Professor:");
horaAula2 = double.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor da hora aula do segundo Professor:");
valor2 = double.Parse(Console.ReadLine());

salario1 = horaAula1 * valor1;
salario2 = horaAula2 * valor2;

Console.WriteLine();
Console.WriteLine("O salário do primeiro Professor é igual a: R$" + salario1);
Console.WriteLine("O salário do segundo Professor é igual a: R$" + salario2);

if (salario1 > salario2)
{
    Console.WriteLine();
    Console.WriteLine("O primeiro Professor recebe o maior salário.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("O segundo Professor recebe o maior salário.");
}