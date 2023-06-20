using System;

class Program {
  public static void Main (string[] args) {
  
            
            Console.WriteLine("---- Multiplicando a Tabuada ----");
            PularLinha();
            

            int tabuada, contador = 0;

            Console.Write("Qual número deseja para a tabuada..: ");
            tabuada = Convert.ToInt32(Console.ReadLine());
            PularLinha();

            Console.WriteLine($"A tabuada que escolheu é do {tabuada}");

            do
            {
                Console.Write($" {tabuada} x {contador} = ");
                Console.WriteLine(tabuada * contador);
                contador = contador + 1;
                
            }
            while(contador <=10);          
        }

        static void ResetarCor()
        {
            Console.ResetColor();
        }

        static void LimparTela()
        {
            Console.Clear();
        }

        static void PularLinha()
        {
            Console.WriteLine();
        }
    }
