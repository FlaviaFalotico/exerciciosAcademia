/*
18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
elevada a um expoente qualquer, ou seja, NM.

*/
double valor1, valor2, potencia;
string pergunta = "";
do
{
    Console.Clear();
    Console.WriteLine("Vamos calcular a enésima potência de um número?");
    Console.WriteLine();
    Console.Write("Informe um valor para a base: ");
    valor1 = double.Parse(Console.ReadLine());

    Console.Write("Informe um valor para o expoente: ");
    valor2 = double.Parse(Console.ReadLine());

    potencia = Math.Pow(valor1, valor2);
    Console.WriteLine();
    Console.WriteLine($"{valor1}^{valor2} = {potencia:F2}");

    Console.WriteLine();
    Console.WriteLine("Deseja repetir a operação (S/N)?");
    pergunta = Console.ReadLine().ToUpper();
    if (pergunta == "S")
    {
        continue;
    }
    else if (pergunta == "N")
    {
        break;
    }
    else
    {
        Console.WriteLine("Opção inválida!");
        Console.WriteLine("Aperte qualquer tecla para tentar novamente.");
    }
    Console.ReadKey();
} while (true);