/*
Considere que será concedido um bônus aos
trabalhadores de uma empresa, conforme o salário
atual do vendedor, descrito abaixo. Desenvolva o
algoritmo para ler o salário e calcular o valor em reais
do aumento. Exibir na tela, o salário atual, o aumento
(% e R$) e o novo salário.

• Salários % aumento

• Até R$ 900,00 (inclusive)..........................5%
• De R$ 900,00 a R$ 1.400,00.........................8%
• Acima de R$ 1.400,00 (inclusive)...................10% 
*/

double salario, aumento = 0;

Console.WriteLine("Digite o salário: ");
salario = double.Parse(Console.ReadLine());

if (salario < 900)
{
    aumento = 5;
}
else if (salario >= 900 && salario < 1400)
{
    aumento = 8;
}
else if (salario >= 1400)
{
    aumento = 10;
}
salario = salario + salario * (aumento / 100);
Console.WriteLine("O aumento é de " + aumento + "porcento e o salário final é de " + salario);