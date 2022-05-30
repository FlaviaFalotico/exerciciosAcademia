/*
Crie uma classe chamada Disciplina que contenha os atributos nome da 
disciplina e carga horária. Tanto o nome da disciplina quanto a carga horária 
são definidos pelo construtor da própria classe. Além do construtor, crie um 
método para exibir esses dados após a sua atribuição. O método para exibir 
os dados deverá ser chamado em uma outra classe. 
*/

using exercicio2ClasseDisciplina;

Disciplinas novoCadastro = new Disciplinas();

Console.WriteLine("Digite o nome da Discilina:");
novoCadastro.NomeDisciplina = Console.ReadLine();
Console.WriteLine("Digite a carga horária da Discilina:");
novoCadastro.CargaHoraria = double.Parse(Console.ReadLine());

novoCadastro.exibirDadosDisciplinas();