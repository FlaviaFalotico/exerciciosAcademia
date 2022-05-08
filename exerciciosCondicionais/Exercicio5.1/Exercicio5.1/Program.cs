/*
5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
se a média das duas notas for maior ou igual a 7,0. 

Caso a média seja inferior a 7,0, o programa deve 
ler a nota do exame e calcular a média final. 

Se esta média for maior ou igual a 5,0, o programa deve 
escrever “Aprovado”, caso contrário deve escrever “Reprovado”.
*/

//usei encadeamento de condições.

double nota1, nota2, media = 0, exame = 0, mediaFinal = 0;

Console.Write("Informe a primeira nota: ");
nota1 = double.Parse(Console.ReadLine());

Console.Write("Informe a primeira nota:");
nota2 = double.Parse(Console.ReadLine());

media = (nota1 + nota2) / 2.0;

if (media >= 7)
{
    Console.WriteLine("A média do aluno é de " + media.ToString("F2") + " pontos.");
    Console.WriteLine("Aprovado!");
    
}
else 
{
    Console.Write("Informe a nota do exame: ");
    exame = double.Parse(Console.ReadLine());

    mediaFinal = (exame + media) / 2.0;

    if (mediaFinal >= 5)
    {
        Console.WriteLine("A média final do aluno é de " + mediaFinal.ToString("F1") + " pontos.");
        Console.WriteLine("Aprovado!");
    }
    else
    {
        Console.WriteLine("A média final do aluno é de " + mediaFinal.ToString("F1") + " pontos.");
        Console.WriteLine("Reprovado!");
    }
}