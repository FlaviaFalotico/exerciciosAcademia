using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploLampadasOO
{
    internal class Lampada
    {
        private bool ligado;
        public int potencia;
        public String marca;

        public Lampada(int pot, String m)
        {
            potencia = pot;
            marca = m;
        }

        public void ligar()
        {
            ligado = true;
            Console.WriteLine("Ligando a lampada da marca: " + marca + " com potencia de: " + potencia);
        }
        public void desligar()
        {
            ligado = false;
            Console.WriteLine("Desligando a lampada da marca: " + marca + " com potencia de: " + potencia);
        }
        public bool estaLigada()
        {
            return ligado;
        }
    }
}

