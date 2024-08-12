using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Training
{
    internal class ListTraining
    {
        static void Main(string[] args)
        {
            string[] _inputStr = new[] { "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ",
                "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой",
                "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть",
                "если особенно упорно подойдешь к делу",
                "будет Трудно конечнО",
                "Код ведЬ не из простых",
                "очень ХОРОШИЙ код",
                "то у тебя все получится",
                "и я буДу Писать тЕбЕ ещечао"};

            Console.WriteLine(DecodeMessage(_inputStr));
        }
        private static string DecodeMessage(string[] lines)
        {
            string stringAll = "";
            foreach (var line in lines.Reverse())
            {
                foreach (var word in line.Split(" ").Reverse())
                {
                    if (word.Length != 0 && char.IsUpper(word[0]))
                    {
                        stringAll += word + " ";
                    }
                }
            }
            return stringAll.Trim();
            /* 
            List<int> list = new List<int>();

	        list.Add(0);
	        list.Add(2);
	        list.Add(3);
	        list.Insert(1, 1);
	        list.RemoveAt(0);

	        foreach (var e in list)
		        Console.WriteLine(e);

            Для разбиения строки на слова функция text.Split(' ')

            Является ли символ заглавным  Char.IsUpper

            Используйте List<string>, чтобы сохранить все найденные в тексте слова с большой буквы

            У списка есть метод Reverse(), переворачивающий список

            Склеить отдельные слова в текст можно ещё одним циклом, а можно специальным методом string.Join(" ", words.ToArray())

            "".Split(' ') возвращает пустую строку! Обращение к нулевому символу пустой строки приведёт к ошибке ArgumentOutOfRangeException.
            */
        }
    }
}