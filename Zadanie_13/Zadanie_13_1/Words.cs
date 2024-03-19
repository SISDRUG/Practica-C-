using System;
namespace Zadanie_13_1
{
    public class WordEvent
    {
        public string Word { get; set; }
        public WordEvent(string word)
        {
            Word = word;
        }
    }
    public class WordProvider
    {
        public event EventHandler<WordEvent> WordGenerated;
        public string GetWord1()
        {
            string word = "Hipopotam";
            OnWordGenerated(word);

            return word;
        }


        public string GetWord2()
        {
            string word = "smart";
            OnWordGenerated(word);

            return word;
        }

        public string GetWord3()
        {
            string word = "ocean";
            OnWordGenerated(word);

            return word;
        }

        public string GetWords()
        {
            string result = "";
            result += GetWord1() + " ";
            result += GetWord2() + " ";
            result += GetWord3();

            return result;
        }
        protected void OnWordGenerated(string word)
        {
            WordGenerated.Invoke(this, new WordEvent(word));
        }
    }
}
