using Smart_Coder;
using Smart_Coder.Problems;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Inside the Smart Coder Project!");
        Console.WriteLine("\n");
        RunAnagram();
        static void RunAnagram()
        {
            Console.WriteLine("Anagram Program");
            var anagram = new Anagram_String();
            anagram.CheckAnagram();

            Console.WriteLine("\n");
            Console.WriteLine("Anagram Program By using Linq Query");
            var anagramLinq = new Anagram_Linq();
            anagramLinq.CheckAnagram();

            Console.WriteLine("\n");
            Console.WriteLine("Anagram Program By using Dictionary");
            var anagramDic = new Anagram_Dictionary();
            anagramDic.CheckAnagram();

            Console.WriteLine("\n");
            Console.WriteLine("First Non Repeating Character By using Dictionary");
            var nonRepeatingCharacter = new NonRepeatingCharacter();
            nonRepeatingCharacter.NonRepeatingChar("First");

            Console.WriteLine("\n");
            Console.WriteLine("All Non Repeating Character By using Dictionary");
            nonRepeatingCharacter.NonRepeatingChar("All");

            Console.WriteLine("\n");
            Console.WriteLine("First Non Repeating Character By using Linq Query");
            nonRepeatingCharacter.NonRepeatingChar_Linq("First");

            Console.WriteLine("\n");
            Console.WriteLine("All Non Repeating Character By using Linq Query");
            nonRepeatingCharacter.NonRepeatingChar_Linq("All");

            Console.WriteLine("\n");
            Console.WriteLine("First Non Repeating Character By using IndexOF & LastIndexOf");
            nonRepeatingCharacter.NonRepeatingChar_IndexOf("First");

            Console.WriteLine("\n");
            Console.WriteLine("All Non Repeating Character By using IndexOF & LastIndexOf");
            nonRepeatingCharacter.NonRepeatingChar_IndexOf("All");

            Console.WriteLine("\n");
            Console.WriteLine("First Non Repeating Character By using HashSet");
            nonRepeatingCharacter.NonRepeatingChar_HashSet("First");

            Console.WriteLine("\n");
            Console.WriteLine("All Non Repeating Character By using HashSet");
            nonRepeatingCharacter.NonRepeatingChar_HashSet("All");

            Console.WriteLine("\n");
            Console.WriteLine("First Non Repeating Character By using Array");
            nonRepeatingCharacter.NonRepeatingChar_Array("First");

            Console.WriteLine("\n");
            Console.WriteLine("All Non Repeating Character By using Array");
            nonRepeatingCharacter.NonRepeatingChar_Array("All");
        }
    }
}