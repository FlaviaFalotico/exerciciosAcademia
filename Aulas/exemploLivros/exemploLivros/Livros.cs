using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploLivrosOO
{
    internal class Livros
    {
        //atributos
        //public String titulo { get => titulo; set => titulo = value; } - podemos usar também { get; set; }
        //emodificadores de acesso, conseguimos usar como privados e acessa-los
        public String titulo;
        public String autor;
        public int paginas;
        public int ano;
        public int edicao;
        
        //construtor
        public Livros(string tit, string aut, int pag, int an, int ed)
        {
            //this.titulo = titulo - estou recebendo na variavel titulo o valor titulo - forma mais comum em programação
            //this siginifca que é um atributo de dentro da classe
            titulo = tit;
            autor = aut;
            paginas = pag;
            ano = an;
            edicao = ed;
        }
              
        //metodos
        public void apresentarInformacoes()
        {
            Console.WriteLine(" O livro com título de " + titulo + ", do autor " + autor + ", com "
                + paginas + " páginas, " + "ano " + ano + ", edição " + edicao);
            //Console.WriteLine(" O livro com título de " + this.titulo + ", do autor " + this.autor + ", com "
            //+this.paginas + " páginas, " + "ano " + this.ano + ", edição " + this.edicao);
        }

    }
}
