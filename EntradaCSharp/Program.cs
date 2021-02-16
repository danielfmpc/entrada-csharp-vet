using System;

namespace EntradaCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as cores");
            string x = Console.ReadLine();

            string[] v = Console.ReadLine().Split(' ');

            Console.WriteLine(x);
            Console.WriteLine(v[0]);
            Console.WriteLine(v[1]);
            Console.WriteLine(v[2]);
        }
    }
}
