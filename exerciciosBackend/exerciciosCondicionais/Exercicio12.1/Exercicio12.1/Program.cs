/*
12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
R$ 10,00 por hora. 

Quando o número de horas exceder a 50 calcule o excesso de pagamento 
armazenando-o na variável "extra", caso contrário zerar tal variável: 

A hora excedente de trabalho vale R$ 20,00. 

No final do processamento, exibir o salário total e o salário excedente do operário. 
*/

int codigo;
double numeroHoras, extra = 0 , salario;

Console.Write("Informe o código do funcionário: ");
codigo = int.Parse(Console.ReadLine());
Console.Write("Informe o número de horas trabalhadas pelo funcionário: ");
numeroHoras = double.Parse(Console.ReadLine());

if (numeroHoras > 50)
{
   extra = numeroHoras - 50.0;
   salario = (numeroHoras - extra) * 10.0 + (extra * 20.0);
   Console.WriteLine();
   Console.WriteLine("O salário final do funcionário é: R$" + salario.ToString("F2") + ".");
}
else
{
    salario = numeroHoras * 10.0;
    Console.WriteLine();
    Console.WriteLine("O salário final do funcionário é: R$" + salario.ToString("F2") + ".");    
}
