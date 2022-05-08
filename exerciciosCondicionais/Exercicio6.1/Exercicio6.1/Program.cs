/*
6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) 
e o peso (kg) de uma pessoa.

O programa deve calcular o Indice de Massa Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.

O cálculo do imc = peso / (altura * altura)

IMC 

menor que 18                    -> baixo peso
maior que 18 e menor que 25     -> peso normal
maior que 25 e menor que 30     -> sobrepeso
maior que 30 e menor que 35     -> obesidade
maior que 35                    -> obesidade grau sério
*/

string nome, nomeMaíusculo;
double altura, peso, imc;

Console.Write("Informe o seu nome: ");
nome = Console.ReadLine();

nomeMaíusculo = nome.ToUpper();

Console.Write("Informe o seu peso: ");
peso = double.Parse(Console.ReadLine());

Console.Write("Informe a sua altura: ");
altura = double.Parse(Console.ReadLine());

imc = peso / (altura * altura);

if (imc < 18)
{
    Console.WriteLine();
    Console.WriteLine("Você digitou:");
    Console.WriteLine();
    Console.WriteLine("Nome: " + nomeMaíusculo + ".");
    Console.WriteLine("Peso: " + peso.ToString("F2") + "kg.");
    Console.WriteLine("Altura: " + altura.ToString("F2") + ".");
    Console.WriteLine();
    Console.WriteLine("Seu IMC é: " + imc.ToString("F2") + ".");
    Console.WriteLine("Classificação: Baixo peso.");
}
else if (imc > 18 && imc < 25)
{
    Console.WriteLine();
    Console.WriteLine("Você digitou:");
    Console.WriteLine();
    Console.WriteLine("Nome: " + nomeMaíusculo + ".");
    Console.WriteLine("Peso: " + peso.ToString("F2") + "kg.");
    Console.WriteLine("Altura: " + altura.ToString("F2") + ".");
    Console.WriteLine();
    Console.WriteLine("Seu IMC é: " + imc.ToString("F0") + ".");
    Console.WriteLine("Classificação: Peso normal.");
}
else if (imc > 25 && imc < 30)
{
    Console.WriteLine();
    Console.WriteLine("Você digitou:");
    Console.WriteLine();
    Console.WriteLine("Nome: " + nomeMaíusculo + ".");
    Console.WriteLine("Peso: " + peso.ToString("F2") + "kg.");
    Console.WriteLine("Altura: " + altura.ToString("F2") + ".");
    Console.WriteLine();
    Console.WriteLine("Seu IMC é: " + imc.ToString("F0") + ".");
    Console.WriteLine("Classificação: Sobrepeso.");
}
else if (imc > 30 && imc < 35)
{
    Console.WriteLine();
    Console.WriteLine("Você digitou:");
    Console.WriteLine();
    Console.WriteLine("Nome: " + nomeMaíusculo + ".");
    Console.WriteLine("Peso: " + peso.ToString("F2") + "kg.");
    Console.WriteLine("Altura: " + altura.ToString("F2") + ".");
    Console.WriteLine();
    Console.WriteLine("Seu IMC é: " + imc.ToString("F0") + ".");
    Console.WriteLine("Classificação: Obesidade.");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Você digitou:");
    Console.WriteLine();
    Console.WriteLine("Nome: " + nomeMaíusculo + ".");
    Console.WriteLine("Peso: " + peso.ToString("F2") + "kg.");
    Console.WriteLine("Altura: " + altura.ToString("F2") + ".");
    Console.WriteLine();
    Console.WriteLine("Seu IMC é: " + imc.ToString("F0") + ".");
    Console.WriteLine("Classificação: Obesidade grau sério.");
}