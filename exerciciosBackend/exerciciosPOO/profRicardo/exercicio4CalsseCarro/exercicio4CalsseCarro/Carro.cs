using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4CalsseCarro
{
    internal class Carro
    {
        String modelo;
        String cor;
        String marca;
        String chassi;
        String proprietario;
        double velocidadeMax;
        double velocidadeAtual;
        int numeroPortas;
        int numeroMarchas;
        Boolean tetoSolar;
        Boolean cambioAuto;
        double volumeCombustivel;

        public Carro()
        {

        }

        public Carro(string modelo, string cor, string marca, string chassi, string proprietario, double velocidadeMax, double velocidadeAtual, int numeroPortas, int numeroMarchas, Boolean tetoSolar, Boolean cambioAuto, double volumeCombustivel)
        {
            this.modelo = modelo;
            this.cor = cor;
            this.marca = marca;
            this.chassi = chassi;
            this.proprietario = proprietario;
            this.velocidadeMax = velocidadeMax;
            this.velocidadeAtual = velocidadeAtual;
            this.numeroPortas = numeroPortas;
            this.numeroMarchas = numeroMarchas;
            this.tetoSolar = tetoSolar;
            this.cambioAuto = cambioAuto;
            this.volumeCombustivel = volumeCombustivel;
        }

        public string Modelo { get => modelo; set => modelo = value; }
        public string Cor { get => cor; set => cor = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Chassi { get => chassi; set => chassi = value; }
        public string Proprietario { get => proprietario; set => proprietario = value; }
        public double VelocidadeMax { get => velocidadeMax; set => velocidadeMax = value; }
        public double VelocidadeAtual { get => velocidadeAtual; set => velocidadeAtual = value; }
        public int NumeroPortas { get => numeroPortas; set => numeroPortas = value; }
        public int NumeroMarchas { get => numeroMarchas; set => numeroMarchas = value; }
        public bool TetoSolar { get => tetoSolar; set => tetoSolar = value; }
        public bool CambioAuto { get => cambioAuto; set => cambioAuto = value; }
        public double VolumeCombustivel { get => volumeCombustivel; set => volumeCombustivel = value; }
    }
}
