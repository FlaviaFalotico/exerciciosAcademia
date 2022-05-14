/*
8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.

Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.

Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.

E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
total de vendas. 
*/

int codigo;
string nome;
double salarioBase, vendasFuncionario, salarioFinal, bonus;

Console.Write("Informe o nome do funcionário: ");
nome = Console.ReadLine();

Console.Write("Informe o código do funcionário: ");
codigo = int.Parse(Console.ReadLine());

Console.Write("Informe o valor do salário base: ");
salarioBase = double.Parse(Console.ReadLine());

Console.Write("Informe o valor total das vendas do funcionário: ");
vendasFuncionario = double.Parse(Console.ReadLine());

if (vendasFuncionario > 500 && vendasFuncionario <= 1000)
{
    salarioFinal = salarioBase * 1.05;

    Console.WriteLine();
    Console.WriteLine("O valor do salário final do funcionário, acrescido de 5% é de R$" + salarioFinal.ToString("F2") + ".");
}
else if (vendasFuncionario > 1000 && vendasFuncionario <= 5000)
{
    salarioFinal = salarioBase * 1.07;

    Console.WriteLine();
    Console.WriteLine("O valor do salário final do funcionário, acrescido de 7% é de R$" + salarioFinal.ToString("F2") + ".");
}
else if (vendasFuncionario > 5000)
{
    salarioFinal = salarioBase * 1.10;

    Console.WriteLine();
    Console.WriteLine("O valor do salário final do funcionário, acrescido de 10% é de R$" + salarioFinal.ToString("F2") + ".");
}
else
{
    Console.WriteLine();
    Console.WriteLine("O salário do funcionário é de R$" + salarioBase + ".");
    Console.WriteLine("Desculpe, para o valor de vendas informado não há bônus acrescido ao salário final.");
}