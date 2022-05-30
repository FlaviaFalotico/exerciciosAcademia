using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3ClasseMotor
{
    internal class Motor
    {
        //atributos
        private String nomeFabricante;
        private String tipo;
        private int potencia;

        public string NomeFabricante { get => nomeFabricante; set => nomeFabricante = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Potencia { get => potencia; set => potencia = value; }

        //construtor
        public Motor()
        {

        }
        public Motor(string nomeFabricante, string tipo, int potencia)
        {
            this.NomeFabricante = nomeFabricante;
            this.Tipo = tipo;
            this.Potencia = potencia;
        }

        public void exibirDadosMotor()
        {
            Console.WriteLine("Nome do fabricante: " + NomeFabricante + "; o tipo do motor é: " + Tipo + "; a potência do motor é: " + Potencia + ".");
        }
    }
}
