using System;

namespace KSBL_Task_2_4
{
    class Program
    {
        static void Main(string[] args)
        {

            String word = "";

            while (true)
            {
                try
                {
                    word = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Wrong input.");
                }

                if (word == "end")
                {
                    break;
                }

                Console.WriteLine(Program.Translate(word));

            }

        }

        static String Translate(String word)
        {
            switch (word)
            {

                case "дождь":
                    return "rain";

                case "снег":
                    return "snow";

                case "солнечно":
                    return "sunshine";

                case "облачно":
                    return "cloudly";

                case "туман":
                    return "fog";

                case "град":
                    return "hail";

                case "ливень":
                    return "shower";

                case "гроза":
                    return "thunder";

                case "ветер":
                    return "wind";

                case "шторм":
                    return "storm";

                default:
                    return "I don't know this word";


            }
        }
    }
}
