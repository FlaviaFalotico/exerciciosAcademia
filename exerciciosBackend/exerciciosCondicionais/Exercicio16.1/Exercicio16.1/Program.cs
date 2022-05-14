/*
16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil.

Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. 

Caso contrário, mostre uma mensagem indicando que os dois times irão se enfrentar novamente em um novo jogo.

ex1: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou" 

plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.
*/

int timeACasa, timeBFora, timeAFora=0, timeBCasa = 0, penaltiTimeA=0, penaltiTimeB=0, difencaPrimeiroJogo;

Console.Write("Informe o número de gols do time A: ");
timeACasa = int.Parse(Console.ReadLine());
Console.Write("Informe o número de gols do time B: ");
timeBFora = int.Parse(Console.ReadLine());

if ((timeBFora - timeACasa) >= 2)
{
    Console.WriteLine();
    Console.WriteLine("O time B já se classificou.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Os dois times se enfrentarão em um novo jogo.");

    Console.WriteLine();
    Console.Write("Informe o número de gols do time B: ");
    timeBCasa = int.Parse(Console.ReadLine());
    Console.Write("Informe o número de gols do time A: ");
    timeAFora = int.Parse(Console.ReadLine());

    if (timeBCasa > timeAFora)
    {
        Console.WriteLine();
        Console.WriteLine("O time B passou de fase.");
    }
    else if ((timeBCasa == timeAFora) && (timeAFora > timeBFora))
    {
        Console.WriteLine();
        Console.WriteLine("O time A passou de fase.");
    }
    else if ((timeBCasa == timeAFora) && (timeBFora > timeAFora))
    {
        Console.WriteLine();
        Console.WriteLine("O time B passou de fase.");
    }
    else if (timeBCasa == timeAFora)
    {
        Console.WriteLine();
        Console.WriteLine("Como os times A e B empataram, será necessário ir para os\n" +
            "pênaltis, mas lembre-se de que não há empate nessa situação.");
        Console.WriteLine();
        Console.Write("Informe o número de pênaltis do time A: ");
        penaltiTimeA = int.Parse(Console.ReadLine());
        Console.Write("Informe o número de pênaltis do time B: ");
        penaltiTimeB = int.Parse(Console.ReadLine());

        if(penaltiTimeA > penaltiTimeB)
        {
            Console.WriteLine();
            Console.WriteLine("O time A passou de fase.");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("O time B passou de fase.");
        }
    }
    else 
    {
        Console.WriteLine();
        Console.WriteLine("O time A já se classificou.");
    }
}