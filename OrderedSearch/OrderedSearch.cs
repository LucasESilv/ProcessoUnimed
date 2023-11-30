namespace ProcessoUnimed.OrderedSearch
{
    public class OrderedSearch
    {
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                // Se o número estiver no meio da lista, retorna a posição
                if (arr[middle] == target)
                    return middle;
                // Se o número for maior, ignora a metade esquerda
                if (arr[middle] < target)
                    left = middle + 1;
                // Se o número for menor, ignora a metade direita
                else
                    right = middle - 1;
            }
            // Se o número não estiver presente na lista
            return -1;
        }
    }
}