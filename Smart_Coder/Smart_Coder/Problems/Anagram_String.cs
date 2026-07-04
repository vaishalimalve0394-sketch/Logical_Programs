using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Coder.Problems
{
    public class Anagram_String
    {
        string sentence = "I will listen music in silent at night because stressed due to such thing eating desserts";

        string[]? words;

        public void CheckAnagram()
        {
            words = sentence.Split(' ');
            List<string[]> pairs = new List<string[]>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (IsAnagram(words[i], words[j]))
                    {
                        Console.WriteLine($"Anagram pair found: {words[i]} and {words[j]}");
                        pairs.Add(new string[] { words[i], words[j] });
                    }
                }
            }
            Console.WriteLine("\n");
            PrintPairs(pairs);

        }

        public bool IsAnagram(string first, string second)
        {
            var a = first.Replace(" ", "").ToLower().ToCharArray();
            var b = second.Replace(" ", "").ToLower().ToCharArray();

            Array.Sort(a);
            Array.Sort(b);

            return new string(a) == new string(b);
        }

        private void PrintPairs(List<string[]> pairs)
        {
            Console.WriteLine("Anagram Program By using For Loop");
            var sb = new StringBuilder();
            Console.WriteLine("[");

            for (int i = 0; i < pairs.Count; i++)
            {
                sb.Append('[');
                sb.Append($"\"{pairs[i][0]}\", \"{pairs[i][1]}\"");
                sb.Append(']');

                if (i < pairs.Count - 1)
                    sb.Append(",\n");
            }
            Console.WriteLine(sb.ToString());
            Console.WriteLine("]");
        }
    }
}
