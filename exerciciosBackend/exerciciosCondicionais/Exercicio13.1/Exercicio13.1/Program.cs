/*
13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa 
no VS que calcule seu peso ideal, utilizando as seguintes fórmulas:

Para homens: (72.7 * h) - 58

Para mulheres: (62.1 * h) - 44.7
*/

string nome,feminino, masculino,resposta;
double h = 0, sexoM, sexoF;

feminino = "A";
masculino = "B";

Console.WriteLine("Escolha a opção de acordo com o seu sexo:");
Console.WriteLine("A - Feminino");
Console.WriteLine("B - Masculino");
resposta = Console.ReadLine();

if (resposta == feminino)
{
    Console.Write("Informe o seu nome: ");
    nome = Console.ReadLine();
    Console.Write("Informe a sua altura: ");
    h = double.Parse(Console.ReadLine());

    sexoF = (62.1 * h) - 44.7;

    Console.WriteLine();
    Console.WriteLine("O peso ideal é: " + sexoF.ToString("F2") + ".");
}
else if (resposta == masculino)
{
    Console.Write("Informe o seu nome: ");
    nome = Console.ReadLine();
    Console.Write("Informe a sua altura: ");
    h = double.Parse(Console.ReadLine());

    sexoM = (72.7 * h) - 58.0;

    Console.WriteLine();
    Console.WriteLine("O peso ideal é: " + sexoM.ToString("F2") + ".");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Escolha uma das opções válidas.");
}

