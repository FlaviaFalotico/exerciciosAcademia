/*
11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis 
(uma para hora e outra para minutos).
O programa deve exibir se a hora digitada está ou não válida. 
Lembre que usaremos o padrão de hora com 24h, de 0h a 23h.
*/

int horas, minutos;

Console.Write("Informe um valor para a hora: ");
horas = int.Parse(Console.ReadLine());
Console.Write("Informe um valor para os minutos: ");
minutos = int.Parse(Console.ReadLine());

if ((horas >= 0 && horas <= 23) && (minutos >= 0 && minutos <= 59))
{
    Console.WriteLine();
    Console.WriteLine("A hora informada é válida: " + horas + ":" + minutos + ".");
}
else
{
    Console.WriteLine();
    Console.WriteLine("A hora informada não é válida.");
}