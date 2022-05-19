/*
8. Faça um programa em VS que solicite um numero inteiro. S
e o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
Finalmente, pergunte ao usuário se ele quer repetir o programa em VS. 
*/

int num;
string resposta = "";
do
{
    Console.Clear();
    try
    {
        Console.Write("Insira um número inteiro: ");
        num = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("\nNúmero invalido!");
        Console.WriteLine("Aperte qualquer tecla para informar um valor válido.");
        Console.ReadKey();
        continue;
    }

    if (num % 2 == 0)
    {
        Console.WriteLine($"\n{num} é par!");
    }
    else
    {
        Console.WriteLine($"\n{num} é ímpar!");
    }

    Console.Write("\nDeseja repetir o programa (S/N)? ");
    resposta = Console.ReadLine().ToUpper();
    
    if (resposta == "S")
    {
        continue;
    }
    else if (resposta == "N")
    {
        break;
    }
    else
    {
        Console.WriteLine("\nOpção invalida!");
        Console.Write("\nDeseja repetir o programa (S/N)? ");
        resposta = Console.ReadLine().ToUpper();
    }
    Console.ReadKey();

} while (resposta == "S");