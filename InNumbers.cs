using System;

namespace InNumbersLib
{
    static class InNumbers
    {
        public static int InInt(string mess, int min, int max)
        {
            int buff = 0;
            bool isSuccess = false;
            while (!isSuccess)
            {
                Console.WriteLine(mess);
                isSuccess = Int32.TryParse(Console.ReadLine(), out buff);
                if (!isSuccess)
                {
                    Console.WriteLine("Введено некорректное значение, повторите ввод");
                    continue;
                }
                if (buff < min || buff > max)
                {
                    Console.WriteLine("Введено некорректное число, повторите ввод");
                    isSuccess = false;
                }
            }
            return buff;
        }
        public static int InInt(int min, int max)
        {
            int buff = 0;
            bool isSuccess = false;
            while (!isSuccess)
            {
                isSuccess = Int32.TryParse(Console.ReadLine(), out buff);
                if (!isSuccess)
                {
                    Console.WriteLine("Введено некорректное значение, повторите ввод");
                    continue;
                }
                if (buff < min || buff > max)
                {
                    Console.WriteLine("Введено некорректное число, повторите ввод");
                    isSuccess = false;
                }
            }
            return buff;
        }
        public static int InInt(string mess)
        {
            int buff = 0;
            bool isSuccess = false;
            while (!isSuccess)
            {
                Console.WriteLine(mess);
                isSuccess = Int32.TryParse(Console.ReadLine(), out buff);
                if (!isSuccess)
                {
                    Console.WriteLine("Введено некорректное значение, повторите ввод");
                    continue;
                }
            }
            return buff;
        }
        public static int InInt()
        {
            int buff = 0;
            bool isSuccess = false;
            while (!isSuccess)
            {
                isSuccess = Int32.TryParse(Console.ReadLine(), out buff);
                if (!isSuccess)
                {
                    Console.WriteLine("Введено некорректное значение, повторите ввод");
                    continue;
                }
            }
            return buff;
        }
        public static double InDbl(string mess, double min, double max)
        {
            double buff = 0;
            bool isSuccess = false;
            while (!isSuccess)
            {
                Console.WriteLine(mess);
                isSuccess = Double.TryParse(Console.ReadLine(), out buff);
                if (!isSuccess)
                {
                    Console.WriteLine("Введено некорректное значение, повторите ввод");
                    continue;
                }
                if (buff < min || buff > max)
                {
                    Console.WriteLine("Введено некорректное число, повторите ввод");
                    isSuccess = false;
                }
            }
            return buff;
        }
        public static double InDbl(double min, double max)
        {
            double buff = 0;
            bool isSuccess = false;
            while (!isSuccess)
            {
                isSuccess = Double.TryParse(Console.ReadLine(), out buff);
                if (!isSuccess)
                {
                    Console.WriteLine("Введено некорректное значение, повторите ввод");
                    continue;
                }
                if (buff < min || buff > max)
                {
                    Console.WriteLine("Введено некорректное число, повторите ввод");
                    isSuccess = false;
                }
            }
            return buff;
        }
        public static double InDbl(string mess)
        {
            double buff = 0;
            bool isSuccess = false;
            while (!isSuccess)
            {
                Console.WriteLine(mess);
                isSuccess = Double.TryParse(Console.ReadLine(), out buff);
                if (!isSuccess)
                {
                    Console.WriteLine("Введено некорректное значение, повторите ввод");
                    continue;
                }
            }
            return buff;
        }
        public static double InDbl()
        {
            double buff = 0;
            bool isSuccess = false;
            while (!isSuccess)
            {
                isSuccess = Double.TryParse(Console.ReadLine(), out buff);
                if (!isSuccess)
                {
                    Console.WriteLine("Введено некорректное значение, повторите ввод");
                    continue;
                }
            }
            return buff;
        }
    }
}
