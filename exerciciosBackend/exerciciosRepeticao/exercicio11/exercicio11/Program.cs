/*
11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
a média aritmética da turma e a quantidade de alunos da turma. Usar como flag a nota 12. 
*/

List<float> notasTurma = new List<float>();
float nota;
float notaMaisBaixa;
float notaMaisAlta;
float mediaNotas;
int totalAlunos;

Console.Write("Informe o número de alunos da turma: ");
totalAlunos = int.Parse(Console.ReadLine());

for (int i = 1; i <= totalAlunos; i++)
{
    Console.Clear();
    Console.Write("Informe uma nota de 0 a 10: ");
    nota = float.Parse(Console.ReadLine());

    if (nota >= 0 && nota <= 10)
    {
        notasTurma.Add(nota);
    }
    else
    {
        Console.Write("Nota inválida. Tecle algo para continuar!");
    }
    Console.ReadKey();
}

notasTurma.Sort(); 
notaMaisBaixa = notasTurma[0]; 
notaMaisAlta = notasTurma[notasTurma.Count - 1];

float soma = 0.0f;
for (int i = 0; i < totalAlunos; i++)
{
    soma = soma + notasTurma[i];
}

Console.Clear();
Console.WriteLine("Resultado: ");
Console.WriteLine("-----------------------------------------");
Console.WriteLine($"Total de alunos na turma: {totalAlunos} alunos.");
Console.WriteLine($"Média das notas da turma: {mediaNotas = soma / totalAlunos:F1}.");
Console.WriteLine($"Menor nota da turma: {notaMaisBaixa:F1}.");
Console.WriteLine($"Maior nota da turma: {notaMaisAlta:F1}.");
Console.WriteLine("-----------------------------------------");