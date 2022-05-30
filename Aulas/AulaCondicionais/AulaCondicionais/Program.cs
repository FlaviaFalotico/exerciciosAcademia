/*int num;

Console.WriteLine("Digite um número:");
num = int.Parse(Console.ReadLine());

if (num > 0)
{
    Console.WriteLine("Positivo!"); // se dentro da estrutura condicional tivermos apenas uma linha não precisamos necessariamente colocar as chaves.
}
else if (num < 0)
{
    Console.WriteLine("Negativo!");
}
else
{
    Console.WriteLine("Zero!");
}

//não há ponto e vírgula nas condicionais porque elas não são comandos.

/// <summary>
/// Um número é divisível por 2, 4, ou 8.
/// As possibilidades de divisão por 2, tem as seguintes possibilidades = 0 ou 1
/// As possibilidades de divisão por 4, tem as seguintes possibilidades = de 0 a 3
/// As possibilidades de divisão por 8, tem as seguintes possibilidades = de 0 a 7
/// As possibilidades de divisão por 30, tem as seguintes possibilidades = de 0 a 29
/// 
/// Qualquer número par tem resto 0 na divisão por 2, se não ele é ímpar.
/// </summary>
int numero;
Console.WriteLine("Digite um número:");
numero = int.Parse(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("Divisível por 2!");
}
if (numero % 4 == 0)
{
    Console.WriteLine("Divisível por 4!");
}
if (numero % 8 == 0)
{
    Console.WriteLine("Divisível por 8!");
}
*/
//testa todas as opções e depois executa

/*
int num1, num2;

Console.WriteLine("Digite dois números:");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());

if (num1 == num2)
{
    Console.WriteLine("Os números " + num1 + " e " + num2 + " são iguais.");
}
else
{
    Console.WriteLine("Os números " + num1 + " e " + num2 + " são diferentes.");
}

int num3, num4;

Console.WriteLine("Digite dois números:");
num3 = int.Parse(Console.ReadLine());
num4 = int.Parse(Console.ReadLine());

if (num3 != num4)
{
    Console.WriteLine("Os números " + num3 + " e " + num4 + " são diferentes.");
}
else
{
    Console.WriteLine("Os números " + num3 + " e " + num4 + " são iguais.");
}
*/

//Calculadora

double num1, num2, resultado;
int op;

Console.WriteLine("Digite dois números:");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("\nEscolha a operação:\n1.Soma\n2.Subtração\n3.Multiplicação\n4.Divisão\n5.Potência\n\nEscolha:");
op = int.Parse(Console.ReadLine());

if (op == 1)
{
    resultado = num1 + num2;
    Console.WriteLine("Soma = " + resultado);
}
else if (op == 2)
{
    resultado = num1 - num2;
    Console.WriteLine("Subtração = " + resultado);
}
else if (op == 3)
{
    resultado = num1 * num2;
    Console.WriteLine("Multiplicação = " + resultado);
}
else if (op == 4)
{
    resultado = num1 / num2;
    Console.WriteLine("Divisão = " + resultado);
}
else if (op == 5)
{
    resultado = Math.Pow(num1,num2);
    Console.WriteLine("Potência = " + resultado);
}