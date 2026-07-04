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
        }
    }
}