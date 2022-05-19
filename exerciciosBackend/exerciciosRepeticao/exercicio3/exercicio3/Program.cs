/*
3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
Se o usuário digitar 0 o programa em VS deve parar. 
Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.   
*/

int numero;
do
{
    Console.Write("Informe um número: ");
    numero = int.Parse(Console.ReadLine());

    if (numero > 0 && numero % 2 == 0)
    {
        Console.WriteLine($"O número {numero} é par.");
        Console.WriteLine();
    }
    if (numero > 0 && numero % 2 != 0)
    {
        Console.WriteLine($"O número {numero} é ímpar.");
        Console.WriteLine();
    } 
} while (numero > 0 && numero != 0);