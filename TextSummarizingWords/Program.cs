using System;
using System.Collections.Generic;

namespace TextSummarizingWords
{
    /*User has to enter the Text
     *User has to enter the length(no of characters) that they want in the summary.
     *Note - will include only whole word. 
     *Output - the program will return the first few words in the text according to the length we specify
     */
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter the Text, whose summary you want to get : \n");
            string Sentance = Console.ReadLine();
            
            Console.WriteLine("\nPlease specify the length(no of characters) of the summary you require:");
            int maxLength = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nThe Summary(first few words according to the length specified) is : ");
            CallingSummary.WritingSummary(Sentance, maxLength);//can use class name to directly call because WritingSummary method is static
        }

    }
}

