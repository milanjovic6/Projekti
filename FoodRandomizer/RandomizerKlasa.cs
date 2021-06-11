using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace FoodRandomizer
{
    public class RandomizerKlasa
    {
        int index;
        public int Lastindex { get; set; }
        public List<string>  food = new List<string> { "Pizza", "Kebab/Giros", "Pasta", "Piletina", "Gogo Sendvic", "Tron Burger", "Burrito", "Cezar Salata", "Palacinka", "Something Homemade" };
        Random rand = new Random();


        /// <summary>
        /// Method that select random food 
        /// </summary>
        public string Randomize()
        {
            do
            {
                index = rand.Next(food.Count);
            }
            while (index == Lastindex);

            Lastindex = index;
            return food[index];
        }
    

    }

}
