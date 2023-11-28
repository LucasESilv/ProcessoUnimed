using System;

namespace ProcessoUnimed
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessoUnimed.FibonacciSequence.Fibonacci fibonacci = new ProcessoUnimed.FibonacciSequence.Fibonacci();
            int n = 15;
            fibonacci.PrintFibonacci(n);
        }
    }
}
