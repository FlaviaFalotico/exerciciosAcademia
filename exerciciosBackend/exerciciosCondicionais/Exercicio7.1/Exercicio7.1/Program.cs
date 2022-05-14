/*
7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.

O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, 
como por exemplo, A palavra encontra-se na frase ou A palavra não se encontra na frase.
*/

string frase;
string palavraPesquisa;

Console.Write("Digite uma frase: ");
frase = Console.ReadLine();

Console.Write("Digite uma palavra para procurar na frase: ");
palavraPesquisa = Console.ReadLine();

if (frase.Contains(palavraPesquisa) == true)
{
    Console.WriteLine();
    Console.WriteLine("A palvra: " + palavraPesquisa + ", foi encontrada na frase informada.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("A palvra: " + palavraPesquisa + ", não foi encontrada na frase informada.");
}