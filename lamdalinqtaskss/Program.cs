using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamdalinqtaskss
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>
{
           "Mumbai",
                "Delhi",
                    "Ahmedabad",
                           "Surat",
                                 "Valsad",
                                     "Varanasi",
                                             "Chennai",
                                                     "Bhopal",
                                                        "Darjeeling",
};
            //decending  order
            var newDetailslamda = cities.OrderByDescending(x => x).ToList();
            var newDetailslinq = (from city in cities
                                  orderby city descending
                                  select city).ToList();

            //ascending order
            var newDetailslamda2 = cities.OrderBy(x => x).ToList();
            var newDetailslinq2 = (from city in cities
                                   orderby city ascending
                                   select city).ToList();

            //descending order by its length
            var newDetailslamda3 = cities.OrderByDescending(x => x.Length).ToList();
            var newDetailslinq3 = (from city in cities
                                   orderby city.Length descending
                                   select city).ToList();

            // ascending order by its length
            var newDetailslamda4 = cities.OrderBy(x => x.Length).ToList();
            var newDetailslinq4 = (from city in cities
                                   orderby city.Length ascending
                                   select city).ToList();

            //starts with V and D letter.
            var newDetailslamda5 = cities.Where(x => x.StartsWith("V") || x.StartsWith("D")).ToList();
            var newDetailslinq5 =
                    (from city in cities
                     where city.StartsWith("V") || city.StartsWith("D")
                     select city).ToList();

            //count of city names starts with A letter.
            var newDetailslamda6 = cities.Count(x => x.StartsWith("A"));
            Console.WriteLine(newDetailslamda6);
            Console.ReadLine();
            var newDetailslinq6 =
                   (from city in cities
                    where city.StartsWith("A")
                    select city).Count();
            Console.WriteLine(newDetailslinq6);
            Console.ReadLine();


            //city names by its first letter
            var newDetailslinq7 = from city in cities
                                    group city by city[0] into cityGroup
                                    orderby cityGroup.Key
                                    select cityGroup;
              foreach (var cityGroup in newDetailslinq7)
             {
                 Console.WriteLine(cityGroup.Key);
                 foreach (var city in cityGroup)
                 {
                     Console.WriteLine(city);
                 }
             }
             Console.ReadKey();

            var newDetailslamda7 = cities.GroupBy(city => city[0]).OrderBy(city => city.Key);




            foreach (var cityGroup in newDetailslamda7)
            {
                Console.WriteLine(cityGroup.Key);
                foreach (var city in cityGroup)
                {
                    Console.WriteLine(city);
                }
            }
            Console.ReadKey();

        }

        static void display(List<string> cities)
        {
            foreach (var value in cities)
            {
                {
                    Console.WriteLine(value);

                }

            }
            Console.ReadKey();
        }



    }
}
