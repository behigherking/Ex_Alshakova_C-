using System;

class Program
{
    static void Main(string[] args)
    {
        string[] months = { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };
        bool isValidInput = false;
        int monthNumber = 0;
        while (!isValidInput)
        {
            try
            {
                Console.Write("Введите целое число от 1 до 12 ");
                monthNumber = int.Parse(Console.ReadLine());
                if (monthNumber >= 1 && monthNumber <= 12)
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("число является отрицательным или больше 12, введите снова");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Число не является целым или присутствуют буквы, попробуйте снова");
            }
        }
        Console.WriteLine($" под данным номером месяц - {months[monthNumber - 1]}");
    }
}