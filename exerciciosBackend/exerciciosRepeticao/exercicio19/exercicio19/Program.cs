/*
19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 
 
a) média do salário da população;
b) média do número de filhos;
c) maior salário;
d) percentual de pessoas com salário até R$ 1000,00.

O final da leitura de dados se dará com a entrada de um salário negativo. 
*/

List<int> listaFilhos = new List<int>();
List<double> listaSalarios = new List<double>();

int opcao = 0;
do
{
    Console.Clear();
    Console.WriteLine("MENU:");
    Console.WriteLine("---------------------------------------------------------------------------------");
    Console.WriteLine("1 -Cadastrar quantidade de filhos e a remuneração dos munícipes.");
    Console.WriteLine("2 -Apresentar lista de filhos e a remuneração dos munícipes.");
    Console.WriteLine("3 - Exibir:\n\t\tA maior quantidade de filhos por habitante.\n\t\tA média salarial dos habitantes do município.\n\t\t" +
        "O maior salário por habitante.\n\t\tA média salarial dos habitantes do município.\n\t\tPercentual dos habitantes que recebem até R$1.000,00.");
    Console.WriteLine("4 - Sair");
    Console.WriteLine("---------------------------------------------------------------------------------");
    Console.WriteLine();
    Console.Write("Opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine();
            Console.Write("Informe a quantidade de filhos do munícipe: ");
            int numeroFilhos = int.Parse(Console.ReadLine());
            
            Console.Write("Informe a remuneração salarial do munícipe: ");
            double valorSalario = double.Parse(Console.ReadLine());

            if (numeroFilhos > 0 && valorSalario > 0.0)
            {
                listaFilhos.Add(numeroFilhos);
                listaSalarios.Add(valorSalario);
                
               Console.WriteLine("Quantidade de filhos e remuneração do munícipe cadstrada com sucesso!");
            }
            else
            {
                Console.WriteLine("Impossível cadastrar");
                Console.WriteLine("A quantidade de filhos e o valor do salário não podem recebem valores negativos.");
            }
            break;
        case 2:
            Console.WriteLine("Exibindo a lista de quantidade de filhos e valor da remuneração dos munícipes: ");
            if (listaFilhos.Count == 0 || listaSalarios.Count == 0)
            {
                Console.WriteLine("Lista Vazia!");
            }
            else
            {
                int cont = 1;
                for (int i = 0; i < listaFilhos.Count && i < listaSalarios.Count; i++)
                {
                    Console.Write($"Id.{cont} - {listaFilhos[i]} filhos; ");
                    Console.WriteLine($"R${listaSalarios[i]:F2} de remuneração.");
                    cont++;
                }
            }
            break;
        case 3:
            if (listaFilhos.Count == 0 || listaSalarios.Count == 0)
            {
                Console.WriteLine("Lista Vazia!");
            }
            else
            {
                int maxFilho = 0;
                double mediaFilhos = 0.0;
                double maxSalario = 0.0;
                double mediaSalarios = 0.0;

                List<int> listaFilhosTemp = new List<int>();
                listaFilhosTemp.AddRange(listaFilhos);
                listaFilhosTemp.Sort();
                maxFilho = listaFilhosTemp[listaFilhosTemp.Count - 1];

                int somaFilhos = 0;
                foreach (int i in listaFilhosTemp)
                {
                    //soma = soma + i;
                    somaFilhos += i;
                }
                mediaFilhos = somaFilhos / listaFilhosTemp.Count;

                List<double> listaSalariosTemp = new List<double>();
                listaSalariosTemp.AddRange(listaSalarios);
                listaSalariosTemp.Sort();
                maxSalario = listaSalariosTemp[listaSalariosTemp.Count - 1];

                double somasalarios = 0.0;
                foreach (int i in listaSalariosTemp)
                {
                    somasalarios += i;
                }
                mediaSalarios = somasalarios / listaSalariosTemp.Count;               

                Console.WriteLine($"O maior número de filhos por habitante registrado no município é de: {maxFilho} filhos.");
                Console.WriteLine($"A média de filhos dos habitante do municipio é de: {mediaFilhos:F1} filhos.");
                Console.WriteLine($"O maior salário por habitante registrado no município é de: R${maxSalario:F2}.");
                Console.WriteLine($"A média salárial dos habitante do municipio é de: R${mediaSalarios:F2}.");                
            }
            break;
        case 4:
            Console.WriteLine();
            Console.WriteLine("A Prefeitura agradece à sua visita!");
            break;
    }
    Console.WriteLine();
    Console.Write("Pressione qualquer tecla para continuar!");
    Console.ReadKey();
} while (opcao != 4);