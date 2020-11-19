using System;
using System.Linq;
using System.Collections.Generic;

namespace linq
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Restriction/Filtering Operations");
            Console.WriteLine("");


            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            List<string> LFruits = (from fruit in fruits
                                    where fruit.StartsWith("L")
                                    orderby fruit descending
                                    select fruit).ToList();

            LFruits.ForEach(fruit => Console.WriteLine(fruit));


            Console.WriteLine("");

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
                {
                    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
                };

            List<int> fourSixMultiples = (numbers.Where(n => n % 4 == 0 || n % 6 == 0).ToList());

            fourSixMultiples.ForEach(n => Console.WriteLine(n));

            Console.WriteLine("");
            Console.WriteLine("Ordering Operations");
            Console.WriteLine("");

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
{
    "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
    "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
    "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
    "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
    "Francisco", "Tre"
};

            List<string> descend = (names.OrderByDescending(name => name).ToList());
            descend.ToList().ForEach(name => Console.WriteLine(name));
            Console.WriteLine("");


            // Build a collection of these numbers sorted in ascending order
            List<int> numbersList = new List<int>()
{
    15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
};
            List<int> countingUp = (numbersList.OrderBy(num => num).ToList());
            countingUp.ToList().ForEach(num => Console.WriteLine(num));
            Console.WriteLine("");
            Console.WriteLine("Aggregate Operations");
            Console.WriteLine("");





        }
    }
}
