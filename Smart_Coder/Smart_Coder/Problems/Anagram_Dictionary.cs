using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Smart_Coder.Problems
{
    public class Anagram_Dictionary
    {
        string sentence = "I will listen music in silent at night because stressed due to such thing eating desserts";

        string[]? words;

        public void CheckAnagram()
        {
            words = sentence.Split(' ');

            // Dictionary: key = sorted-letter signature, value = list of matching words
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            foreach (var word in words)
            {
                string key = GetSignature(word);

                if (!map.ContainsKey(key))
                {
                    map[key] = new List<string>();
                }

                map[key].Add(word);
            }

            PrintPairs(map);
        }

        private string GetSignature(string word)
        {
            char[] chars = word.ToLower().ToCharArray();
            Array.Sort(chars);
            return new string(chars);
        }

        private void PrintPairs(Dictionary<string, List<string>> map)
        {
            List<string> output = new List<string>();

            foreach (var entry in map)
            {
                List<string> group = entry.Value;

                if (group.Count > 1)
                {
                    // generate all pairs within this group
                    for (int i = 0; i < group.Count; i++)
                    {
                        for (int j = i + 1; j < group.Count; j++)
                        {
                            output.Add($"[\"{group[i]}\", \"{group[j]}\"]");
                        }
                    }
                }
            }

            Console.WriteLine("[");
            string result = string.Join(",\n", output);
            Console.WriteLine(result);
            Console.WriteLine("]");
        }
    }
}
