/*
Para relembrar:

4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
de votos em branco. 

Exercício a ser resolvido:

5. Modifique o programa em VS anterior para aceitar votos nulos 
(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
Ao final, informe o nome do candidato vencedor, o número de votos nulos 
e o número de pessoas que votaram. 
*/

int votoEleitor = 0;
int votosZECA = 0, votosJOAO = 0, votosBRANCO = 0, votosNULO = 0;

do
{
    Console.Clear();
    Console.WriteLine("Informe em qual dos candidatos abaixo deseja votar ou, então, escolha uma " +
        "das outras opções disponíveis:\n\n1 - ZECA\n2 - JOAO\n3 - BRANCO\n4 - NULO\n5 - SAIR");
    Console.WriteLine();
    votoEleitor = int.Parse(Console.ReadLine().ToUpper());

    switch (votoEleitor)
    {
        case 1:
            votosZECA++;
            Console.WriteLine("Obrigado por votar nessas eleições!");
            break;
        case 2:
            votosJOAO++;
            Console.WriteLine("Obrigado por votar nessas eleições!");
            break;
        case 3:
            votosBRANCO++;
            Console.WriteLine("Obrigado por votar nessas eleições!");
            break;
        case 4:
            votosNULO++;
            Console.WriteLine("Obrigado por votar nessas eleições!");
            break;
        case 5:
            Console.WriteLine("Obrigado por votar nessas eleições!");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    Console.WriteLine("Pressione qualquer tecla para retornar à tela inicial ou sair da aplicação.");
    Console.ReadKey();

} while (votoEleitor != 5);

Console.WriteLine();
Console.WriteLine($"Total de votos para o ZECA: {votosZECA}.");
Console.WriteLine($"Total de votos para o JOAO: {votosJOAO}.");
Console.WriteLine($"Total de votos em BRANCO: {votosBRANCO}.");
Console.WriteLine($"Total de votos para NULOS: {votosNULO}.");