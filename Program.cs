using System;

namespace UltimaParcela
{
    class Program
    {
        static void Main(string[] args)
        {
            double Valor, Parcela;
            int Nparc; 
            string T;
            do{
            Console.Clear();
            print("Financiamento\n",6,1,4,0);
            Console.Write("Valor da Compra----------: R$ ");
            Valor = Convert.ToDouble(Console.ReadLine());
            Console.Write("Numeros de Parcelas------: ");
            Nparc = Convert.ToInt32(Console.ReadLine());
            Parcela = Valor/Nparc;
            Console.WriteLine($"Valor das parcelas-------: {Parcela:c}");
            DateTime agora = DateTime.Now;
            DateTime Ultima_parcela = DateTime.Today.AddMonths(+Nparc);
            string PF = Ultima_parcela.ToShortDateString();
            Console.WriteLine($"Sua ultima parcela sera--: {PF}");

            print("(S)air?:",0,4,0,6);
            T = Console.ReadLine().ToUpper();
            }
            while(T != "S");
            Console.Clear();
        }// fecha main

        static void print(String S, int COR_Caracter,int COR_Fundo, int X,int Y)
          {
            ConsoleColor CorC = (ConsoleColor)COR_Caracter;
            ConsoleColor CorF = (ConsoleColor)COR_Fundo;
            Console.ForegroundColor = CorC;
            Console.BackgroundColor = CorF;
            Console.SetCursorPosition(X, Y);
            Console.Write(S);
            Console.ResetColor();
          }//fecha print
    }
}
