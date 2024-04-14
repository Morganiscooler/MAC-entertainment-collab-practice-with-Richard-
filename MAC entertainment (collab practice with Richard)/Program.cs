using System;


namespace entertainmentMAC 
{
    class ProblemCollab
    {
        public static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < userInput; i++)
            {
                int NumberOfOperations = int.Parse(Console.ReadLine());
                string String = Console.ReadLine();
                for (int n = 0; n < NumberOfOperations; n++)
                {
                    string FinalOutput = Reverse(String, NumberOfOperations);
                    Console.WriteLine($"The output after the string is reversed {NumberOfOperations} amount of times is: {FinalOutput}");
                }
            }
        }
        // You can either REVERSE or add the REVERSED string to the end of the string!!
        public static string Reverse(string String, int NumberOfOperations) // Function that reverses the string, call it later with an argument.
        {
            

            // define how to Reverse the string num amount of times...
           
            return Reverse(String, NumberOfOperations);
        }
    }
}

