//Repetição para validar entradas em variáveis

//a nota é a vaíável de controle da instrução, pois é ela quem dá a condição (a nota deve estar entre 0 e 10).
//Utilizamos o do-while - para primeiro pedirmos uma instrução e depois validar.

/*

float nota;

do
{
    Console.Clear(); //limpar o console
    Console.Write("Informe a nota valída obtida no Bimestre [0 a 10]: ");
    nota = float.Parse(Console.ReadLine());

    if (nota < 0 || nota > 10)
    {
        Console.WriteLine("Nota inválida!Por gentileza, informe notas de 0 a 10.");
        Console.ReadKey();//ler a tecla
    }

} while (nota < 0 || nota > 11);

Console.WriteLine("Parabéns! A nota informada é válida.");

*/

//Repetição para ler nomes de pessoas e colocar em uma lista

//List<string> listaPessoas = new List<string>();
//string nome;

//do {
//    Console.Write("Digite um nome de pessoa ou sair para encerrar o programa: ");
//    nome = Console.ReadLine().ToUpper();

//    if (nome == "SAIR") {
//        break; //encerra a repetição
//    }
//    listaPessoas.Add(nome);

//} while (true);

////listaPessoas = [0, 1, 2, 3, ..., n]
//for (int i = 0; i < listaPessoas.Count; i++)
//{
//    Console.WriteLine(listaPessoas[i]);
//}

//Valores de glicemia

//int valorGlicemia; //45 a 450
//List<int> ListaGlicemia = new List<int>();

//int TOTAL = 10; // letras maiúsculas são constantes, significa que esse valor não será alterado.
//for (int i = 0; i < TOTAL; i++) {

//    do {
//        Console.Write("Digite um valor de glicemia válido [45 a 450]: ");
//        valorGlicemia = int.Parse(Console.ReadLine());

//        if (valorGlicemia >= 45 && valorGlicemia <= 450)
//        {
//            break;
//        }
//        else
//        {
//            Console.WriteLine("Valor de glicemia inválido! Informe um valor entre 45 e 450.");
//        }
//    }while (true);
    
//    ListaGlicemia.Add(valorGlicemia);
//}
//for (int i = 0; i < ListaGlicemia.Count; i++)
//{
//    Console.WriteLine(ListaGlicemia[i]);
//}

