/*"1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética
entre dois números quaisquer.*/

float num1, num2, media;

Console.WriteLine("Digite um numero qualquer: ");
num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite um segundo numero qualquer: ");
num2 = float.Parse(Console.ReadLine());

media = (num1 + num2) / 2;

Console.WriteLine("A média aritmética dos valores " + num1 + " e " + num2 + " é de: " + media + ".");