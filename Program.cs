using System;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int cristalPrice = 5;
            int goldAmount;
            int cristalAmount;

            Console.WriteLine("Веедите колличество вашего золота:");

            goldAmount = DateValidation();

            Console.WriteLine("Сколько кристаллов вы хотите купить?");

            cristalAmount = DateValidation();
            goldAmount = goldAmount - cristalAmount * cristalPrice;
            Console.WriteLine($"У вас осталось:\n{goldAmount} золота\n{cristalAmount} кристаллов");
            Console.ReadKey();
        }

        static int DateValidation() 
        {
            bool isCorrectDateEntered = false;
            int enteredNumber = 0;

            while (!isCorrectDateEntered) 
            {
                if (int.TryParse(Console.ReadLine(), out enteredNumber) && enteredNumber >= 0)
                {
                    isCorrectDateEntered = true;
                }
                else
                {
                    Console.WriteLine("Введите корректные данные, должно быть число больше либо равно нулю");
                }
            }
            return enteredNumber;
        }
    }
}
