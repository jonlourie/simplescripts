using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //all these using statements are actually namespaces 

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Red; //remember that foreground and backrounbd are properities so you use the eqaul sign with them i think you can do . operatoer with some properties but im not sure, that miuught kjust work for classes and static classes 
            Console.Clear(); //this makes the entire console the background color as opposed to just the background of our text and corresponding area 

            double doubleVariable = 13.16;
            int wholeNumber;
         

            //we will convert or cast the value of double to an integer it is similiar to how we do it in python - this ios called explicit converstion 
            //in order to convert a string to an integer we need to use Int32.Parse(), we can also use TryParse() for things we may need exceptions 

            wholeNumber = (int)doubleVariable; //this is explicit conversion
            string myString = wholeNumber.ToString(); //this is typoe converstion, we can even convert boolean value to strings as well

            string input = Console.ReadLine();
            Console.WriteLine("this is your " + input);
            Console.WriteLine(wholeNumber);
            Console.WriteLine(myString);
            Console.WriteLine(input.ToUpper().Substring(0, 5)); //he likes String.Format(" , {0}" for concatonation ,, we also used sub string which similair to python return the charecters in the slice or length parameters given 
            
 
            

            Console.Read();

            //every key has a corrasponding ascii value for example "D" corresponds to ascii 68 value
        }
    }
}
