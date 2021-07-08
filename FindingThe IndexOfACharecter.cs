using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string myNumber = "13";

            //int newIntValue = Int32.Parse(myNumber);


            Console.WriteLine(myNumber);

            Console.Read(); //this has to be called after every thing if its not the thing wont be read 


            Console.WriteLine("Enter string here: ");

            string userStringInput = Console.ReadLine(); //string are lists so we can use things like indexOf

            Console.WriteLine("Enter charecter to search: ");
            //read a charecter we get the first charecter of that string 
            char searchInput = Console.ReadLine()[0]; //this data type stores a method that reads the first appearence of a given charecter in a string - we zre reading the line from the charecvter 0
            int searchIndex = userStringInput.IndexOf(searchInput); //we could just as easily put 0 in hjere i think

            Console.WriteLine("Index of chaerecter {0} in string is {1}", searchInput, searchIndex);

            


            Console.Read();
        }
    }
}
