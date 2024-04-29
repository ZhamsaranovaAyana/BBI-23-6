using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class Program
    {
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

        class Task1 : Task
        {
            public Task1(string text) : base(text)
            {
                string rus = "абвгдежзийклмнопрстуфхцчшщъыьэюя";
                var top = new Dictionary<char, int>();
                foreach (char x in text)
                {
                    char sym = char.ToLower(x);
                    if (rus.Contains(sym))
                    {
                        if (top.ContainsKey(sym)) { top[sym]++; }
                        else { top.Add(sym, 1); }
                    }
                }
                int all = 0;
                foreach (int x in top.Values){ all += x; }
                foreach (var x in top)
                {
                    result += $"{x.Key}: {(float)x.Value * 100 / all}%\n";
                }
            }
        }
        class Task3 : Task
        {
            public Task3(string text) : base(text)
            {
                int sp = text.IndexOf(' ');
                string[] strs = { text.Substring(0, sp + 1) };
                int j = 0;
                while (sp != -1)
                {
                    int nsp = text.IndexOf(" ", sp + 1);
                    int nextsp = text.IndexOf(" ", sp + 1);
                    if (nextsp == -1)
                    {
                        nextsp = text.Length-1;
                    }
                    if ((strs[j].Length + nextsp - sp) <= 50)
                    {
                        strs[j] += text.Substring(sp + 1, nextsp - sp);
                    }
                    else
                    {
                        strs = strs.Append(text.Substring(sp + 1, nextsp - sp)).ToArray();
                        j++;
                    }
                    sp = nsp;
                }
                foreach (string str in strs) { result+= str + "\n"; }
            }
        }
        class Task6 : Task
        {
            public Task6(string text) : base(text)
            {
                string glas = "аеёиоуыэюяaoeiuy";
                string[] words = text.Split(' ');
                var slogs = new Dictionary<int, int>();
                foreach (string word in words)
                {
                    int sl = word.Count(x => glas.Contains(char.ToLower(x)));
                    if (slogs.ContainsKey(sl)) { slogs[sl]++; }
                    else { slogs.Add(sl, 1); }
                }
                foreach (var s in slogs)
                {
                    if (s.Key != 0) { result += $"{s.Key} слогов(-а): {s.Value}\n"; }
                }
            }
        }
        class Task12 : Task
        {
            public Task12(string text) : base(text)
            {
                result = "";
                string res1 = text;
                string[] words = text.Split(new char[] { ' ', ',', '.' });
                var codes = new Dictionary<string, int>();
                int c = 0;
                codes.Add(words[0], c);
                res1 = $"|{codes[words[0]]}|" + res1.Substring(words[0].Length);
                c++;
                foreach (var word in words)
                {
                    if (word != "")
                    {
                        if (codes.ContainsKey(word))
                        {
                            foreach (char delimeter in new char[] { ' ', ',', '.' })
                            {
                                res1 = res1.Replace($" {word}{delimeter}", $" |{codes[word]}|{delimeter}");
                            }
                        }
                        else
                        {
                            codes.Add(word, c);
                            foreach (char delimeter in new char[] { ' ', ',', '.' })
                            {
                                res1 = res1.Replace($" {word}{delimeter}", $" |{codes[word]}|{delimeter}");
                            }
                            c++;
                        }
                    }
                }
                result += res1 + "\nРасшифрованный текст:\n";
                string res2 = res1;
                foreach (var code in codes)
                {
                    res2 = res2.Replace($"|{code.Value}|", code.Key);
                }
                result += res2;
            }
        }
        class Task13 : Task
        {
            public Task13(string text) : base(text)
            {
                result = "";
                string[] words = text.Split(' ');
                var dict = new Dictionary<char, int>();
                foreach (var word in words)
                {
                    char s = char.ToLower(word[0]);
                    if (dict.ContainsKey(s)) { dict[s]++; }
                    else { dict.Add(s, 1); }
                }
                foreach (var x in dict)
                {
                    result += $"{x.Key}: {(float)x.Value * 100 / words.Length}%\n";
                }
            }
        }
        class Task15 : Task
        {
            public Task15(string text) : base(text)
            {
                result = "";
                decimal res_dec = 0;
                int i = 0;
                while (i < text.Length)
                {
                    string sub = "";
                    while ((char.IsDigit(text[i]) | ((text[i] == ',') & sub != "" & sub.Count(f => (f == ',')) == 0)) & i < text.Length)
                    {
                        sub += text[i];
                        i++;
                    }
                    if (sub != "")
                    {
                        res_dec += decimal.Parse(sub);
                    }
                    else { i++; }
                }
                result = res_dec.ToString();
            }
        }

        static void Main(string[] args)
        {
            string input_text = "Первое кругосветное путешествие было осуществлено флотом, возглавляемым португальским исследователем Фернаном Магелланом. Путешествие началось 20 сентября 1519 года, когда флот, состоящий из пяти кораблей и примерно 270 человек, отправился из порту Сан-Лукас в Испании. Хотя Магеллан не закончил свое путешествие из-за гибели в битве на Филиппинах в 1521 году, его экспедиция стала первой, которая успешно обогнула Землю и доказала ее круглую форму. Это путешествие открыло новые морские пути и имело огромное значение для картографии и географических открытий.";

            Console.WriteLine("1:");
            var obj1 = new Task1(input_text);
            Console.WriteLine($"{obj1}\n");

            Console.WriteLine("3:");
            var obj3 = new Task3(input_text);
            Console.WriteLine($"{obj3}\n");

            Console.WriteLine("6:");
            var obj6 = new Task6(input_text);
            Console.WriteLine($"{obj6}\n");

            Console.WriteLine("12:");
            var obj12 = new Task12(input_text);
            Console.WriteLine($"{obj12}\n");

            Console.WriteLine("13:");
            var obj13 = new Task13(input_text);
            Console.WriteLine($"{obj13}\n");

            Console.WriteLine("15:");
            var obj15 = new Task15(input_text);
            Console.WriteLine($"{obj15}\n");
        }
    }
}