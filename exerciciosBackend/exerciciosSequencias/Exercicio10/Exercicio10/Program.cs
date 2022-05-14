/*
10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
notas de menor valor fossem distribuídas em número mínimo possível. 

Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de 
R$ 50,00, três notas de R$ 10,00, uma nota de R$ 5,00 e uma nota de R$ 2,00. 

Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
de acordo com o critério da “distribuição ótima”.
*/

int notas, divisao, resto;
    
Console.WriteLine("Bem-vindo(a) ao Banco Grana Curta!");
Console.WriteLine();
Console.WriteLine("Atenção! o limite de saque diário é de R$1000,00 e as notas disponíveis no caixa são:" +
    " \nR$5,00\nR$10,00\nR$20,00\nR$50,00\nR$100,00\nR$200,00");
Console.WriteLine();
Console.Write("Informe o valor que deseja sacar: ");
Console.WriteLine();

int valorsaque = int.Parse(Console.ReadLine());

if (valorsaque <= 1000 & valorsaque % 5 == 0)
{
    notas = 200;
    divisao = valorsaque / notas;
    
    Console.WriteLine("Quantidade de notas de R$200,00 sacadas: " + divisao + " notas.");
    resto = valorsaque % notas;

    notas = 100;
    divisao = resto / notas;
    Console.WriteLine();
    Console.WriteLine("Quantidade de notas de R$100,00 sacadas: " + divisao + " notas.");
    resto = valorsaque % notas;

    notas = 50;
    divisao = resto / notas;
    Console.WriteLine();
    Console.WriteLine("Quantidade de notas de R$50,00 sacadas: " + divisao + " notas.");
    resto = valorsaque % notas;

    notas = 20;
    divisao = resto / notas;
    Console.WriteLine();
    Console.WriteLine("Quantidade de notas de R$20,00 sacadas: " + divisao + " notas.");
    resto = valorsaque % notas;

    notas = 10;
    divisao = resto / notas;
    Console.WriteLine();
    Console.WriteLine("Quantidade de notas de R$10,00 sacadas: " + divisao + " notas.");
    resto = valorsaque % notas;

    notas = 5;
    divisao = resto / notas;
    Console.WriteLine();
    Console.WriteLine("Quantidade de notas de R$5,00 sacadas: " + divisao + " notas.");
    resto = valorsaque % notas;
}
else
{
    Console.WriteLine();
    Console.WriteLine("Não é possível efetuar o saque do valor informado.\n" +
        "caso deseje informar outro valor retorne à tela anterior!");
}
Console.WriteLine();
Console.WriteLine("Agradecemos à preferência!");

/*
Resolução e Explicação do Professor ALEXANDRE:

/// <summary>
/// armazena a quantidade de notas de 200
/// </summary>
int quantidadeNotas200;

/// <summary>
/// armazena a quantidade de notas de 100
/// </summary>
int quantidadeNotas100;

/// <summary>
/// armazena a quantidade de notas de 50
/// </summary>
int quantidadeNotas50;

/// <summary>
/// armazena a quantidade de notas de 20
/// </summary>
int quantidadeNotas20;

/// <summary>
/// armazena a quantidade de notas de 10
/// </summary>
int quantidadeNotas10;


/// <summary>
/// armazena a quantidade de notas de 5
/// </summary>
int quantidadeNotas5;

/// <summary>
/// variável recebida do usuário para o valor do saque
/// </summary>
int valorSaque;

/// <summary>
/// armazena a sobra da divisão de uma nota
/// </summary>
int sobra;

Console.Write("Quanto deseja sacar? [Notas: 5, 10, 20, 50, 100 e 200]: ");
valorSaque = int.Parse(Console.ReadLine());

quantidadeNotas200 = (int)valorSaque / 200;
sobra = (int)valorSaque % 200;

quantidadeNotas100 = (int)sobra / 100;
sobra = (int)sobra % 100;

quantidadeNotas50 = (int)sobra / 50;
sobra = (int)sobra % 50;

quantidadeNotas20 = (int)sobra / 20;
sobra = (int)sobra % 20;

quantidadeNotas10 = (int)sobra / 10;
sobra = (int)sobra % 10;

quantidadeNotas5 = (int)sobra / 5;
sobra = (int)sobra % 5;


if (sobra != 0)
{
    Console.WriteLine("Saque não impossibilitado [Notas: 5, 10, 20, 50, 100 e 200]");
}
else
{
    Console.WriteLine("Quantidade de notas de 200: " + quantidadeNotas200);
    Console.WriteLine("Quantidade de notas de 100: " + quantidadeNotas100);
    Console.WriteLine("Quantidade de notas de 50: " + quantidadeNotas50);
    Console.WriteLine("Quantidade de notas de 20: " + quantidadeNotas20);
    Console.WriteLine("Quantidade de notas de 10: " + quantidadeNotas10);
    Console.WriteLine("Quantidade de notas de 5: " + quantidadeNotas5);
}
*/