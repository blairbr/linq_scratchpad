using System;
using System.Collections.Generic;
using System.Linq;
//ctrl K + D to format
namespace LINQ_Scratchpad
{
    public class Program
    {

        public static void Main(string[] args)
        {
            List<Dog> listOfDogs = new List<Dog>()
            {
                new Dog("Rex", new List<string> {"ball", "sniffing", "Frisbee"}, 2),
                new Dog("Peanut", new List<string> { "Frisbee", "fetch" }, 7)
            };
            // calling without the optional parameter will default to filtering on the name Peanut
            FilterDogsByNameUsingWHERE(listOfDogs);

            // calling this method and passing in Rex will filter on Rex
            FilterDogsByNameUsingWHERE(listOfDogs, "Rex");

            FormatDogInfoUsingSELECT(listOfDogs);

            PrintDogsAllDogsSkills(listOfDogs);
        }

        // .Where
        public static void FilterDogsByNameUsingWHERE(List<Dog> listOfDogs, string nameToFilterOn = "Peanut")
        {
            var listOfDogsNamedPeanut = listOfDogs.Where(c => c.Name == nameToFilterOn);
            foreach (var dog in listOfDogsNamedPeanut)
            {
                Console.WriteLine(dog.Name);
            }
        }

        // .Select
        // Select() takes each source element, transforms it, and returns a sequence of the transformed values. It acts like the map() function in Javascript.
        public static void FormatDogInfoUsingSELECT(List<Dog> listOfDogs)
        {
            var formattedDogInfo = listOfDogs.Select(d => $"{d.Name} is a {d.Age} year-old cutie."); //who loves to {d.Skills}");
            foreach (var dog in formattedDogInfo)
            {
                Console.WriteLine(dog);
            }
        }
        // .SelectMany
        //The SelectMany in LINQ is used to project each element of a sequence to an IEnumerable<T> and then flatten the resulting sequences into 
        //one sequence.That means the SelectMany operator combines the records from a sequence of results and then converts it into one result.

        //Distinct will remove any duplicates from the IEnumerable that is returned. So in the second example, it doesn't print Frisbee twice, just once.
        public static void PrintDogsAllDogsSkills(List<Dog> listOfDogs) {
            var listOfAllDogsSkills = listOfDogs.SelectMany(d => d.Skills);
            var listOfAllDistinctDogsSkills = listOfDogs.SelectMany(d => d.Skills).Distinct();

            Console.WriteLine("All dog skills: ");
            foreach (var skill in listOfAllDogsSkills)
            {
                Console.WriteLine(skill);
            }

            Console.WriteLine("All distinct dog skills: ");
            foreach (var skill in listOfAllDistinctDogsSkills)
            {
                Console.WriteLine(skill);
            }

        }

        // .GroupBy


    }
}

