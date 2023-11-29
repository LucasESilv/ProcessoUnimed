namespace ProcessoUnimed.PalindromeChecker
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string word)
        {
            word = word.ToLower().Replace(" ", "");
            int left = 0;
            int right = word.Length - 1;
            while (left < right)
            {
                if (word[left] != word[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}