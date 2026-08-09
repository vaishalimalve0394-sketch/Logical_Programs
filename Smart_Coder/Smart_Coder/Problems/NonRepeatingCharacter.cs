using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Coder.Problems
{
    public class NonRepeatingCharacter
    {
        string str = "Vaishali".ToLower();

        internal void NonRepeatingChar(string v)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }
            foreach (char c in str)
            {
                if (charCount[c] == 1)
                {
                    if(v == "All")
                    {
                        Console.Write(c + " ");
                    }
                    else
                    {
                        Console.WriteLine(c);
                        return;

                    }
                }
            }
        }

        internal void NonRepeatingChar_Array(string v)
        {
            int[] count = new int[26];

            foreach (char c in str)
            {
                count[c - 'a']++;
            }

            foreach (char c in str)
            {
                if (count[c - 'a'] == 1)
                {
                    if (v == "All")
                    {
                        Console.Write(c+ " ");
                    }
                    else
                    {
                        Console.WriteLine(c);
                        break;
                    }
                }
            }
        }

        internal void NonRepeatingChar_HashSet(string v)
        {
            var duplicates = new HashSet<char>();
            var unique = new HashSet<char>();

            foreach (char c in str)
            {
                if (!unique.Add(c))
                {
                    duplicates.Add(c);
                }
            }

            if (v == "All")
            {
                unique.ExceptWith(duplicates);

                foreach (char c in unique)
                {
                    Console.Write(c + " ");
                }
            }
            else
            {
                foreach (char c in str)
                {
                    if (!duplicates.Contains(c))
                    {
                        Console.WriteLine(c);
                        break;
                    }
                }
            }
        }

        internal void NonRepeatingChar_IndexOf(string v)
        {
            foreach (char c in str)
            {
                if(str.IndexOf(c) == str.LastIndexOf(c))
                {
                    if (v == "All")
                    {
                        Console.Write(c+ " ");
                    }
                    else
                    {
                        Console.WriteLine(c);
                        break;
                    }  
                }
            }
        }

        internal void NonRepeatingChar_Linq(string v)
        {
            if (v == "All")
            {
                var result = str.GroupBy(c => c).Where(g => g.Count() == 1).
                Select(g => g.Key);
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                var result = str.GroupBy(c => c).Where(g => g.Count() == 1).
                Select(g => g.Key).FirstOrDefault();
                Console.WriteLine(result);
            }
            
        }
    }
}
