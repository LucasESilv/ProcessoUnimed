namespace ProcessoUnimed.SimpleOrdering
{
    public class SimpleOrdering
    {
        public void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}