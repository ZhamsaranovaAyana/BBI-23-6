//Task 1 "На вход подается текст. На выход - целое число. Подсчитать сколько слов в тексте."

//using System;
//namespace WordCounter
//{
//    class Program
//    {
//        static int CountWords(string text)
//        {
//            int wordCount = 0;
//            bool inWord = false;

//            foreach (char c in text)
//            {
//                if (char.IsLetterOrDigit(c))
//                {
//                    if (!inWord)
//                    {
//                        inWord = true;
//                        wordCount++;
//                    }
//                }
//                else
//                {
//                    inWord = false;
//                }
//            }

//            return wordCount;
//        }

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите текст:");
//            string text = Console.ReadLine();

//            int wordCount = CountWords(text);

//            Console.WriteLine($"Количество слов: {wordCount}");
//        }
//    }
//}


//Task 2  "На вход попадается текст.На выход - массив строк. Выписать последние слова всех предложений." 

//using System;
//namespace LastWordsOfSentences
//{
//    class Program
//    {
//        static string[] GetLastWordsOfSentences(string text)
//        {
//            string[] sentences = text.Split('.');
//            string[] lastWords = new string[sentences.Length];

//            for (int i = 0; i < sentences.Length; i++)
//            {
//                string sentence = sentences[i].Trim();
//                int lastSpaceIndex = sentence.LastIndexOf(' ');
//                if (lastSpaceIndex != -1)
//                {
//                    lastWords[i] = sentence.Substring(lastSpaceIndex + 1);
//                }
//            }

//            return lastWords;
//        }

//        static void Main(string[] args)
//        {
//            Console.WriteLine("Введите текст:");
//            string text = Console.ReadLine();

//            string[] lastWords = GetLastWordsOfSentences(text);

//            Console.WriteLine("Последние слова предложений:");
//            foreach (string lastWord in lastWords)
//            {
//                Console.WriteLine(lastWord);
//            }
//        }
//    }
//}

