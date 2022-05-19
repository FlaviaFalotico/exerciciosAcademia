/*
12. Apresentar o total da soma dos cem primeiros números inteiros. 


//Soma dos 100 primeiros números inteiros e positivos de 1 a 100:
int soma = 0;
for (int i = 1; i <=100; i++)
{
    soma += i;
}
Console.WriteLine($"A soma dos 100 primeiros inteiros e positivos é de {soma}.");
*/

//Usando a classe List:

int i = 1, total;
List<int> cemNumeros = new List<int> ();
do{
    cemNumeros.Add(i);
    i++;
} while(i <= 100);

total = cemNumeros.Sum();

Console.WriteLine($"A soma dos 100 primeiros inteiros e positivos é de {total}.");