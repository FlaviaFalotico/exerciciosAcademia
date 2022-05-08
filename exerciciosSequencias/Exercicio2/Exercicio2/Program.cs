/*
2) Escreva um programa em C# e no Visual Studio para calcular 
a média aritmética entre quatro números quaisquer.
*/

float num1, num2,num3, num4, media;

Console.WriteLine("Digite um numero qualquer: ");
num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite um segundo numero qualquer: ");
num2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite um segundo numero qualquer: ");
num3 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite um segundo numero qualquer: ");
num4 = float.Parse(Console.ReadLine());

media = (num1 + num2 + num3 + num4) / 4;

Console.WriteLine("A média aritmética entre quatros valores " +
    "apresentados: " + num1 + ", " + num2 + ", " + num3 + " e " + num4 + " é de: " + media + ".");