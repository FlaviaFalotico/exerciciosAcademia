/*
8) Ler uma temperatura em graus Celsius e apresentá-la convertida 
em graus Fahrenheit. A fórmula da conversão é F=(9*C+160)/5.

Posso utilizar também:

Celsius para Fahrenheit - (0 °C × 9/5) + 32 = 32 °F
Fahrenheit para Celsius - (32 °F − 32) × 5/9 = 0 °C
*/

int opcao1 = 1, opcao2 = 2;
double valorCelsius, valorFahrenheit;

Console.WriteLine("Olá, seja bem-vindo à calculadora de conversão de temperatura!");
Console.WriteLine();
Console.WriteLine("Digite o tipo de conversão de temperatura que deseja realizar: ");
Console.WriteLine();
Console.WriteLine("1 - De Celsius para Fahrenheit.");
Console.WriteLine("2 - De Fahrenheit para Celsius.");
Console.WriteLine();
int resposta = int.Parse(Console.ReadLine());

Console.WriteLine();

if (resposta == opcao1)
{
    Console.WriteLine("Muito bem! Você escolheu a conversão de temperatura: Celsius para Fahrenheit.");
    Console.WriteLine();
    Console.WriteLine("Digite o valor de temperatura que deseja converter: ");
    Console.WriteLine();
    double temperaturaCelsius = double.Parse(Console.ReadLine());

    valorFahrenheit = ( temperaturaCelsius * 9 / 5) + 32;

    Console.WriteLine();
    Console.WriteLine("A temperatura de " + temperaturaCelsius.ToString("F1") + "°C, corresponde a " + valorFahrenheit.ToString("F1") + "°F.");

    Console.WriteLine();
    Console.WriteLine("Agrademos à visita!");
}
else if (resposta == opcao2)
{
    Console.WriteLine("Muito bem! Você escolheu a conversão de temperatura: Fahrenheit para Celsius.");
    Console.WriteLine();
    Console.WriteLine("Digite o valor de temperatura que deseja converter: ");
    Console.WriteLine();
    double temperaturaFahreinheit = double.Parse(Console.ReadLine());

    valorCelsius = (temperaturaFahreinheit - 32) * 5 / 9;

    Console.WriteLine();
    Console.WriteLine("A temperatura de " + temperaturaFahreinheit.ToString("F1") + "ºF, corresponde a " + valorCelsius.ToString("F1") + "ºC.");

    Console.WriteLine();
    Console.WriteLine("Agrademos à visita!");
}
else
{
    Console.WriteLine("Escolha uma opção de conversão válida para prosseguir!");
}

/*
Resolução do Professor:

Tipo de uma variável indica quanto de memória aquele dado irá ocupar.

Obs.: As variáveis do tipo double ocupam um espaço de memória maior do que as do tipo float.
Dicas - desenvolver jogos em C# e seguir git desses devs para aprender - uma forma diferente de pensar e programar
Podemos estudar tipos de listas 

float temperaturaCelsius;
float temperaturaFahrenheit;

Console.WriteLine("Digite a temperatura em graus Celsius:");
temperaturaCelsius = float.Parse(Console.ReadLine());

temperaturaFahrenheit = (9 + temperaturaCelsius + 160) / 5;

Console.WriteLine("O valor " + temperaturaCelsius + " em graus Celsius é em Fahrenheit: " + temperaturaFahrenheit);

*/