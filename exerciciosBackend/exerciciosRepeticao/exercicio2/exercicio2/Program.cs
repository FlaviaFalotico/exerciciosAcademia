/*
2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
informar um outro número. Caso positivo, o programa em VS deve ser repetido.
 
Exemplo:
Digite um número inteiro positivo: 8
Numero digitado: 8
Números inteiros pares entre 1 e 8: 2, 4, 6.
 
Deseja informar outro número (s/n)? S
 
Digite um número inteiro positivo: 12
Numero digitado: 20
Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.
 
Deseja informar outro número (s/n)? N  
*/

do
{
    int numero;
    do
    {
        Console.Write("Digite um número inteiro e positivo: ");
        numero = int.Parse(Console.ReadLine());

        if (numero < 0 || numero == 1)
        {
            Console.Clear();
            Console.WriteLine("Valor incorreto!");
        }
        else if (numero == 2)
        {
            Console.WriteLine($"Não há números inteiros pares entre 1 e {numero}.");
        }
        else
        {
            Console.WriteLine($"Números inteiros pares entre 1 e {numero}:");
            for (int i = 1; i < numero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + "  ");
                }
            }
        }
    } while (numero < 0 || numero == 2 || numero ==1);

    Console.WriteLine();
    Console.WriteLine("Deseja informar outro número (s/n)?");
    string pergunta = Console.ReadLine().ToLower();

    if (pergunta == "n")
    {
        break;
    }
    if (pergunta != "n" && pergunta != "s")
    {
        Console.WriteLine("Atenção! Opção inexistente.");
        Console.WriteLine("Deseja informar outro número (s/n)?");
        pergunta = Console.ReadLine().ToLower();
    }

} while (true);