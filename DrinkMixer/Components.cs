using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkMixer
{
    abstract class Storage
    {
        abstract public int GetPrice(int ID); 
    }

    class Drink_Storage : Storage
    {
        static Dictionary<int, int> Drinks = new Dictionary<int, int>()
        {
            { 1, 15}, // Кофе
            { 2, 10} // Чай
        };

        public override int GetPrice(int ID) // находит нужный напиток по ID
        {
            return Drinks[ID];
        }
    }

    class Addition_Storage : Storage
    {
        static Dictionary<int, int> Additions = new Dictionary<int, int>()
        {
            { 1, 2}, // Молоко
            { 2, 1}, // Сахар
            { 3, 3 }, // Корица
            { 4, 1 } // Лимон
        };

        public override int GetPrice(int ID) // добавляет нужную добавку по ID
        {          
                return Additions[ID]; 
        }
    }
}
