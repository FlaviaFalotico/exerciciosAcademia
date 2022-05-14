/*
10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).

O programa deve mostrar os dados do atleta mais novo e mais alto.
*/

string nomeAtleta1, nomeAtleta2;
int idadeAtleta1 = 0, idadeAtleta2 = 0;
float alturaAtleta1 = 0, alturaAtleta2 = 0;

Console.Write("Iforme o nome do primeiro atleta: ");
nomeAtleta1 = Console.ReadLine();
Console.Write("Iforme a sua idade: ");
idadeAtleta1 = int.Parse(Console.ReadLine());
Console.Write("Iforme a sua altura: ");
alturaAtleta1 = float.Parse(Console.ReadLine());

Console.WriteLine();
Console.Write("Iforme o nome do segundo atleta: ");
nomeAtleta2 = Console.ReadLine();
Console.Write("Iforme a a sua idade: ");
idadeAtleta2 = int.Parse(Console.ReadLine());
Console.Write("Iforme a sua altura: ");
alturaAtleta2 = float.Parse(Console.ReadLine());
/*
if (alturaAtleta1 > alturaAtleta2)
{
    Console.WriteLine();
    Console.WriteLine("O atleta mais alto é: " + nomeAtleta1 + ".");
}
else if (alturaAtleta1 == alturaAtleta2)
{
    Console.WriteLine();
    Console.WriteLine("Ambos, " + nomeAtleta1 + " e " + nomeAtleta2 +  ", possuem a mesma altura.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("O atleta mais alto é o: " + nomeAtleta2 + ".");
}
if (idadeAtleta1 < idadeAtleta2)
{
    Console.WriteLine();
    Console.WriteLine("O atleta mais novo é: " + nomeAtleta1 + ".");
}
else if (idadeAtleta1 == idadeAtleta2)
{
    Console.WriteLine();
    Console.WriteLine("Ambos, " + nomeAtleta1 + " e " + nomeAtleta2 + ", possuem a mesma idade.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("O atleta mais novo é o: " + nomeAtleta2 + ".");
}
*/

if ((alturaAtleta1 > alturaAtleta2) && (idadeAtleta1 < idadeAtleta2))
{
    Console.WriteLine();
    Console.WriteLine("O atelta: " + nomeAtleta1 + " é mais novo e mais alto.");
}
else if ((alturaAtleta1 < alturaAtleta2) && (idadeAtleta1 > idadeAtleta2))
{
    Console.WriteLine();
    Console.WriteLine("O atelta: " + nomeAtleta2 + " é mais novo e mais alto.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Não há atleta mais novo e mais alto ao mesmo tempo.");
}