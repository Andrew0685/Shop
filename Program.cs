using System;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int cristalPrice = 5;
            int goldAmount;
            int cristalsAmount;

            Console.WriteLine("Веедите колличество вашего золота:");

            goldAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("Сколько кристаллов вы хотите купить?");

            cristalsAmount = int.Parse(Console.ReadLine());
            goldAmount = goldAmount - cristalsAmount * cristalPrice;
            Console.WriteLine($"У вас осталось:\n{goldAmount} золота\n{cristalsAmount} кристаллов");
            Console.ReadKey();
        }        
    }
}
