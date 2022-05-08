/*
7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário 
fixo, o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.

Interpretação:

Loja: The Witcher

	  Total 	   % Comissão sobre	  
	de Vendas          as Vendas 	      

< 100                    não há
>= 100 e < 150		   05% = 0.05		     
>= 150 e < 200		   10% = 0.10		      
>= 200 e < 250		   15% = 0.15		      
>= 250 e < 300		   20% = 0.20     
>= 300                 30% = 0.30
 */

int funcionarioA, funcionarioB, funcionarioC, funcionarioD;
int vendasA, vendasB, vendasC, vendasD;
string codigoA, codigoB, codigoC, codigoD;
double salarioFixoA, salarioFixoB, salarioFixoC, salarioFixoD;
double comissaoA, comissaoB, comissaoC, comissaoD;
double salarioTotalA, salarioTotalB, salarioTotalC, salarioTotalD;

funcionarioA = 1;
funcionarioB = 2;
funcionarioC = 3;
funcionarioD = 4;

codigoA = "codf.220456";
codigoB = "codf.220598";
codigoC = "codf.220674";
codigoD = "codf.220737";

salarioFixoA = 2000.00;
salarioFixoB = 2500.00;
salarioFixoC = 3000.00;
salarioFixoD = 4000.00;

Console.WriteLine("Olá, seja muito bem-vindo(a) ao sistema da Loja The Witcher!");

Console.WriteLine();
Console.WriteLine("Para obter informações sobre os seus funcionários, calcular o valor da\n" +
    "comissão do mês e salário final, escolha uma das opções abaixo: ");
Console.WriteLine();
Console.WriteLine("1 - Geralt de Rívia.");
Console.WriteLine("2 - Yennefer de Vengerberg.");
Console.WriteLine("3 - Cirilla Fiona Elen Riannon.");
Console.WriteLine("4 - Jaskier Dandelion.");
Console.WriteLine();
int resposta = int.Parse(Console.ReadLine());

Console.WriteLine();

