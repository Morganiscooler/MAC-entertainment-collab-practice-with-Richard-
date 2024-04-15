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
                // check if String's length is even/odd
                int len = String.Length;
                string reversed = Reverse(String);
                int reversedLen = reversed.Length; // Not used so far...

                //Console.WriteLine(reversed); // Reverse func works!
                // it does not start at 0 because then the starting index [0] would go off the length of String
                // Hey Richard! Why does this for loop not work? Did I do something wrong? It's reversing certain strings
                // But not outputting the strings I want!
                for (int l = (len - 1); l < reversedLen ; l++) 
                {
                    string str = String.Substring(0, len / 2);
                    string reversedStr = reversed.Substring(0, len / 2);

                    int strLength = str.Length;
                    int reversedStrLength = reversedStr.Length;

                    // the smaller string will go to the front of the string
                    //if ((String.Substring(0, len/2) < reversedLen.Substring(0, len/2)) && len % 2 == 1)
                    //{

                    //}
                    if (strLength < reversedStrLength && NumberOfOperations % 2 == 1)
                    {
                        // if the first half is LEXICOGRAPHICALLY smaller than the second half, then add the original
                        // string to the end of the REVERSED string.
                        Console.WriteLine(reversedLen + String);
                    }
                    else if (strLength < reversedStrLength && NumberOfOperations % 2 == 0)
                    {
                        // Does nothing
                        Console.WriteLine(String);
                    }
                    else if (strLength > reversedStrLength && NumberOfOperations % 2 == 1)
                    {
                        Console.WriteLine(reversedLen + String);
                    }
                    else {
                    
                        Console.WriteLine(Reverse(String));
                        
                    }
                }
                
                
            }
        }
        // You can either REVERSE or add the REVERSED string to the end of the string!!
        public static string Reverse(string String) // Function that reverses the string, call it later with an argument.
        {
            char[] charArray = String.ToCharArray();
            Array.Reverse(charArray); 
            return new string(charArray);
        }
    }
}

