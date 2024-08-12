﻿using System;
using System.Collections;
using System.Collections.Generic;

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
            List <string> words = new List<string>();
            //words.Add(lines.Split(" "));
            foreach (string e in lines)
            {
                foreach (string str in e.Split(' '))
                {
                    if (char.IsUpper(str[0]))
                    { 
                        words.Add(str);
                    }
                }
            }
            words.Reverse();
            foreach (string str in words) 
            {
                stringAll += str + " ";
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

            Для разбиения строки на слова можно использовать функцию text.Split(' ')

            Вы можете проверить, является ли символ заглавным с помощью Char.IsUpper

            Используйте List<string>, чтобы сохранить все найденные в тексте слова с большой буквы

            У списка есть метод Reverse(), переворачивающий список

            Склеить отдельные слова в текст можно ещё одним циклом, а можно специальным методом string.Join(" ", words.ToArray())

            Имейте в виду, "".Split(' ') возвращает пустую строку! Обращение к нулевому символу пустой строки приведёт к ошибке ArgumentOutOfRangeException.
            */
        }
    }
}