if (resposta == funcionarioA)
{
    Console.WriteLine("Funcionário Selecionado: Geralt de Rívia.");
    Console.WriteLine();
    Console.WriteLine("O código do funcionário é: " + codigoA + ".");
    Console.WriteLine("O salário fixo mensal do funcionário é de R$: " + salarioFixoA.ToString("F2") + ".");
    Console.Write("Informe o total de vendas do funcionário no mês: ");
    vendasA = int.Parse(Console.ReadLine());

    if (vendasA >=100 && vendasA < 150)
    {
        comissaoA = salarioFixoA * 0.05;
        salarioTotalA = salarioFixoA + comissaoA;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoA.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalA.ToString("F2") + ".");
    }
    else if (vendasA >= 150 && vendasA < 200)
    {
        comissaoA = salarioFixoA * 0.10;
        salarioTotalA = salarioFixoA + comissaoA;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoA.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalA.ToString("F2") + ".");
    }
    else if (vendasA >= 200 && vendasA < 250)
    {
        comissaoA = salarioFixoA * 0.15;
        salarioTotalA = salarioFixoA + comissaoA;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoA.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalA.ToString("F2") + ".");
    }
    else if (vendasA >= 250 && vendasA < 300)
    {
        comissaoA = salarioFixoA * 0.20;
        salarioTotalA = salarioFixoA + comissaoA;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoA.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalA.ToString("F2") + ".");
    }
    else if (vendasA >= 300)
    {
        comissaoA = salarioFixoA * 0.20;
        salarioTotalA = salarioFixoA + comissaoA;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoA.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalA.ToString("F2") + ".");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Para a quantidade de vendas informada não há comissão a ser calculada sobre o salário do funcíonário.");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioFixoA.ToString("F2") + ".");
    }
}
else if (resposta == funcionarioB)
{
    Console.WriteLine("Funcionário Selecionado: Yennefer de Vengerberg.");
    Console.WriteLine();
    Console.WriteLine("O código do funcionário é: " + codigoB + ".");
    Console.WriteLine("O salário fixo mensal do funcionário é de R$: " + salarioFixoB.ToString("F2") + ".");
    Console.Write("Informe o total de vendas do funcionário no mês: ");
    vendasB = int.Parse(Console.ReadLine());

    if (vendasB >= 100 && vendasB < 150)
    {
        comissaoB = salarioFixoB * 0.05;
        salarioTotalB = salarioFixoB + comissaoB;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoB.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalB.ToString("F2") + ".");
    }
    else if (vendasB >= 150 && vendasB < 200)
    {
        comissaoB = salarioFixoB * 0.10;
        salarioTotalB = salarioFixoB + comissaoB;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoB.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalB.ToString("F2") + ".");
    }
    else if (vendasB >= 200 && vendasB < 250)
    {
        comissaoB = salarioFixoB * 0.15;
        salarioTotalB = salarioFixoB + comissaoB;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoB.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalB.ToString("F2") + ".");
    }
    else if (vendasB >= 250 && vendasB < 300)
    {
        comissaoB = salarioFixoB * 0.20;
        salarioTotalB = salarioFixoB + comissaoB;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoB.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalB.ToString("F2") + ".");
    }
    else if (vendasB >= 300)
    {
        comissaoB = salarioFixoB * 0.20;
        salarioTotalB = salarioFixoB + comissaoB;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoB.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalB.ToString("F2") + ".");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Para a quantidade de vendas informada não há comissão a ser calculada sobre o salário do funcíonário.");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioFixoB.ToString("F2") + ".");
    }
}
else if (resposta == funcionarioC)
{
    Console.WriteLine("Funcionário Selecionado: Cirilla Fiona Elen Riannon.");
    Console.WriteLine();
    Console.WriteLine("O código do funcionário é: " + codigoC + ".");
    Console.WriteLine("O salário fixo mensal do funcionário é de R$: " + salarioFixoC.ToString("F2") + ".");
    Console.Write("Informe o total de vendas do funcionário no mês: ");
    vendasC = int.Parse(Console.ReadLine());

    if (vendasC >= 100 && vendasC < 150)
    {
        comissaoC = salarioFixoC * 0.05;
        salarioTotalC = salarioFixoC + comissaoC;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoC.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalC.ToString("F2") + ".");
    }
    else if (vendasC >= 150 && vendasC < 200)
    {
        comissaoC = salarioFixoC * 0.10;
        salarioTotalC = salarioFixoC + comissaoC;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoC.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalC.ToString("F2") + ".");
    }
    else if (vendasC >= 200 && vendasC < 250)
    {
        comissaoC = salarioFixoC * 0.15;
        salarioTotalC = salarioFixoC + comissaoC;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoC.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalC.ToString("F2") + ".");
    }
    else if (vendasC >= 250 && vendasC < 300)
    {
        comissaoC = salarioFixoC * 0.20;
        salarioTotalC = salarioFixoC + comissaoC;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoC.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalC.ToString("F2") + ".");
    }
    else if (vendasC >= 300)
    {
        comissaoC = salarioFixoC * 0.30;
        salarioTotalC = salarioFixoC + comissaoC;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoC.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalC.ToString("F2") + ".");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Para a quantidade de vendas informada não há comissão a ser calculada sobre o salário do funcíonário.");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioFixoC.ToString("F2") + ".");
    }
}
else if (resposta == funcionarioD)
{
    Console.WriteLine("Funcionário Selecionado: Jaskier Dandelion.");
    Console.WriteLine();
    Console.WriteLine("O código do funcionário é: " + codigoD + ".");
    Console.WriteLine("O salário fixo mensal do funcionário é de R$: " + salarioFixoD.ToString("F2") + ".");
    Console.Write("Informe o total de vendas do funcionário no mês: ");
    vendasD = int.Parse(Console.ReadLine());

    if (vendasD >= 100 && vendasD < 150)
    {
        comissaoD = salarioFixoD * 0.05;
        salarioTotalD = salarioFixoD + comissaoD;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoD.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalD.ToString("F2") + ".");
    }
    else if (vendasD >= 150 && vendasD < 200)
    {
        comissaoD = salarioFixoD * 0.10;
        salarioTotalD = salarioFixoD + comissaoD;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoD.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalD.ToString("F2") + ".");
    }
    else if (vendasD >= 200 && vendasD < 250)
    {
        comissaoD = salarioFixoD * 0.15;
        salarioTotalD = salarioFixoD + comissaoD;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoD.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalD.ToString("F2") + ".");
    }
    else if (vendasD >= 250 && vendasD < 300)
    {
        comissaoD = salarioFixoD * 0.20;
        salarioTotalD = salarioFixoD + comissaoD;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoD.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalD.ToString("F2") + ".");
    }
    else if (vendasD >= 300)
    {
        comissaoD = salarioFixoD * 0.30;
        salarioTotalD = salarioFixoD + comissaoD;

        Console.WriteLine();
        Console.WriteLine("O valor da comissão do funcionário para este mês é de: R$" + comissaoD.ToString("F2") + ".");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioTotalD.ToString("F2") + ".");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Para a quantidade de vendas informada não há comissão a ser calculada sobre o salário do funcíonário.");
        Console.WriteLine("O valor do salário final do funcionário é de: R$" + salarioFixoD.ToString("F2") + ".");
    }
}
else
{
    Console.WriteLine("Por gentileza, informe um umas das opções de cadastro \n" +
    "válidas para continuar com a sua busca.");
};
Console.WriteLine();
Console.WriteLine("Para realizar uma nova consulta, volte à página inicial.");
