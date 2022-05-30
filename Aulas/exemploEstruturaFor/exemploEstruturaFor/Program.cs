//Exemplo 1 - Executando um laço de respetição 4 vezes.

int i;
for (i = 0; i < 4; i++)
{   
    //i=i+1;
    Console.WriteLine("i vale " + i);
}

//Exemplo 2 - Escreva um algoritmo que mostre todos os nímeros de 0 a 10.

int i;
for (i = 0; i <= 10; i++) //ou i < 11
{
    Console.WriteLine(i);
}

//Exemplo 3 - Escreva um programa que apresente os números de 20 a 5.

int i;
for (i = 20; i >= 5; i--)
{
    Console.WriteLine(i);
}

//Exemplo 4 - Escreva um algoritmo leia pelo teclado os dois valores inteiros chamados
//inicio e fim, e então mostre todos os números entre inicio e fim.

Console.WriteLine("Digite um valor para início: ");
int valorInicial = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um valor para fim: ");
int valorFinal = int.Parse(Console.ReadLine());

int i;
if (valorInicial < valorFinal)
{
    for (i = valorInicial; i <= valorFinal; i++)
    {
        Console.WriteLine($"i vale {i}");
    }
}
else if (valorInicial > valorFinal)
{
    for (i = valorInicial; i >= valorFinal; i--)
    {
        Console.WriteLine($"i vale {i}");
    }
}
else
{
    Console.WriteLine("Os valores são iguais!");
}

//Exemplo 5 - Escreva um algoritmo leia pelo teclado um valor inteiro chamado x,
//e então mostre na tela todos os números de 0 a 100, pulando de x em x.

Console.WriteLine("Digite um valor para inteiro para x: ");
int x = int.Parse(Console.ReadLine());

int i;
for (i = 0; i <= 100; i += x) //i = i + x
{

    Console.WriteLine($"i vale {i}");
}

//Exemplo 6 - Escreva um algoritmo leia pelo teclado um valor inteiro chamado x, e então
//mostre na tela todos os números de 0 a 100 que são divisíveis por x.

Console.WriteLine("Digite um valor para inteiro para x: ");
int x = int.Parse(Console.ReadLine());

int i;
for (i = 1; i <= 100; i++)
{
    if (i % x == 0)
    {
        Console.WriteLine($"{i} é divisível por {x}");
    }
}

//tabuada

Console.WriteLine("Digite um valor para inteiro para x: ");
int x = int.Parse(Console.ReadLine());

int i, r;
for (i = 0; i <= 10; i++)
{
    r = i * x;
    Console.WriteLine($"{x} x {i} = {r}"); //Console.WriteLine( x + "x" + i " = " + i*x);

}