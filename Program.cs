namespace Assignment_7._1._2
{
    internal class Program
    {
        static string MergeStrings(string word1, string word2)
        {
            int len1 = word1.Length;
            int len2 = word2.Length;
            int maxLength = Math.Max(len1, len2);

            char[] merged = new char[len1 + len2];
            int index = 0;

            for (int i = 0; i < maxLength; i++)
            {
                if (i < len1)
                    merged[index++] = word1[i];

                if (i < len2)
                    merged[index++] = word2[i];
            }

            return new string(merged);
        }

        static void Main()
        {
            string word1 = "abc";
            string word2 = "pqr";
            Console.WriteLine($"Output: \"{MergeStrings(word1, word2)}\"");

            string word3 = "ab";
            string word4 = "pqrs";
            Console.WriteLine($"Output: \"{MergeStrings(word3, word4)}\"");
        }
    }
}
