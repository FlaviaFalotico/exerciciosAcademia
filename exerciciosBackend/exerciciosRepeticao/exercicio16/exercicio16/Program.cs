/*
16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
(N*3; N*3*3; N*3*3*3; etc). 
*/

int i,N, cont = 0;
Console.Write("Digite um número inteiro qualquer menor ou igual a 50: ");
N = int.Parse(Console.ReadLine());

for (i = 0; i <= 250; i++)
{
    cont++;
    i = N * ((int) Math.Pow(3, cont));
    Console.WriteLine($"{N} x 3^{cont} = {i}");
}