/*
14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
link de Internet (em Mbps). 

Em seguida, calcule e informe o tempo aproximado de download do arquivo usando este link (em minutos).

Interpretação do exercício:

Para calcular o tempo de download é importante saber que 1 megabyte é igual a 8 megabits, 
mas os termos são usados ​​de maneiras específicas:

Megabits por segundo (Mbps) são geralmente usados ​​para descrever a velocidade de uma conexão com a Internet;
Enquanto megabytes (MB) geralmente se referem ao tamanho de um arquivo ou espaço de armazenamento.

Fórmula:

Tamanho do arquivo em megabytes / (velocidade de download em megabits / 8) =  tempo em segundos.

Exemplo: Um arquivo de 15 MB, baixado a 10 Mb/s: 15 / (10/8) = 12 segundos.
*/

double tamanhoArquivo, velocidadeInternet, tempoDownloadMinutos;

Console.Write("Informe o tamanho do aqruivo (em MB - megabytes): ");
tamanhoArquivo = double.Parse(Console.ReadLine());
Console.Write("Informe a velocidade da internet (em Mbps - Megabits por segundo): ");
velocidadeInternet = double.Parse(Console.ReadLine());

tempoDownloadMinutos = tamanhoArquivo / (velocidadeInternet / 8.0) / 60;

Console.WriteLine();
Console.WriteLine("A velocidade de download do arquivo em minutos é de " + tempoDownloadMinutos.ToString("F1") + "min.");