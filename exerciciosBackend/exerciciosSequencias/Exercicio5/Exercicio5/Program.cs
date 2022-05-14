/*
5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
(medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
consumido para percorrê-la (medido em l).
*/

double distancia, volume, consumo;

Console.WriteLine("Olá, vamos calcular o consumo médio de consumo de seu automóvel!");

Console.WriteLine();
Console.Write("Informe a distância total percorrida pelo veículo em km: ");
distancia = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.Write("Informe o volume de combustível consumido para percorrê-la em l: ");
volume = double.Parse(Console.ReadLine());

consumo = distancia / volume;

Console.WriteLine();
Console.WriteLine("O consumo médio do automóvel é de: " + consumo.ToString("F1") + "km/l.");