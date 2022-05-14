/*
12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que 
o preço do combustível é de R$6,90, escreva um algoritmo para ler a marcação do odômetro (marcador 
de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível 
gasto e o valor total (R$) recebido dos passageiros. Calcule e escreva a média do consumo em Km/l 
e o lucro líquido do dia.

Fórmulas: 

Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 

Média do consumo = Total quilometragem/ quantidade de combustível gasto

Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)
*/

Console.WriteLine("Bem-vindo(a) à calculadorada mais amiga do Taxista: Amarelinha!");
Console.WriteLine("Para começarmos, precisamos que você nos forneça alguns dados:");

Console.WriteLine();
Console.WriteLine("Digite o valor do litro do combustível:");
double precoCombustivel = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Digite a marcação incial do odômetro ao inciar o seu dia de corridas:");
double odometroInicial = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Digite a marcação final do odômetro ao finalizar o seu dia de corridas:");
double odometroFinal = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Digite o volume, em litros, de combustível consumido:");
double consumoCombustivel = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Digite o valor do seu lucro bruto nesse dia:");
double lucroBruto = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Você forneceu as seguintes informações:");
Console.WriteLine();
Console.WriteLine("O valor informado para o preço do litro do combustível foi de R$" + precoCombustivel.ToString("F2") + ".");
Console.WriteLine("A quilometragem inical do odômetro informada foi de " + odometroInicial.ToString("F2") + "km.");
Console.WriteLine("A quilometragem final do odômetro informada foi de " + odometroFinal.ToString("F2") + "km.");
Console.WriteLine("O consumo de combústivel em litros do dia foi de " + consumoCombustivel.ToString("F2") + " litros.");
Console.WriteLine("O lucro bruto informado para o dia em questão foi de R$" + lucroBruto.ToString("F2") + ".");

double totalQulimetragem, mediaConsumo, lucroLiquido;

totalQulimetragem = odometroFinal - odometroInicial;
mediaConsumo = totalQulimetragem / consumoCombustivel;
lucroLiquido = lucroBruto - (consumoCombustivel * precoCombustivel);

Console.WriteLine();
Console.WriteLine("Vamos calcular!");
Console.WriteLine();
Console.WriteLine("A média de consumo é de " + mediaConsumo.ToString("F2") + "km/l.");
Console.WriteLine();
Console.WriteLine("O lucro líquido do dia é de R$" + lucroLiquido.ToString("F2") + ".");

Console.WriteLine();
Console.WriteLine("Agradecemos pela preferência da nossa Amarelinha. Volte sempre!");