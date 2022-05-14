/*
13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga 
a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o preço de custo 
de cada bicicleta vendida. 

Desenvolva um algoritmo que leia:

- o valor do salário mínimo
- o preço de custo de cada bicicleta 
- o número de bicicletas vendidas pelo vendedor

Calcule e mostre:

- o salário do empregado

Interpretação:

Salário minímo =                 = R$1212,00
Preço de custo de cada bicicleta = R$1000,00

Nome do        N°de Bicicletas           
Vendedor       Vendidas no mês         

José da Silva         10            
Maria Souza           15
Pedro Cardozo         18
Ana Rodrigues         09

precoVenda = custo * 1.5; //ou  precoVenda = custo * 0.5 + custo;

salarioFuncionario = salarioMinimo * 2 + (0,15 * 1000 * bicicletasVendidas)
*/

double salarioMinimo, custoBicicleta, quantidadeBicicleta, salarioEmpregado;

Console.WriteLine("Digite o valor do salário minímo:");
salarioMinimo = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o preço de custo da bicicleta:");
custoBicicleta = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o número de bicicletas vendidas pelo vendedor:");
quantidadeBicicleta = double.Parse(Console.ReadLine());

//precoVenda = custo * 1.5; // ou  precoVenda = custo * 0.5 + custo;

salarioEmpregado = (salarioMinimo * 2) + (custoBicicleta * 0.15 * quantidadeBicicleta);

Console.WriteLine("O salário final do vendedor é igual a R$" + salarioEmpregado.ToString("F2") + ".");