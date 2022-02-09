using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int SUM = 0;
            int D = 0;


            while (N>0)
            {
                D = N % 10; SUM += D; N = N / 10;
            
            }Console.WriteLine(SUM);
            
            
        }
    }    
} 
