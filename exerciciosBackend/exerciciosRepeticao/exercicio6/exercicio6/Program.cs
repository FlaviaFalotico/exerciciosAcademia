/*
6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
Ao final, mostre a idade digitada.
*/

//utilizando a estrutura while:

int idade=0;

while(idade <= 0)
{
    Console.Clear();
    Console.Write("Digite uma idade: ");
    idade = int.Parse(Console.ReadLine());
    Console.WriteLine();
       
    Console.ReadKey();
}
Console.WriteLine("--------------------------------------");
Console.WriteLine($"Idade informada = {idade} ano(s).");

//Utilizando a estrutura do-while
//int idade = 0;
do
{ 
    Console.Clear();
    Console.Write("Digite uma idade: ");
    idade = int.Parse(Console.ReadLine());

    if (idade <= 0)
    {
        Console.Write("Digite uma idade válida (a partir de 1 ano): ");
        idade = int.Parse(Console.ReadLine());
    }
    else
    {
        break;
    }
    
    Console.ReadKey();
} while (idade < 0);
Console.WriteLine("--------------------------------------");
Console.WriteLine($"Idade informada = {idade} ano(s).");