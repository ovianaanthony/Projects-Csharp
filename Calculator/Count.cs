using System;

namespace Calculator{   

    public static class Count{
       public static void Menu(){
            Console.Clear();
            Console.WriteLine("Digite o nome da operação desejada: \t1 - Soma\t2 - Subtração\t3 - Divisão\t4 - Multiplicação \t5 - Encerrar");
            int operacao = Convert.ToInt32(Console.ReadLine());
            switch(operacao){
                case (1):
                    Soma();
                    break;
                case (2):
                    Subtracao();
                    break;
                case (3):
                    Divisao();
                    break;
                case (4):
                    Multiplicacao();
                    break;
                case (5):
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    Menu();
                    break;
            }
        }

        public static void Soma(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double v2 = Convert.ToDouble(Console.ReadLine()); 
            double somaVal = v1+v2;
            Console.WriteLine("O resultado da soma é " + somaVal);
            Console.ReadLine();
            Menu();
        }

        public static void Subtracao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double v2 = Convert.ToDouble(Console.ReadLine()); 
            double subtrai = v1-v2;
            Console.WriteLine($"O resultado da subtração é {subtrai}");
            Console.ReadLine();
            Menu();
        }

        public static void Divisao(){
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            double v2 = Convert.ToDouble(Console.ReadLine()); 
            double divideVal = v1/v2;
            Console.WriteLine($"O resultado da divisão é {divideVal}");
            Console.ReadLine();
            Menu();
        }

        public static void Multiplicacao(){
            Console.WriteLine("Digite o primeiro número: ");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double v2 = Convert.ToDouble(Console.ReadLine());
            double mult = v1*v2;
            Console.WriteLine($"O resultado da multiplicação é {mult}");
            Console.ReadLine();
            Menu();
        }
    }
}
