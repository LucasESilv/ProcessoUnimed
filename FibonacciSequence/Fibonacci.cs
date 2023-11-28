namespace ProcessoUnimed.FibonacciSequence
{
    public class Fibonacci
    {
        public int PrintFibonacci(int n)
        {
            int a = 1, b = 1, result = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"o indicie número {i} é: {a}");
                result = a + b;
                a = b;
                b = result;
            }
            return result;
        }
    }
}
