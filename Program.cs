namespace ChallengeLab_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Challenge Lab 3.1
             * Given a string, write a method that checks if it is a palindrome 
             * (is read the same backward as forward). Assume that string may 
             * consist only of lower-case letters.
             * 
             * Expected input and output
             * IsPalindrome("eye") → true
             * IsPalindrome("home") → false
            */

            bool validEntry = true;
            string word = "";
            do
            {
                Console.Clear();

                Console.WriteLine("Is It A Palindrome?\n\n");
                Console.Write("Enter a word: ");

                word = Console.ReadLine().ToLower();

                if ( word.Contains(' ') )
                {
                    Console.WriteLine("\n ERROR: Do not enter spaces or more than one word");
                    validEntry = false;
                    Console.ReadLine();
                }
            }
            while (!validEntry);

            if (IsPalindrome(word))
                Console.WriteLine($"\nThe word \"{word}\" IS a Palindrome");
            else Console.WriteLine($"\nThe word \"{word}\" IS NOT a Palindrome");
            Console.ReadLine();
        }

        public static bool IsPalindrome(string Word_)
        {
            bool result = true;
            int start = 0;
            int end = Word_.Length - 1;

            while (start < end)
            {
                // A letter did not match
                if (Word_[start] != Word_[end])
                {
                    result = false;
                    break;
                }

                start++; end--;
            }

            return result;
        }
    }
}