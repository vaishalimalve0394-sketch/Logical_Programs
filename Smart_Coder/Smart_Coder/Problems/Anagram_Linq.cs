using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Coder.Problems
{
    public class Anagram_Linq
    {
        string sentence = "I will listen music in silent at night because stressed due to such thing eating desserts";

        string[]? words;

        public void CheckAnagram()
        {
            words = sentence.Split(' ');

            // Group words by their sorted-letter signature (case-insensitive)
            var groups = words
                .GroupBy(word => new string(word.ToLower().OrderBy(c => c).ToArray()))
                .Where(group => group.Count() > 1)
                .ToList();

            // Generate all pairs within each anagram group
            var pairs = groups
                .SelectMany(group =>
                    group.SelectMany((word, index) =>
                        group.Skip(index + 1).Select(other => new[] { word, other })))
                .ToList();

            PrintPairs(pairs);
        }

        private void PrintPairs(List<string[]> pairs)
        {
            Console.WriteLine("[");
            string result = string.Join(",\n", pairs.Select(p =>
                $"[\"{p[0]}\", \"{p[1]}\"]"));

            Console.WriteLine(result);
            Console.WriteLine("]");
        }
    }
}
