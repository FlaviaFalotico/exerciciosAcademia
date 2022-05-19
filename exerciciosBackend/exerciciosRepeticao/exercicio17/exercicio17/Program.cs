/*
17. Apresentar os quadrados dos números inteiros de 15 a 200. 
*/

int cont = 15;
for (int i = 15; i <= 200; i++)
{
    Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}.");
}