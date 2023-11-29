using System;

namespace ProcessoUnimed
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessoUnimed.FibonacciSequence.FibonacciSequence fibonacci = new ProcessoUnimed.FibonacciSequence.FibonacciSequence();
            int n = 15;
            fibonacci.PrintFibonacci(n);
            
            int[] arrayToSort = { 64, 34, 25, 12, 22, 11, 90 };
            ProcessoUnimed.SimpleOrdering.SimpleOrdering sorter = new ProcessoUnimed.SimpleOrdering.SimpleOrdering();
            Console.WriteLine("Array antes da ordenação:");
            sorter.PrintArray(arrayToSort);
            sorter.BubbleSort(arrayToSort);
            Console.WriteLine("Array após a ordenação:");
            sorter.PrintArray(arrayToSort);

            Console.WriteLine("Digite a palavra para sabermos se é um palíndromo");
            string input = Console.ReadLine();
            ProcessoUnimed.PalindromeChecker.PalindromeChecker checker = new ProcessoUnimed.PalindromeChecker.PalindromeChecker();
            bool isPalindrome = checker.IsPalindrome(input);
            if (isPalindrome)
            {
                Console.WriteLine($"A palavra '{input}' é um palíndromo.");
            }
            else
            {
                Console.WriteLine($"A palavra '{input}' não é um palíndromo.");
            }
        }
    }
}
