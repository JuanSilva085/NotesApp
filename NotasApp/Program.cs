using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using AppNotes.Data;

namespace NotasApp
{
    class Program
    {
       static List<Nota> notas = new List<Nota>();
       
        static void Main(string[] args) 
        {

            bool execution = true;

            while (execution)
            {
                Console.WriteLine("Olá, este é o seu aplicativo de notas!");
                Console.WriteLine("Por favor, escolha uma opção:"); 
                Console.WriteLine("1- Adicionar Nota"); 
                Console.WriteLine("2- Visualizar Notas"); 
                Console.WriteLine("3- Editar Notas"); 
                Console.WriteLine("4- Excluir Nota");
                Console.WriteLine("5- Sair");
                int option = Convert.ToInt32(Console.ReadLine());


                switch(option)
                {
                    case 1:
                        AdicionarNota();
                        break;
                    case 2:
                        VisualizarNotas();
                        break;
                    case 3:
                        EditarNotas();
                        break;
                    case 4:
                        ExcluirNota();
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        execution = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
            static void AdicionarNota()
            {
                Console.WriteLine("Adicione um título a nota:");
                string titulo = Console.ReadLine();
                Console.WriteLine("Adicione um conteúdo a nota:");
                string conteudo = Console.ReadLine();    
                Nota nota = new Nota(titulo , conteudo);
                notas.Add(nota);

               Console.WriteLine("Sua nota foi adicionada!");
            }
        
        static void VisualizarNotas()
        {
            if(notas.Count == 0)
            {
                Console.WriteLine("Ops! Não há nenhuma nota cadastrada.");
                return;
            }

            foreach (var nota in notas)
            {
                Console.WriteLine("Título: " + nota.Titulo);
                Console.WriteLine("Conteúdo: " + nota.Conteudo);
            }
        }

        static void EditarNotas()
        {
            Console.WriteLine("Escreva o título da nota que deseja editar");
            string searchNote = Console.ReadLine();

            Nota nota = notas.Find(n => n.Titulo == searchNote);

            if(nota != null)
            {
                Console.WriteLine("Escreva o novo título da nota:");
                string novoTitulo = Console.ReadLine();
                Console.WriteLine("Escreva o novo conteúdo da nota:");
                string novoConteudo = Console.ReadLine();

                nota.Titulo = novoTitulo;
                nota.Conteudo = novoConteudo;

                Console.WriteLine("Sua nota foi atualizada!");
            }
            else
            {
                Console.WriteLine("Ops! Não foi encontrada nenhuma nota.");
            }
        }

        static void ExcluirNota()
        {
            Console.WriteLine("Escreva o título da nota");
            string deleteNote = Console.ReadLine();

            Nota nota = notas.Find(n => n.Titulo == deleteNote);

            if(nota != null) 
            {
                notas.Remove(nota);
                Console.WriteLine("A nota foi excluída com sucesso!");
            }
            else
            {
                Console.WriteLine("Ops! Não foi encontrada nenhuma nota.");
            }
        }
    }
}