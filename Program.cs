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
            
            int[] arrayToSort = { 64, 34, 25, 12, 22, 11, 90 };
            ProcessoUnimed.SimpleOrdering.SimpleOrdering sorter = new ProcessoUnimed.SimpleOrdering.SimpleOrdering();
            Console.WriteLine("Array antes da ordenação:");
            sorter.PrintArray(arrayToSort);
            sorter.BubbleSort(arrayToSort);
            Console.WriteLine("Array após a ordenação:");
            sorter.PrintArray(arrayToSort);
        }
    }
}
