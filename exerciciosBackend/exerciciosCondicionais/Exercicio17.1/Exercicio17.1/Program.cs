/*
17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), 
e então diga se esses lados podem ou não formar um triangulo. 

Para que os lados formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados:

a + b < c
a + c < b
b + c < c

Caso os lados formem um triangulo, diga se o mesmo é:

- equilátero (todos os lados iguais)    ex.: 
- isoceles (somente 2 lados são iguais) ex.: 10,10 e 12.
- escaleno (os 3 lados são diferentes). ex.: 5,7 e 8.
*/

int a, b, c;

Console.Write("Informe um valor para o primeiro lado do triângulo: ");
a = int.Parse(Console.ReadLine());
Console.Write("Informe um valor para o segundo lado do triângulo: ");
b = int.Parse(Console.ReadLine());
Console.Write("Informe um valor para o terceiro lado do triângulo: ");
c = int.Parse(Console.ReadLine());

if (a < (b + c) && b < (a + c) && c < (a + b))
{
    if ((a == b) && (b == c))
    {
        Console.WriteLine();
        Console.WriteLine("É possível formar um triângulo do tipo equilátero.");
    }
    else if ((a != b) && (a != c) && (b != c))
    {
        Console.WriteLine();
        Console.WriteLine("É possível formar um triângulo do tipo escaleno.");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("É possível formar um triângulo isóceles.");

    }            
}
else
{
    Console.WriteLine();
    Console.WriteLine("Com os valores informados, " + a + ", " + b + " e " + c + " não é possível formar um triângulo.");
}