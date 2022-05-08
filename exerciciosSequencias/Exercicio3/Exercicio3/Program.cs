/*
3) Escreva a seqüência de atribuições, em forma de programa em C# e no 
Visual Studio, para trocar entre si os valores de duas variáveis A e B.
*/

string frase1, frase2, trocaTroca;

Console.Write("Digite uma frase qualquer: ");
frase1 = Console.ReadLine();
Console.Write("Digite uma segunda frase qualquer: ");
frase2 = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Você digitou: ");
Console.WriteLine("O conteúdo da primeira frase é: " + frase1);
Console.WriteLine("O conteúdo da segunda frase é: " + frase2);

Console.WriteLine();
Console.WriteLine("Processo de Troca das frases: ");

trocaTroca = frase1;
frase1 = frase2;

Console.WriteLine("O conteúdo da primeira frase é: " + frase1);
Console.WriteLine("O conteúdo da segunda frase é: " + trocaTroca);