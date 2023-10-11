using System;
using System.Globalization;
using System.Text;

namespace Piano
{
    internal class Program
    {
        private const int Time = 200;

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("Переключение между октавами 1, 5, 6, 7 \n 0 - выход");
                int octaveChoice = Convert.ToInt32(Console.ReadLine());

                if (octaveChoice == 0)
                {
                    Console.WriteLine("\n Пока! Думаю, еще сыграем!");
                    break;
                }

                int[] selectedOctave = null;

                switch (octaveChoice)
                {
                    case 1:
                        Console.WriteLine("\n1 октава \n Нотки на клавишах Q-S(по порядку)  \n Для переключения между октавами выберите её номер  \n 0 - вернуться в меню");
                        selectedOctave = new int[] { 327, 346, 388, 367, 412, 436, 462, 490, 519, 550, 582, 617 };
                        break;
                    case 5:
                        Console.WriteLine("\n5 октава \n Нотки на клавишах Q-S(по порядку)  \n Для переключения между октавами выберите её номер  \n 0 - вернуться в меню");
                        selectedOctave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                        break;
                    case 6:
                        Console.WriteLine("\n6 октава \n Нотки на клавишах Q-S(по порядку)  \n Для переключения между октавами выберите её номер  \n 0 - вернуться в меню");
                        selectedOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                        break;
                    case 7:
                        Console.WriteLine("\n7 октава \n Нотки на клавишах Q-S(по порядку)  \n Для переключения между октавами выберите её номер  \n 0 - вернуться в меню");
                        selectedOctave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                        break;
                    default:
                        Console.WriteLine("\nНеверный выбор октавы. Пожалуйста, выберите снова.");
                        continue;
                }

                PlayOctave(selectedOctave);
            }
        }

        static void PlayOctave(int[] notes)
        {
            while (true)
            {
                ConsoleKeyInfo pianoKey = Console.ReadKey();

                if (pianoKey.Key == ConsoleKey.D0)
                {
                    break;
                }

                int noteIndex = pianoKey.Key - ConsoleKey.Q;

                if (noteIndex >= 0 && noteIndex < notes.Length)
                {
                    Console.Beep(notes[noteIndex], Time);
                }
                else
                {
                    Console.WriteLine("\nНеверная клавиша. Пожалуйста, попробуйте снова.");
                }
            }
        }
    }
}
