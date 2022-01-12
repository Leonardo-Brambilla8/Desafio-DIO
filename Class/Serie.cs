using System;
namespace DIO.desafio
{
    public class Serie : EntidadeBase
    {
        private Genero Genero {get;set;}
        private string Titulo {get;set;}
        private string Descricao {get; set;}
        private int Ano{get; set;}
        private int Star{get; set;}

        private bool Excluido {get; set;}
    
        public Serie(int id, Genero genero, string titulo, string descricao, int ano, int star){
            this.id = id;
            this.Star = star;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }
        public override string ToString(){
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Estelas: " + this.Star + Environment.NewLine;
            retorno += "Excluido " + this.Excluido;
            return retorno;
        }
        public string retornaTitulo(){
            return this.Titulo;
        }
        public int retornaId(){
            return this.id;
        }
        public bool retornaExcluido(){
            return this.Excluido;
        }
        public void Excluir(){
            this.Excluido = true;
        }
    }
}