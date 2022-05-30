/*Declaração de uma Classe em C#*/
using System.Globalization;

Lampada l = new Lampada(); //l é a variável que criamos
l.potencia = 9.0;
l.ligar();
Console.WriteLine("Ligada? " + l.ligado + "\nPotência = " + l.potencia.ToString("F1", CultureInfo.InvariantCulture) + "W");

Console.WriteLine();
l.desligar();
Console.WriteLine("Ligada? " + l.ligado + "\nPotência = " + l.potencia.ToString("F1", CultureInfo.InvariantCulture) + "W");

Console.WriteLine();
double n = l.retornaPotencia();

Console.WriteLine("Retorno da função estaLigada = " + l.estaLigada());

//Para ligar
Console.WriteLine();
l.ligar();
if (l.estaLigada())
{
    Console.WriteLine("A lâmpada está ligada!");
}
else
{
    Console.WriteLine("A lâmpada está desligada!");
}

//Para desligar
Console.WriteLine();
l.desligar();
if (l.estaLigada())
{
    Console.WriteLine("A lâmpada está ligada!");
}
else
{
    Console.WriteLine("A lâmpada está desligada!");
}

public class Lampada
{
    //atributos
    public bool ligado; // aqui eu vou poder somente se é true ou false
    public double potencia; //por enquanto isso fica em off
    
    //métodos

    //visibilidade do método: public, private, protected
    //tipo de retorno:
    //void - não retorna nada
    // int - retorna um inteiro
    //double retorna um double
    public void ligar() 
    {
        Console.WriteLine("A lâmpada está sendo ligada");
        ligado = true; 
    } 
    public void desligar() 
    { 
        Console.WriteLine("A lâmpada está sendo desligada");
        ligado = false; 
    }
    public double retornaPotencia()
    {
        return potencia;
    }
    public bool estaLigada() //retorna o valor da variável ligado
    { 
        return ligado; 
    }
}