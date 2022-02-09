using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {




            int N = Convert.ToInt32(Console.ReadLine());
            int i = 0;




            if (N < 50)

            {
                int[] divided = new int[N / 3];
                for (int b = 3; b <= N; b++)
                {
                    if (b % 3 == 0) { divided[i] = b; i++; }
                }
                foreach (int num in divided)
                { Console.WriteLine(num); }
            }

            else if (N > 50 && N < 100)
            {
                int[] divided = new int[N / 5];
                for (int b = 5; b <= N; b++)
                {
                    if (b % 5 == 0) { divided[i] = b; i++; }
                }
                foreach (int num in divided)
                { Console.WriteLine(num); }
            }
            else if (N > 100)
            {
                int[] divided = new int[N /8 ];
                for (int b = 8; b <= N; b++)
                {
                    if (b % 8 == 0) { divided[i] = b; i++; }
                }
                foreach (int num in divided)
                { Console.WriteLine(num); }
            }

            }
            
        }
}
