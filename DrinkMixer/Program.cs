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
            Console.WriteLine("Enter drink ID");
            int DrinkID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Addition IDs");
            
            try
            {
                List<int> AdditionIDs = (Console.ReadLine().Split(',')).Select(int.Parse).ToList();
                Console.WriteLine(String.Format("Cost:{0}", Mixer.Mix(DrinkID, AdditionIDs)));
            }
            catch(FormatException e)
            {
                Console.WriteLine("Wrong data format"); // если введён неверный формат 
                Console.WriteLine(e.Message);
            }
            catch(KeyNotFoundException e)
            {
                Console.WriteLine("No product with such index"); // если напитка или добавки с таким ID не существует
                Console.WriteLine(e.Message);
            }                  
        }
    } 
}
