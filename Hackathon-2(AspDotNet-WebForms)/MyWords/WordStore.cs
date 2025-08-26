using System.Collections.Generic;

namespace SampleWebFormsApp
{
    internal class WordStore
    {
        public static Dictionary<string, string> Words = new Dictionary<string, string>
    {
        { "sequel", "subsequent event" },
        { "Adulation", "Excessive flattery" },
        { "Fun", "enjoy" }
    };

        public static bool ContainsWord(string word)
        {
            return Words.ContainsKey(word);
        }

        public static void AddOrUpdate(string word, string translation)
        {
            Words[word] = translation;
        }

        public static Dictionary<string, string> GetAllWords()
        {
            return Words;
        }
    }
}