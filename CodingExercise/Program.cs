using System;

namespace CodingExercise
{
    class Program
    {
        //Creating a method isCryptSolution which returns a Boolean value after decrypting & comparing.
        public static bool isCryptSolution(char[][] solution, string[] crypt)
        {
            string value1 = "";
            string value2 = "";
            string value3 = "";
            string word;

            for (int i = 0; i < crypt.Length; i++)
            {
                word = crypt[i];

                if (i == 0)
                {
                    value1 = decryptMessage(solution, word);

                    if (value1.Length > 1 && value1.Substring(0, 1) == "0")
                    {
                        return false;
                    }
                }

                if (i == 1)
                {
                    value2 = decryptMessage(solution, word);

                    if (value2.Length > 1 && value2.Substring(0, 1) == "0")
                    {
                        return false;
                    }
                }

                if (i == 2)
                {
                    value3 = decryptMessage(solution, word);

                    if (value3.Length > 1 && value3.Substring(0, 1) == "0")
                    {
                        return false;
                    }
                }
            }

            double sum = (Double.Parse(value1) + Double.Parse(value2));
            double result = (Double.Parse(value3));

            if (sum == result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Decrypting the message and appending the numbers based on the word.
        public static string decryptMessage(char[][] solution, string word)
        {
            string result = "";

            foreach (var value in word)
            {
                for (int i = 0; i < solution.Length; i++)
                {
                    for (int j = 0; j < solution[i].Length; j++)
                    {
                        if (j == 0 && (value == solution[i][j]))
                        {
                            result = result + solution[i][j + 1];
                        }
                    }
                }
            }
            return result;
        }

        //Main method.
        static void Main(string[] args)
        {
            //Creating an Jagged array named solution and initializing value to Individual array elements.
            char[][] solution =
            {
                new char[] {'O', '0'},
                new char[] {'M', '1'},
                new char[] {'Y', '2'},
                new char[] {'E', '5'},
                new char[] {'N', '6'},
                new char[] {'D', '7'},
                new char[] {'R', '8'},
                new char[] {'S', '9'},
            };

            //Creating a String array crypt and initializing value to its elements.
            string[] crypt = { "SEND", "MORE", "MONEY" };

            //Passing the crypt string & solution array to the isCryptSolution method and storing the boolean value in result.
            bool result = isCryptSolution(solution, crypt);

            //Printing the output True/False in the Console.
            Console.WriteLine(result);
        }
    }
}