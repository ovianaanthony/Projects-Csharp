using System;
using System.Threading;

namespace Stopwatch{
    public static class Timer{
        public static void Menu(){
            Console.Clear();
            Console.WriteLine("Caso deseje sair insira 'quit', caso contrário qualquer outra tecla");
            string z = Console.ReadLine().ToLower();
            if (z.Equals("quit")){ 
                Console.WriteLine("Cronômetro encerrado");
                System.Environment.Exit(0);
            }
            Console.WriteLine("Digite a quantidade total desejada cronometrada em segundos");
            int time = Convert.ToInt32(Console.ReadLine());
            Start(time);
        }
        static void Start(int x){
            Console.WriteLine("Digite se a contagem desejada deve ser feita em: min ou seg ");
            string contagem = Console.ReadLine();
            if(contagem=="seg"){
                for(int i = 1;i<=x;i++){
                Console.Clear();
                Console.WriteLine(i + " segundos");
                Thread.Sleep(1000); 
                }
                Console.Clear();
                Console.WriteLine("Stopwatch finalizado");
                Thread.Sleep(2000);
                Menu();
            } 
            if (contagem=="min"){
                int minutos = 0;
                int seg = 0;
                for(int segundos = 1;segundos<=x;segundos++){
                    Console.Clear();
                    if(segundos==60){
                        minutos++;
                        segundos=0;
                    }
                    Console.WriteLine($"Tempo: {minutos}:{segundos}");
                    Thread.Sleep(1000);
                    seg++;
                    if (seg == x){
                        break;
                    }
                }
                Console.Clear();
                Console.WriteLine("Stopwatch finalizado");
                Thread.Sleep(2000);   
                Menu();
            }
       }
    }
}
