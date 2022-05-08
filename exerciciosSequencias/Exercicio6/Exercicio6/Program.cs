/*
6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A
e para o parafuso B, isto é, o código, a quantidade de peças e o valor unitário de
cada parafuso e a porcentagem de IPI (única) a ser acrescentada.
*/

string resposta, A, B;
int imposto, codigoA, codigoB, pecasA, pecasB, quantidadeA, quantidadeB;
double valorUnitarioA, valorUnitarioB, valorCompraA=0, valorCompraB=0;

A = "A";
B = "B";
imposto = 10;
codigoA = 202201807;
codigoB = 202201906;
pecasA = 1000;
pecasB = 3500;
valorUnitarioA = 5.00;
valorUnitarioB = 7.00;

Console.WriteLine("Olá cliente, seja muito bem-vindo(a) à loja Rebinboca da Parafuseta!");

Console.WriteLine();
Console.WriteLine("Para informar qual dos tipos de parafuso disponíveis, A ou B, você gostaria\n" +
    "de receber as informações e orçamento, escolha uma das opções abaixo: ");
Console.WriteLine();
Console.WriteLine("A - Parafuso do tipo A.");
Console.WriteLine("B - Parafuso do tipo B.");
Console.WriteLine();
resposta = Console.ReadLine();

Console.WriteLine();

if (resposta == A)
{
    Console.WriteLine("O código do parafuso A é: " + codigoA + ".");
    Console.WriteLine("A quantidade de peças do parafuso A no estoque é de: " + pecasA + " peças.");
    Console.WriteLine("O valor unitário do parafuso A é de: R$" + valorUnitarioA.ToString("F2") + ".");
    Console.WriteLine("A porcentagem de IPI a ser acrescentada é de: " + imposto + "% sobre o valor unitário.");

    Console.WriteLine();
    Console.Write("Informe a quantidade de parafusos do tipo A que deseja adquirir: ");
    quantidadeA = int.Parse(Console.ReadLine());

    if (quantidadeA <= pecasA)
    {
        valorCompraA = quantidadeA * (5.0 * 1.1);
        Console.WriteLine();
        Console.WriteLine("Valor do orçamento: R$" + valorCompraA.ToString("F2") + ".");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Infelizmente a quantidade de peças não está disponível no estoque.");
    }  
}
else if (resposta == B)
{
    Console.WriteLine("O código do parafuso B é: " + codigoB + ".");
    Console.WriteLine("A quantidade de peças do parafuso B no estoque é de: " + pecasB + " peças.");
    Console.WriteLine("O valor unitário do parafuso B é de: R$" + valorUnitarioB.ToString("F2") + ".");
    Console.WriteLine("A porcentagem de IPI a ser acrescentada é de: " + imposto + "% sobre o valor unitário.");

    Console.WriteLine();
    Console.Write("Informe a quantidade de parafusos do tipo B que deseja adquirir: ");
    quantidadeB = int.Parse(Console.ReadLine());

    if (quantidadeB <= pecasB)
    {
        valorCompraB = quantidadeB * (7.0 * 1.1);
        Console.WriteLine();
        Console.WriteLine("Valor do orçamento: R$" + valorCompraB.ToString("F2") + ".");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Infelizmente a quantidade de peças não está disponível no estoque.");
    }
}
else
{
    Console.WriteLine("Por gentileza, informe um dos tipos de parafusos disponíveis, A ou B, para obter as informações necessárias.");
};

Console.WriteLine();
Console.WriteLine("Agradecemos a sua preferência!");