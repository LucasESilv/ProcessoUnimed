using System;

namespace ProcessoUnimed
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sequencia de Fibonacci
            ProcessoUnimed.FibonacciSequence.FibonacciSequence fibonacci = new ProcessoUnimed.FibonacciSequence.FibonacciSequence();
            int n = 15;
            fibonacci.PrintFibonacci(n);
            
            //Algoritmo de Ordenação, utilizei o mais utilizado que é o bubble sort
            int[] arrayToSort = { 64, 34, 25, 12, 22, 11, 90 };
            ProcessoUnimed.SimpleOrdering.SimpleOrdering sorter = new ProcessoUnimed.SimpleOrdering.SimpleOrdering();
            Console.WriteLine("Array antes da ordenação:");
            sorter.PrintArray(arrayToSort);
            sorter.BubbleSort(arrayToSort);
            Console.WriteLine("Array após a ordenação:");
            sorter.PrintArray(arrayToSort);

            //Busca em Lista Ordenada
            int[] OrderedNumbers = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
            Console.WriteLine("Digite um número para buscar na lista ordenada:");
            int Num = Convert.ToInt32(Console.ReadLine());
            int Result = ProcessoUnimed.OrderedSearch.OrderedSearch.BinarySearch(OrderedNumbers, Num);
            if (Num != -1)
                Console.WriteLine($"O número {Num} está na posição {Result} da lista.");
            else
                Console.WriteLine($"O número {Num} não está presente na lista.");

            //Verificação de palíndromos 
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

            //Árvore Binária Simples
            ProcessoUnimed.BinaryTree.BinaryTree tree = new ProcessoUnimed.BinaryTree.BinaryTree();
            int[] numbers = { 5, 3, 2, 4, 1, 6, 7, 8, 9, 10 }; // Números de 1 a 5
            foreach (var number in numbers)
            {
                tree.Insert(number);
            }
            Console.WriteLine("Árvore em ordem:");
            tree.InOrderTraversal(tree.Root);
        }
    }
}
