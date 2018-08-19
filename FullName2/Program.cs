using System;
using System.Text;
namespace FullName2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Asks the user for their first name and assigns it to firstName variable.
            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            //Asks user their last name and assigns it to lastName variable.
            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            //New stringbuilder called mystring that concatenates the literal string
            //"full name" with the method created below, which print the first
            //and last name with a space in between.
            StringBuilder myString = new StringBuilder();

            myString.Append("Full name: ");
            myString.Append(Welcome(firstName, lastName));

            Console.WriteLine(myString); //Printing the string to the console.
            Console.ReadLine();
        }//New method.
        private static string Welcome(string firstName, string lastName)
        {//This prints the first and last name to the console with a space in between.

            return firstName + " " + lastName;

        }
    
    }
}
