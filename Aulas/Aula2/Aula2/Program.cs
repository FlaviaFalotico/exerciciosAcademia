//O compilador entende que queremos apenas a parte inteira. Para termos o decimal,
//deveríamos ter atrribuído o tipo float às variáveis a e b.

//int a, b, divisao;

//a = 345;
//b = 10;

//divisao = a / b;

//Console.WriteLine("O resultado da divisão é igual a: " + divisao + ".");

//double a, b, divisao;

//a = 345;
//b = 10;

//divisao = a / b;

//Console.WriteLine("O resultado da divisão é igual a: " + divisao + ".");

//Poderíamos ter feito o casting também:

//int a, b;
//double divisao;

//a = 345;
//b = 10;

//divisao = (double) a / b;

//Console.WriteLine("O resultado da divisão é igual a: " + divisao + ".");

//Resto da divisão (mod)

//int a, b, resto;paint

//a = 345;
//b = 10;

//resto = a % b;

//Console.WriteLine("O resto da divisão é igual a: " + resto + ".");

/*Conceitos para realizar o exercício:
Console.WriteLine("Informe o valor que deseja sacar: ");
int a = int.Parse(Console.ReadLine());

int b, divisao, resto;

b = 200;
divisao = a / b;
Console.WriteLine("quantidade de nota de 200: " + divisao);
resto = a % b;
b = 100;

divisao = resto / b;
Console.WriteLine("quantidade de nota de 100: " + divisao);
resto = a % b;
b = 50;

divisao = resto / b;
Console.WriteLine("quantidade de nota de 50: " + divisao);
resto = a % b;
b = 20;

divisao = resto / b;
Console.WriteLine("quantidade de nota de 20: " + divisao);
resto = a % b;
b = 10;

divisao = resto / b;
Console.WriteLine("quantidade de nota de 10: " + divisao);
resto = a % b;
b = 5;

divisao = resto / b;
Console.WriteLine("quantidade de nota de 5: " + divisao);
resto = a % b;
b = 2;

divisao = resto / b;
Console.WriteLine("quantidade de nota de 2: " + divisao);
resto = a % b;
*/