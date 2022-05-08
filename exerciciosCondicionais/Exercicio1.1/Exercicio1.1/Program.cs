/*
1 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da 
altura lidos pelo teclado: Área do triangulo = (base * altura) / 2; 
Teste se a base ou a altura digitada não foi igual a zero. 
*/

double area, b, h;

Console.WriteLine("Informe um valor para a base do triângulo:");
b = double.Parse(Console.ReadLine());

Console.WriteLine("Informe um valor para a base do triângulo:");
h = double.Parse(Console.ReadLine());

if (b > 0 & h > 0)
{
    area = b * h / 2.0;
    Console.WriteLine("A área do triângulo é igual a " + area + ".");
}
else
{
    Console.WriteLine("Informe valores válidos para obter o resultado da área do triângulo, ou seja,\n" +
        " valores positivos e diferentes de zero.");
}