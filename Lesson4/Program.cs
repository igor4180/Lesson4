// See https://aka.ms/new-console-template for more information
using AIGuess;
using System.Text;
using Morse;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region TASK1
            //int userNumber;
            //Random r = new Random();
            //RandomNumberAndHisBool rhanb = new RandomNumberAndHisBool();
            //do {
            //    do { 
            //        Console.WriteLine("Введите число в диапазоне от 0 до 100"); 
            //        userNumber = Int32.Parse(Console.ReadLine()); 
            //    }
            //    while (userNumber < 0 || userNumber > 100);

            //    rhanb = Guess.SimpleGuess(0, 100, r, userNumber, rhanb);
            //  Console.WriteLine("Числа совпали с числом {0}? {1}",rhanb.RandomNumber, rhanb.HisBool.ToString());
            //    if (rhanb.HisBool) break;
            //    Console.WriteLine("Нажмите Y для новой попытки. Любую клавишу для отмены.");
            //}
            //while (Console.ReadLine() == ConsoleKey.Y.ToString());
            //#endregion

            string startText;
            Console.WriteLine("Введите текст для перевода в азбуку Морзе");
            startText = Console.ReadLine();
            startText = ConvertToMorse.TextToMorse(startText);

            Console.WriteLine("Ваш тект в виде азбуки Морзе:" + startText);
        }
    }
}

namespace AIGuess
{
    internal class Guess
    {
        
        public static RandomNumberAndHisBool SimpleGuess(int min, int max, Random r, int userNumber, RandomNumberAndHisBool rnahb)
        {
            rnahb.RandomNumber = r.Next(min, max);
            rnahb.HisBool = (bool)(rnahb.RandomNumber == userNumber);
            return rnahb; 
        }
    }
    internal class RandomNumberAndHisBool
    {
        public int RandomNumber { get; set; } = 0;
        public bool HisBool { get; set; } = false;

    }
}

namespace Morse
{
    class ConvertToMorse
    {
        
        public static string TextToMorse(string alphaText)
        {
            char [] chars = alphaText.ToCharArray();
            string[] massiveMorse = new string[] { "*-", "-***", "*--", "--*", "-**" };
            string[] massiveAplhabet = new string[] { "а", "б", "в", "г", "д" };
            string betaText;
            StringBuilder sb = new StringBuilder();
            int count = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                foreach (string str in massiveAplhabet)
                {
                    if (chars[i] == str[0])
                    {
                        sb.Append(massiveMorse[count]);
                    }
                    count++;
                }
                count = 0;
            }
            return betaText = sb.ToString(); ;
        }
    }
}