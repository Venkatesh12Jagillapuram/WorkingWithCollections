using System.Collections;
using System.Runtime.Intrinsics.X86;

namespace WorkingWithCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Benz";
            car1.Model = "S-Class";
            car1.VIN = "S1";

            Car car2 = new Car();
            car2.Make = "Nissan";
            car2.Model = "Supereme";
            car2.VIN = "A1"
;
            Book b1 = new Book();
            b1.Title = "Robert Tabor";
            b1.Author = " Microsoft . NET XML Web Services";
            b1.ISBN = "0-000-0000-0";
            */

            /*
            // ArrayLists Are dynamically sized,
            //cool featues sorting, remove items,

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*
            // List <T>
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1)
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
             */
            /*
            // Dictionary<Tkey, Tvalue>

            Dictionary<string, Car>  myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["A1"].Make);
            */

            //string[] names = { "Venkatesh", "Saikumar", "Mallesh", "Mahesh" };

            //object Intializer
            //no need for a constructor
            //Car car1 = new Car() { Make = "Benz", Model = "S-class", VIN = "C3" };
            //Car car2 = new Car() { Make = "Volvo", Model = "V-class", VIN = "A3" };

            // Collection intiializer
            List<Car> myList = new List<Car>()
            {
                new Car { Make = "toyota", Model = "Innova", VIN = "A3" }, 
                new Car { Make = "Maruti Suzuki", Model = " Crysta", VIN = "S3" }
            };
          
            Console.ReadLine();
        }
    }
        class Car
        {
            public string VIN { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
        }
    }

