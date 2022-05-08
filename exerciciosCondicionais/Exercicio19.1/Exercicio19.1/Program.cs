/*
19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.

Interpretação do Exercício

a-) Se tivermos o valor1 como o menor dos três valores, teremos as seguintas possibilidades:

valor1  valor2  valor3
valor1  valor3  valor2

b-) Se tivermos o valor2 como o menor dos três valores, teremos as seguintas possibilidades:

valor2  valor1  valor3
valor2  valor3  valor1

c-) Se tivermos o valor3 como o menor dos três valores, teremos as seguintas possibilidades:

valor3  valor1  valor2
valor3  valor2  valor1

Assim:

((valor1 < valor2) && (valor2 < valor3))
((valor1 < valor3) && (valor3 < valor2))
((valor2 < valor1) && (valor1 < valor3))
((valor2 < valor3) && (valor3 < valor1))
((valor3 < valor1) && (valor1 < valor2))
((valor3 < valor2) && (valor2 < valor1))
*/

int valor1 =0, valor2=0, valor3=0;

Console.Write("Informe o primeiro valor inteiro: ");
valor1 = int.Parse(Console.ReadLine());
Console.Write("Informe um segundo valor inteiro: ");
valor2 = int.Parse(Console.ReadLine());
Console.Write("Informe um terceiro valor inteiro: ");
valor3 = int.Parse(Console.ReadLine());

if ((valor1 < valor2) && (valor2 < valor3))
{
    Console.WriteLine();
    Console.WriteLine("A ordem crescente dos números inteiros é: {" + valor1 + ", " + valor2 + ", " + valor3 + "}.");
}
else if ((valor1 < valor3) && (valor3 < valor2))
{
    Console.WriteLine();
    Console.WriteLine("A ordem crescente dos números inteiros é: {" + valor1 + ", " + valor3 + ", " + valor2 + "}.");
}
else if ((valor2 < valor1) && (valor1 < valor3))
{
    Console.WriteLine();
    Console.WriteLine("A ordem crescente dos números inteiros é: {" + valor2 + ", " + valor1 + ", " + valor3 + "}.");
}
else if ((valor2 < valor3) && (valor3 < valor1))
{
    Console.WriteLine();
    Console.WriteLine("A ordem crescente dos números inteiros é: {" + valor2 + ", " + valor3 + ", " + valor1 + "}.");
}
else if ((valor3 < valor1) && (valor1 < valor2))
{
    Console.WriteLine();
    Console.WriteLine("A ordem crescente dos números inteiros é: {" + valor3 + ", " + valor1 + ", " + valor2 + "}.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("A ordem crescente dos números inteiros é: {" + valor3 + ", " + valor2 + ", " + valor1 + "}.");
}
