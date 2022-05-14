/*
9) Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
do que ou igual às duas prestações, que devem ser iguais, inteiras e as maiores possíveis. 

Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a 
R$ 90,00; se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são 
iguais a R$ 100,00.

Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
da entrada e das duas prestações, de acordo com as regras acima. 

Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
conseqüente pagamento dos boletos das duas prestações.
*/

Console.WriteLine("Sistema de Parcelamento da Minha Loja.");
Console.WriteLine();
Console.WriteLine("Olá, seja muito bem-vindo(a)!");

Console.WriteLine();
Console.WriteLine("Digite o valor do produto que deseja parcelar: ");
Console.WriteLine();
double valorProduto = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Para um produto que custe R$" + valorProduto.ToString("F2") + ". Você terá a seguinte opção de pagamento: ");

double resto, entrada, parcela;

resto = valorProduto % 3;
entrada = resto + ((valorProduto - resto) / 3);
parcela = (valorProduto - resto) / 3;

Console.WriteLine();
Console.WriteLine("O valor da entrada do produto é de: R$" + entrada.ToString("F2") + ".");
Console.WriteLine();
Console.WriteLine("O valor da primeira parcela do produto é de: R$" + parcela.ToString("F2") + ".");
Console.WriteLine();
Console.WriteLine("O valor da segunda parcela do produto é de: R$" + parcela.ToString("F2") + ".");
Console.WriteLine();
Console.WriteLine("Ao final do pagamento o cliente terá investido um total de: R$" + valorProduto + ".");

Console.WriteLine();
Console.WriteLine("Para realizar uma nova consulta, retorne à página inicial.");