using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMixer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите напиток");
            int DrinkID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите добавки");
            List<int> AdditionIDs = (Console.ReadLine().Split(',')).Select(int.Parse).ToList();

            Console.WriteLine("Стоимость:");
        }
    } 
}
