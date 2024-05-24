
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Program
    {
        class charCount
        {
            public char ch;
            public int count;
            public charCount(char ch, int count)
            {
                this.ch = ch;
                this.count = count;
            }
        }

        abstract class Task
        {
            protected string text;
            protected string result;
            protected Task(string text)
            {
                this.text = text;
            }
            public override string ToString()
            {
                return result;
            }
        }
        class Task13 : Task
        {
            List<charCount> chars = new List<charCount>();
            public Task13(string text) : base(text)
            {
                result = "";
                string[] words = text.Split(' ');
                foreach (var word in words)
                {
                    char s = char.ToLower(word[0]);
                    var el = chars.Find(item => item.ch == s);
                    if (el != null) { el.count++; }
                    else { chars.Add(new charCount(s, 1)); }
                }
                foreach (var x in chars)
                {
                    result += $"{x.ch}: {(float)x.count * 100 / words.Length}%\n";
                }
            }
        }

        static void Main(string[] args)
        {
            string input_text = "Первое кругосветное путешествие было осуществлено флотом, возглавляемым португальским исследователем Фернаном Магелланом. Путешествие началось 20 сентября 1519 года, когда флот, состоящий из пяти кораблей и примерно 270 человек, отправился из порту Сан-Лукас в Испании. Хотя Магеллан не закончил свое путешествие из-за гибели в битве на Филиппинах в 1521 году, его экспедиция стала первой, которая успешно обогнула Землю и доказала ее круглую форму. Это путешествие открыло новые морские пути и имело огромное значение для картографии и географических открытий.";


            Console.WriteLine("13:");
            var obj13 = new Task13(input_text);
            Console.WriteLine($"{obj13}\n");

        }
    }
}