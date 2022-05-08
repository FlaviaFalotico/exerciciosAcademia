/*
3 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, 
e escrever na tela os que são superiores à média.
*/

int num1, num2, num3, num4, media;

Console.WriteLine("Informe um número:");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe um segundo número:");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe um terceiro número:");
num3 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe um quarto número:");
num4 = int.Parse(Console.ReadLine());

media = (num1 + num2 + num3 + num4) / 4;

Console.WriteLine("A média entre os números: " + num1 + ", " + num2 + ", " + num3 + " e " + num4 + " é igual a " + media);

if (num1 > media)
{
    Console.WriteLine("O número " + num1 + " é maior que o valor da média " + media);
}
if (num2 > media)
{
    Console.WriteLine("O número " + num2 + " é maior que o valor da média " + media);
}
if (num3 > media)
{
    Console.WriteLine("O número " + num3 + " é maior que o valor da média " + media);
}
if (num4 > media)
{
    Console.WriteLine("O número " + num4 + " é maior que o valor da média " + media);
}
else
{
    Console.WriteLine("Nenhum dos números informados é maior do que a média.");
}