/*
15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem 
dizendo se ele está aprovado ou reprovado, após ter calculado sua média ponderando, 
considerando pesos 2, 1, 2, e 4, respectivamente. 

Considerar nota 7,0 como mínima para aprovação.
*/

//Cálculo realizado sem a necessidade de repetição:

Console.Write("Digite as quatro notas do aluno: ");
string[] notas = Console.ReadLine().Split(' ');
double nota1 = double.Parse(notas[0]);
double nota2 = double.Parse(notas[1]);
double nota3 = double.Parse(notas[2]);
double nota4 = double.Parse(notas[3]);

double media = (nota1 * 2.0 + nota2 * 1.0 + nota3 * 2.0 + nota4 * 4.0) / 9.0;
Console.WriteLine();
Console.WriteLine($"A média do(a) aluno(a) é de: {media:F1}");
if (media >= 7.0)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}

//Cálculo utilizando repetições para a validação das informações digitadas pelo usuário:
double nota1 = 0.0;
do
{
    Console.Clear();
    Console.Write("Digite a primeira nota: ");
    nota1 = double.Parse(Console.ReadLine());
    if (nota1 < 0.0 || nota1 > 10.0)
    {
        Console.WriteLine("Nota informada inválida! Digite valores entre 0,0 e 10,0, incluindo os próprios.");
        Console.WriteLine();
    }
    else
    {
        nota1 = nota1 * 2.0;
        break;
    }
    Console.ReadKey();
} while (nota1 < 0.0 || nota1 > 10.0);

double nota2 = 0.0;
do
{
    Console.Clear();
    Console.Write("Digite a segunda nota: ");
    nota2 = double.Parse(Console.ReadLine());
    if (nota2 < 0.0 || nota2 > 10.0)
    {
        Console.WriteLine("Nota informada inválida! Digite valores entre 0,0 e 10,0, incluindo os próprios.");
        Console.WriteLine();
    }
    else
    {
        nota2 = nota2 * 1.0;
        break;
    }
    Console.ReadKey();
} while (nota2 < 0.0 || nota2 > 10.0);

double nota3 = 0.0;
do
{
    Console.Clear();
    Console.Write("Digite a terceira nota: ");
    nota3 = double.Parse(Console.ReadLine());
    if (nota3 < 0.0 || nota3 > 10.0)
    {
        Console.WriteLine("Nota informada inválida! Digite valores entre 0,0 e 10,0, incluindo os próprios.");
        Console.WriteLine();
    }
    else
    {
        nota3 = nota3 * 2.0;
        break;
    }
    Console.ReadKey();
} while (nota3 < 0.0 || nota3 > 10.0);

double nota4 = 0.0;
do
{
    Console.Clear();
    Console.Write("Digite a quarta nota: ");
    nota4 = double.Parse(Console.ReadLine());
    if (nota4 < 0.0 || nota4 > 10.0)
    {
        Console.WriteLine("Nota informada inválida! Digite valores entre 0,0 e 10,0, incluindo os próprios.");
        Console.WriteLine();
    }
    else
    {
        nota4 = nota4 * 4.0;
        break;
    }
    Console.ReadKey();
} while (nota4 < 0.0 || nota4 > 10.0);

Console.Clear();
double media = (nota1 + nota2 + nota3 + nota4) / 9.0;
Console.WriteLine($"A média das notas é de {media:F1} pontos.");
Console.WriteLine();
if (media < 7.0)
{
    Console.WriteLine("Aluno reprovado!");
}
else
{
    Console.WriteLine("Aluno aprovado!");
}