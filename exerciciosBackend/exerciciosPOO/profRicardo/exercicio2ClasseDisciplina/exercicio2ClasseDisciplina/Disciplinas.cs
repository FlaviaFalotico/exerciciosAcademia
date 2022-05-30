using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2ClasseDisciplina
{
    internal class Disciplinas
    {
        //atributos
        String nomeDisciplina;
        double cargaHoraria;
        
        public string NomeDisciplina { get => nomeDisciplina; set => nomeDisciplina = value; }
        
        public double CargaHoraria { get => cargaHoraria; set => cargaHoraria = value; }

        public Disciplinas()
        {
        }

        //construtor
        public Disciplinas(string nomeDisciplina, double cargaHoraria)
        {
            this.NomeDisciplina = nomeDisciplina;
            this.CargaHoraria = cargaHoraria;
        }       

        //metodos
        public void exibirDadosDisciplinas()
        {
            Console.WriteLine("A disciplina é " + nomeDisciplina + " e a carga horária é de " + cargaHoraria + " horas.");
        }
    }
}
