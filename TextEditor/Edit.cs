using System;
using System.IO;

namespace TextEditor
{
    public static class Edit{

        public static void Menu(){
            Console.Clear();
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo\t2 - Criar novo arquivo\t 0 - Sair\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option){
                case 0: System.Environment.Exit(0);
                break;
                case 1: Abrir(); 
                break;
                case 2: Editar();
                break;
                default: 
                break;
        }
        static void Abrir(){
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo? ");
            string path = Console.ReadLine();
            using(var file = new StreamReader(path)){
                // lê arquivo até o final
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
        static void Editar(){
            Console.Clear();
            Console.WriteLine("Digite seu texto abaixo: (ESC para sair) ");
            Console.WriteLine("------------------- ");
            string text = "";
            
            // enquanto a tecla é diferente de ESC, continua digitando
            do{
                text+=Console.ReadLine();
                text+= Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);
                Salvar(text);
        }

        static void Salvar(string text){
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            // Sempre que abrir um arquivo, fechá-lo | FUNÇÃO using fecha automatico para nós
            // StreamWriter abre o arquivo para escrita, Reader para leitura 
            using (var file = new StreamWriter(path)){
                file.Write(text);
            }

            // exemplo de arquivo de entrada path 'C:/dev/testando.txt'

            Console.WriteLine($"Arquivo {path} salvo com sucesso!");
            Console.ReadLine();
            Menu();
        }
    }
    }    
}
