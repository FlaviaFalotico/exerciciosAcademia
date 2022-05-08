/*
9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando 
a medição diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente 
o seguinte:

Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia

Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
150, avisá-lo que será necessário adicionar 2 unidades de insulina.
*/

int media,glicemia1, glicemia2, glicemia3;

Console.Write("Informe o de glicemia, pela manhã, em jejum: ");
glicemia1 = int.Parse(Console.ReadLine());

Console.Write("Informe o valor de glicemia à tarde: ");
glicemia2 = int.Parse(Console.ReadLine());

Console.Write("Informe o valor de glicemia à noite: ");
glicemia3 = int.Parse(Console.ReadLine());

media = (glicemia1 + glicemia2 + glicemia3) / 3;

if (glicemia1 < 65)
{
    Console.WriteLine();
    Console.WriteLine("Atenção! Para o primeiro valor de glicemia informado: " + glicemia1 + ", risco de hipoglicemia.");
}
else if (glicemia1 > 250)
{
    Console.WriteLine();
    Console.WriteLine("Atenção! Para o primeiro valor de glicemia informado: " + glicemia1 + ", risco de hiperglicemia.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Para o primeiro valor de glicemia informado: " + glicemia1 + ", valor dentro da normalidade.");
}

if (glicemia2 < 65)
{
    Console.WriteLine("Atenção! Para o segundo valor de glicemia informado: " + glicemia2 + ", risco de hipoglicemia.");
}
else if (glicemia2 > 250)
{
    Console.WriteLine("Atenção! Para o segundo valor de glicemia informado: " + glicemia2 + ", risco de hiperglicemia.");
}
else
{
    Console.WriteLine("Para o segundo valor de glicemia informado: " + glicemia2 + ", valor dentro da normalidade.");
}

if (glicemia3 < 65)
{
    Console.WriteLine("Atenção! Para o terceiro valor de glicemia informado: " + glicemia3 + ", risco de hipoglicemia.");
}
else if (glicemia3 > 250)
{
    Console.WriteLine("Atenção! Para o terceiro valor de glicemia informado: " + glicemia3 + ", risco de hiperglicemia.");
}
else
{
    Console.WriteLine("Para o terceiro valor de glicemia informado: " + glicemia3 + ", valor dentro da normalidade.");
}
if (media < 80)
{
    Console.WriteLine();
    Console.WriteLine("Como a média dos três valores de glicemia resultou em: " + media + " é necessário diminuir 2 unidades de insulina.");
}
else if (media > 150)
{
    Console.WriteLine();
    Console.WriteLine("Como a média dos três valores de glicemia resultou em: " + media + " é necessário adicionar 2 unidades de insulina.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Como a média dos três valores de glicemia resultou em: " + media + " a dosagem de insulina pode ser mantida.");
}