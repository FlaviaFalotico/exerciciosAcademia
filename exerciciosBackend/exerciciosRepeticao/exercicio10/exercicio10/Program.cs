/*
10. Ler nome, sexo e idade de 50 pessoas e após imprimir:

Número de pessoas do sexo masculino.
Número de pessoas do sexo feminino.
Número de pessoas com idade inferior a 30 anos.
Número de pessoas com idade superior a 60 anos.
Média de idade das mulheres.
*/

int idade = 0;
int contMenor30 = 0, contMeiaIdade = 0, contMaior60 = 0, contFem = 0, contMasc = 0;
string nome = "", sexo = "";
double somaFem = 0.0, somaMasc = 0.0, mediaIdadeMulheres, mediaIdadeHomens;

for (int i = 1; i <= 2; i++)
{
    Console.Clear();
    do
    {        
        Console.Write("Digite o seu nome: ");
        nome = Console.ReadLine();

        if (nome == "" || nome.All(char.IsNumber) == true)
        {
            Console.WriteLine("Nome informado inválido!");
        }       
    } while (nome == "" || nome.All(char.IsNumber) == true);

    do
    {        
        Console.Write("Digite a sua idade: ");
        idade = int.Parse(Console.ReadLine());

        if (idade > 0 && idade < 30)
        {
            contMenor30++;
        }
        else if (idade >= 30 && idade <= 60)
        {
            contMeiaIdade++;
        }
        else if (idade > 60)
        {
            contMaior60++;
        }        
        else
        {
            Console.WriteLine("Idade informada inválida!");
        }       
    } while (idade <= 0);
    
    do
    {
        Console.WriteLine("Informe o seu sexo:\n\nF - Sexo Feminino\nM - Sexo Masculino ");
        Console.WriteLine();
        sexo = Console.ReadLine().ToUpper();

        switch (sexo)
        {
            case "F":
                contFem++;
                somaFem = somaFem + idade;
                break;
            case "M":
                contMasc++;
                somaMasc = somaMasc + idade;
                break;
            default:
                Console.WriteLine("Opção de sexo informada inválida!");
                break;
        }
    } while (sexo == "");
    Console.ReadKey();
}
Console.Clear();
Console.WriteLine("Resultado:");
Console.WriteLine("---------------------------------------------------------");
Console.WriteLine($"{contMasc} pessoa(s) do sexo masculino.");
Console.WriteLine($"{contFem} pessoa(s) do sexo feminino.");
Console.WriteLine($"{contMenor30} pessoa(s) com idade inferior a 30 anos.");
Console.WriteLine($"{contMeiaIdade} pessoa(s) com idade entre 30 e 60 anos.");
Console.WriteLine($"{contMaior60} pessoa(s) com idade superior a 60 anos.");
Console.WriteLine($"O valor da média das idades das mulheres é de {mediaIdadeMulheres = somaFem / contFem:F1}.");
Console.WriteLine($"O valor da média das idades dos homens é de {mediaIdadeHomens = somaMasc / contMasc:F1}.");
Console.WriteLine("---------------------------------------------------------");