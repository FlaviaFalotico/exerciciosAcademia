/*
4) Faça um programa em C# e no Visual Studio que receba a data na 
forma "DD/MM/AAAA" e imprima na forma "AAAA/MM/DD" e "AA/MM/DD". 
Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

Dica: É possível utilizar uma string ao invés de inteiro.
*/

//solução convencional
//int dia;
//int mes;
//int ano;

//Console.WriteLine("Informe o dia: ");
//dia = int.Parse(Console.ReadLine());

//Console.WriteLine("Informe o mês: ");
//mes = int.Parse(Console.ReadLine());

//Console.WriteLine("Informe o ano: ");
//ano = int.Parse(Console.ReadLine());

//Console.WriteLine("DD/MM/AAAA: " + dia + "/" + mes + "/" + ano);
//Console.WriteLine("DD/MM/AAAA: " + ano + "/" + mes + "/" + dia);

//Console.WriteLine("AA/MM/DD: " + (ano % 100) + "/" + mes + "/" + dia);

/// <summary>
/// solução não convencional:
/// </summary>
string dia,mes, ano;

Console.WriteLine("Informe o dia: ");
dia = Console.ReadLine();

Console.WriteLine("Informe o mês: ");
mes = Console.ReadLine();

Console.WriteLine("Informe o ano: ");
ano = Console.ReadLine();

Console.WriteLine("DD/MM/AAAA: " + dia + "/" + mes + "/" + ano + ".");
Console.WriteLine("DD/MM/AAAA: " + ano + "/" + mes + "/" + dia + ".");

Console.WriteLine("AA/MM/DD: " + ano[2] + ano[3] + "/" + mes + "/" + dia + ".");