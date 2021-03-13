using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        public static void game()
        {

            bool need = true;
            Console.WriteLine("=======================================================");
            Console.WriteLine("||                                                   ||");
            Console.WriteLine("||                 EV3NMORN PRESENTS                 ||");
            Console.WriteLine("||                                                   ||");
            Console.WriteLine("||             C A N D Y   K I N G D O M             ||");
            Console.WriteLine("||               D I C E   R O L L E R               ||");
            Console.WriteLine("||                                                   ||");
            Console.WriteLine("=======================================================");
            while (need)
            {
                int dices;

                Console.WriteLine("Введите количество кубиков");
                string userText = Console.ReadLine();
                if (Int32.TryParse(userText, out dices))
                {
                    //    Console.WriteLine("Число кубиков: " + dices);
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }

                int sides;
                Console.WriteLine("Введите число граней");
                string userText1 = Console.ReadLine();
                if (Int32.TryParse(userText1, out sides))
                {
                    //    Console.WriteLine("Число граней: " + sides);
                }
                else
                {
                    Console.WriteLine("Некорректный ввод");
                }

                //Объявляем рандом
                Random rnd = new Random();

                //Генерируем случайное число от 1 до sides
                int RollStandardDie()
                {
                    return rnd.Next(1, sides + 1);
                }

                //Массив из числа dices
                int[] dice = new int[dices];
                //Console.WriteLine(" ");
                Console.WriteLine("_______________________________________________________");
                Console.WriteLine("Бросаем " + dices + " кубиков с " + sides + " гранями...");
                //Для каждого кубика выкидываем число и пишем его в консоль
                int sum = 0;
                for (int i = 0; i < dice.Length; i++)
                {
                    dice[i] = RollStandardDie();
                    Console.WriteLine("Выпало число " + dice[i]);
                    sum = sum + dice[i];
                }

                //Вывод числа в консоль
                Console.WriteLine(" ");
                Console.WriteLine("Сумма значений равна " + sum);
                Console.WriteLine("_______________________________________________________");
                Console.WriteLine(" ");
                //Console.WriteLine("Нажмите любую клавишу для повтора");
            }

        }

        public static void Main(string[] args)
        {
            Program.game();
            Console.ReadKey();
        }

    }

}