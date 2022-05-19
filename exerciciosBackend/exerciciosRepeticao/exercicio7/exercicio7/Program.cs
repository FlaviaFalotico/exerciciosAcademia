﻿/*
7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
A cada solicitação, teste se o usuário informou um valor válido.

Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
informe que ele está incorreto e saia do programa em VS.

Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
informe que está errada e saia. Se estiver correta, solicite o salário.

Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
Se estiver correto, mostre todos os valores lidos.
*/

string nome = "";
int idade = 0;
double salario = 0.0;

while (nome == "" || nome.All(char.IsNumber))
{
    Console.Clear();
    Console.Write("Digite o seu nome: ");
    nome = Console.ReadLine();
    if (nome == "" || nome.All(char.IsNumber) == true)
    {
        Console.WriteLine("Nome informado inválido!");
        
    }
    else
    {
        break;
    }
    
    Console.ReadKey();
}
while (idade <= 0)
{
    Console.Clear();
    Console.Write("Digite uma idade: ");
    idade = int.Parse(Console.ReadLine());

    if (idade <= 0)
    {
        Console.WriteLine("Idade informada inválida!");
        
    }
    else
    {
        break;

    }
    Console.ReadKey();
}
while (salario <=0)
{
    Console.Clear();
    Console.Write("Digite o salario: ");
    salario = double.Parse(Console.ReadLine());

    if (salario <= 0.0)
    {
        Console.WriteLine("Salário informado inválido!");     
    }
    else
    {
        break;
    }
    Console.ReadKey();
}
Console.Clear();
Console.WriteLine("----------------------------------------------------");
Console.WriteLine($"Nome: {nome}.\nIdade: {idade} anos.\nSalário: R${salario.ToString("F2")}.");
Console.WriteLine("----------------------------------------------------");