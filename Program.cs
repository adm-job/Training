using System;
using System.Collections.Generic;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _inputStr = new[] { "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ",
                "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой",
                "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть",
                "если особенно упорно подойдешь к делу",
                "будет Трудно конечнО",
                "Код ведЬ не из простых",
                "очень ХОРОШИЙ код",
                "то у тебя все получится",
                "и я буДу Писать тЕбЕ ещечао"};

            string v = _inputStr[];
            Console.WriteLine(DecodeMessage(v));
        }
        private static string DecodeMessage(string[] lines)
        {
            string stringAll = "";
            List <string> words = new List<string>();

            words.Add(lines.Split(" "));

            //foreach (string e in lines)
            //if (char.IsUpper(e[0]))
            {
                Console.WriteLine(e);
                stringAll += e;
            }
            return stringAll;


            /* 
            List<int> list = new List<int>();

	        list.Add(0);
	        list.Add(2);
	        list.Add(3);
	        list.Insert(1, 1);
	        list.RemoveAt(0);

	        foreach (var e in list)
		        Console.WriteLine(e);
            */
        }
    }
}