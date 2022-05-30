/*
Crie uma classe chamada Motor que possua três atributos visíveis apenas na 
própria classe, são eles: nomeFabricante, potência e tipo.

• Também deverão ser criados dois métodos visíveis a qualquer classe, sendo 
que um desses métodos deverá associar valores aos atributos e outro 
método deverá retornar o conteúdo desses atributos. Em uma outra classe 
deverá ser instanciada a classe Motor e apresentado na tela os valores dos 
atributos retornados pelo método correspondente da classe Motor. 
*/

using exercicio3ClasseMotor;

Console.WriteLine("Modo 1 de fazer:");


Motor motor = new Motor();
Console.WriteLine("Digite o nome do fabricante do motor:");
motor.NomeFabricante = Console.ReadLine();
Console.WriteLine("Digite o tipo do motor:");
motor.Tipo = Console.ReadLine();
Console.WriteLine("Digite a potência do motor:");
motor.Potencia = int.Parse(Console.ReadLine());
motor.exibirDadosMotor();

Motor mortor3 = new Motor("Chevrolet", "Motor 1.0", 79);
Console.WriteLine("O fabricante do motor é: " + mortor3.NomeFabricante + ", o tipo do motor é: " + mortor3.Tipo + " e a potência do motor é de " + mortor3.Potencia + "cv.");