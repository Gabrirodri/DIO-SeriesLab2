using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dio.Series
{
    public class Serie : EntidadeBase
    {
        //atributos
        private Genero genero { get; set; }
        private string titulo { get; set; }
        private string descricao { get; set; }
        private int ano { get; set; }

        private bool Excluido { get; set; }

        //metodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.genero = genero;
            this.titulo = titulo;
            this.descricao = descricao;
            this.ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: -" + this.genero + Environment.NewLine;
            retorno += "Titulo: -" + this.titulo + Environment.NewLine;
            retorno += "Descrição: -" + this.descricao + Environment.NewLine;
            retorno += "Ano de Inicio: -" + this.ano + Environment.NewLine;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.titulo;
        }
        public int retornaId()
        {
            return this.Id;
        }
        public void Excluir()
        {
            this.Excluido = true;

        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
    }

}
