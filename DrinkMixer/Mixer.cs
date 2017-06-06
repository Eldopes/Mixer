using System.Collections.Generic;

namespace DrinkMixer
{
    class Mixer
    {
        public static int Mix(int DrinkID, List<int> AdditionIDs)
        {
            Drink_Storage drinks = new Drink_Storage();
            Addition_Storage additions  = new Addition_Storage();
            int drinkPrice = drinks.GetPrice(DrinkID);
            int additionPrice = 0;
            foreach (var id in AdditionIDs)            
                additionPrice += additions.GetPrice(id);
            return drinkPrice + additionPrice; 
        }
    }      
}
