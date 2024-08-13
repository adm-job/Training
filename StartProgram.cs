using System;


namespace Training
{
    internal class StartProgram
    {
        public static void Main(string[] args)
        {
            string input;

            Console.WriteLine("1. List trainind");
            Console.WriteLine("2. Dictionary training");
            Console.WriteLine("enter the number :");
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("----->>> " + 1);
                    ListTraining.StartList();
                    break;

                case "2":   
                    Console.WriteLine("----->>> " + 2);
                    DictionaryTraining.StartDictionary();
                    break;
                default:
                    Console.WriteLine("Number is not found");
                    break;
            }
        }
    }
}
