// See https://aka.ms/new-console-template for more information
using System;
namespace DIO.desafio
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args){
            string opcaoUsuario = obterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "x"){
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                    throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = obterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado");
            Console.Clear();
        }
        private static void ExcluirSerie(){
            Console.Write("digite o id: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            System.Console.WriteLine("dejesa Realmente exluir:", repositorio.RetornaPorId(indiceSerie));
            string a = Console.ReadLine().ToUpper();
            switch (a){
                case "S":
                    repositorio.Exclui(indiceSerie);
                    break;
                case "CANCELAR":
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            } 
             

        }
        private static void VisualizarSerie(){
            Console.Write("Digite o id: ");
            //int indiceSerie = int.Parse(Console.ReadLine());
            //var serie = ;
            Console.WriteLine(repositorio.RetornaPorId(int.Parse(Console.ReadLine())));
        }
        private static void AtualizarSerie(){
            Console.Write("Digite o id: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            foreach (var i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0}-{1}",i,Enum.GetName(typeof(Genero),i));
            }
            System.Console.Write("Digite o genero: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            System.Console.WriteLine("titulo: ");
            string entradaTitulo = Console.ReadLine();

            System.Console.WriteLine("Quantas estelas: ");
            int estelas = int.Parse(Console.ReadLine());


            System.Console.WriteLine("Ano da Serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();
            Serie atualizaSerie = new Serie(id:indiceSerie,genero:(Genero)entradaGenero, titulo:entradaTitulo, ano:entradaAno, descricao:entradaDescricao,star:estelas);
        }
        private static void ListarSeries(){
            Console.WriteLine("Listar Serie");
            var lista = repositorio.Lista();
            if (lista.Count == 0 ){
                System.Console.WriteLine("nunhuma Serie cadastrada");
                return;
            }
            foreach (var serie in lista){
                var excluido = serie.retornaExcluido();
                Console.WriteLine("#ID {0}-{1}{2}",serie.retornaId(),serie.retornaTitulo(),(excluido ? "excluido":""));
            }
        }
        private static void InserirSerie(){
            System.Console.WriteLine("Inserir");
            foreach (var i in Enum.GetValues(typeof(Genero))){
                System.Console.WriteLine("{0}-{1}",i,Enum.GetName(typeof(Genero),i));
            }
            Console.Write("Digite o genero: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.Write("Digite o Título: ");
            string entradaTitulo = Console.ReadLine();
            Console.Write("Digite o Ano: ");
            int entradaAno = int.Parse(Console.ReadLine());
            Console.Write("Digite a Descrição: ");
            string entradaDescricao = Console.ReadLine();
            Console.Write("Quantas Estelas: ");
            int estelas = int.Parse(Console.ReadLine());
            
            Serie novaSerie = new Serie(id: repositorio.ProximoId(),genero:(Genero)entradaGenero, titulo:entradaTitulo, ano:entradaAno, descricao:entradaDescricao,star:estelas);
            repositorio.Insere(novaSerie);
        }
        private static string obterOpcaoUsuario(){
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Opção");
            Console.WriteLine("1- Listar Séries");
            Console.WriteLine("2- Inserir Nova Série");
            Console.WriteLine("3- Atualixar Série");
            Console.WriteLine("4- Excluir Série");
            Console.WriteLine("5- Visualizar Série");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("x- sair");
            System.Console.WriteLine();
            string opcaoUsuario = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return opcaoUsuario;
        }
        
    }
    
}
