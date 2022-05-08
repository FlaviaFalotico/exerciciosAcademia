/*
18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.
 */

int valor1, valor2, valor3;

Console.Write("Informe o primeiro valor: ");
valor1 = int.Parse(Console.ReadLine());
Console.Write("Informe um segundo valor: ");
valor2 = int.Parse(Console.ReadLine());
Console.Write("Informe um terceiro valor: ");
valor3 = int.Parse(Console.ReadLine());

if (valor1 > valor2 && valor1 > valor3)
{
    Console.WriteLine();
    Console.WriteLine(valor1 + " é o maior valor.");
}
else if (valor2 > valor1 && valor2 > valor3)
{
    Console.WriteLine();
    Console.WriteLine(valor2 + " é o maior valor.");
}
else
{
    Console.WriteLine();
    Console.WriteLine(valor3 + " é o maior valor.");
}