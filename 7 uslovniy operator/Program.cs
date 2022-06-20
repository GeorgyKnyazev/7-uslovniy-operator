using System;

namespace _7_uslovniy_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userTextToOutput;
            char symbolForFraming;
            int stringLight;

            Console.Write("Введите текс для вывода: ");
            userTextToOutput = Console.ReadLine();
            Console.Write("введите символ для рамки: ");
            symbolForFraming = Convert.ToChar(Console.ReadLine());
            stringLight = userTextToOutput.Length;

            for (int i = 0; i < (stringLight + 2); i++)
            {
                Console.Write(symbolForFraming);
            }
            Console.SetCursorPosition(0, 3);
            Console.WriteLine(symbolForFraming + userTextToOutput + symbolForFraming);
            for (int i = 0; i < (stringLight + 2); i++)
            {
                Console.Write(symbolForFraming);
            }
        }
    }
}
