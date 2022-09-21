using System.Security.Cryptography.X509Certificates;

namespace deliverable4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare Fibonacci array
            int[] fiboNum = new int[25];

            // Set first 2
            fiboNum[0] = 0;
            fiboNum[1] = 1;

            for (int i = 2; i < fiboNum.Length; i++)
            {
                fiboNum[i] = fiboNum[i - 2] + fiboNum[i - 1];
            }

            // display values
            for (int i = 0; i < fiboNum.Length; i++)
            {
                Console.WriteLine("Fibonacci number (" + i + ") = " + fiboNum[i]);
            }
            Console.ReadKey();
        }
    }
}