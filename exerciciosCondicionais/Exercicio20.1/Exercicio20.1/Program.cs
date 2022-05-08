/*
20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. 

O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 

plus: você pode gerar o número de forma randomica (função random c#).
*/

int palpite1 = 0, palpite2 = 0, palpite3 = 0;

Console.WriteLine("Jogo de advinhação!");
Console.WriteLine();
Console.WriteLine("Você terá três chances de acertar o valor, de 1 a 10, que o computador irá sortear.");
Console.WriteLine();
Console.WriteLine("O jogo começa agora! Não se preocupe, você terá algumas dicas.");

/// <summary>
/// Quando queremos restringir a geração de um número aleatório dentro de um intervalo específico.
/// Para tal, é necessário passar o ntervalo de valores dentro do método Next(), sendo que, devemos acrescentar, 
/// pelo menos, uma unidade no valor máximo para que ele seja incluído.
/// // </summary>
Random numeroAleatorio = new Random();
int valorSorteio = numeroAleatorio.Next(1, 11);

//Console.WriteLine(valorSorteio); Imprimi o valor do número sorteado para testes.

Console.Write("Para aquecer, tente o seu primeiro palpite: ");
palpite1 = int.Parse(Console.ReadLine());

if (palpite1 != valorSorteio)
{ 
    if (palpite1 > valorSorteio)
    {
        Console.WriteLine();
        Console.WriteLine("Foi por pouco! O número sorteado é menor!");
        Console.WriteLine();
        Console.Write("Vamos de novo, faça segundo palpite: ");
        palpite2 = int.Parse(Console.ReadLine());
    }
    else if (palpite1 < valorSorteio)
    {
        Console.WriteLine();
        Console.WriteLine("Foi por pouco! O número sorteado é maior!");
        Console.WriteLine();
        Console.Write("Vamos de novo, faça segundo palpite: ");
        palpite2 = int.Parse(Console.ReadLine());
    }
}
else
{
    Console.WriteLine();
    Console.WriteLine("Parabéns! Acertou de primeira.");
}

if (palpite2 != valorSorteio)
{
    if (palpite2 > valorSorteio)
    {
        Console.WriteLine();
        Console.WriteLine("Foi por pouco! O número sorteado é menor!");
        Console.WriteLine();
        Console.Write("Capriche! Agora é o seu terceiro e último palpite: ");
        palpite3 = int.Parse(Console.ReadLine());
    }
    else if (palpite2 < valorSorteio)
    {
        Console.WriteLine();
        Console.WriteLine("Foi por pouco! O número sorteado é maior!");
        Console.WriteLine();
        Console.Write("Capriche! Agora é o seu terceiro e último palpite: ");
        palpite3 = int.Parse(Console.ReadLine());
    }
}
else
{
    Console.WriteLine();
    Console.WriteLine("Parabéns! É isso mesmo.");
}

if (palpite3 == valorSorteio)
{
    Console.WriteLine();
    Console.WriteLine("Incrível! Eu sabia que você estava escondendo o jogo.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Passou tão perto! Tente novamente.");
}