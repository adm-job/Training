using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    internal class DictionaryTraining
    {

        ////////////////// Массивы и листы позволяют нам установить соответствие между числом 
        ////////////////// (индексом массива) и чем-то: например, массив string[] по числу дает доступ
        ////////////////// к строке.
        ////////////////// Иногда хочется установить, например, соответствие между строкой и числом.

        ////////////////// Задача: дан массив строк, подсчитать для каждой строки количество вхождений

        ////////////////var array = new[] { "A", "AB", "B", "A", "B", "B" };

        //////////////////Удобно делать это с помощью словаря - сущности, которая ассоциирует между собой
        //////////////////значения любых типов
        ////////////////var dictionary = new Dictionary<string, int>();

        ////////////////foreach (var e in array)
        ////////////////{
        ////////////////    if (!dictionary.ContainsKey(e)) dictionary[e] = 0;
        ////////////////    dictionary[e]++;
        ////////////////}

        ////////////////foreach (var e in dictionary)
        ////////////////{
        ////////////////    Console.WriteLine(e.Key + "\t" + e.Value);
        ////////////////}
        private static List<string> GetContacts()
        {
            List<string> contacts = new List<string>();
            contacts.Add("Ваня:v@mail.ru");
            contacts.Add("Вася:vasiliy@gmail.com");
            contacts.Add("Ваня:ivan@grozniy.ru");
            contacts.Add("Саша:sasha1995@sasha.ru");
            contacts.Add("Саша:alex@nd.ru");
            contacts.Add("Паша:pavel.egorov@urfu.ru");
            contacts.Add("Юрий:dolg@rukiy.ru");
            contacts.Add("Гена:genadiy.the.best@inbox.ru");
            return contacts;
        }

        private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
        {
            var dictionary = new Dictionary<string, List<string>>();
            
            contacts.AddRange(GetContacts());

            foreach (var name in contacts)
            {
                var nameFriend = name.Split(':')[0];
                var namePrefix = (nameFriend.Length <= 2) ? nameFriend : nameFriend.Substring(0,2);
                var emailFriend = name.Split(':')[1];

                if (!dictionary.ContainsKey(namePrefix))
                {
                    dictionary.Add(namePrefix, new List<string>() { name });
                    //dictionary[nameFriend].Add(emailFriend);
                }
                else
                {
                    dictionary[namePrefix].Add(name);
                }


            }

            return dictionary;
            
        }
        public static void StartDictionary()
        {

            var dict = OptimizeContacts(new List<string>());
        }
    }
}
