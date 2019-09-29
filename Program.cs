using System;
using LevenshteinAutomaton;

namespace SpellCheckerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var vocabular = new [] { "мир", "мор", "май"};
            var word = "мур";
            var spellChecker = new SpellChecker(vocabular);
            var corrections1T = spellChecker.GetCorrections1T(word);
            Console.WriteLine("Corrections with distance = 1");
            foreach (var correction in corrections1T)
                Console.WriteLine(correction);
            var corrections2T = spellChecker.GetCorrections2T(word);
            Console.WriteLine("Corrections with distance = 2");
            foreach (var correction in corrections2T)
                Console.WriteLine(correction);
        }
    }
}
