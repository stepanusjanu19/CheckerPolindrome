using System;

namespace CheckerPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================Aplikasi Checker Palindrome================");
            Console.WriteLine("Ketik 'exit' untuk keluar. \n");

            while (true)
            {
                Console.WriteLine("Masukkan kalimat: ");
                string? input = Console.ReadLine();

                if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase)) {
                    Console.WriteLine("Aplikasi dihentikan");
                    break;
                }

                bool output = IsPalindrome(input);
                Console.WriteLine($"Apakah palindrom ?{output}");
            }
        }

        static bool IsPalindrome(string? word)
        {
            if (string.IsNullOrWhiteSpace(word))
                return false;

            word = word.ToLower().Replace(" ", "");

            int left = 0;
            int right = word.Length - 1;

            while (left < right)
            {
                if (word[left] != word[right])
                    return false;

                left++;
                right--;
            }
            return true;
        }
    }
}