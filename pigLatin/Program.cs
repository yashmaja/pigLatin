using System;

namespace pigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the Pig Latin Translator!\n\n");

            bool repeat = true; //check for null string
            while (repeat)
            {
                Console.WriteLine("Enter a line to be translated: ");
                string input = Console.ReadLine();

                Console.WriteLine(PigLatinSentences(input));

                while (true)
                {
                    Console.Write("Would you like to translate another line? (y/n): ");
                    string answer = Console.ReadLine();

                    if (answer == "n")
                    {
                        Console.WriteLine("\nGoodbye!");
                        repeat = false;
                        break;
                    }
                    else if (answer == "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input. Try again.\n");
                    }
                }
            }
        }

        public static bool HasNumOrSymbols(string word)
        {
            bool result = false;
            foreach (char check in word)
            {
                if (!char.IsLetter(check) && !char.IsPunctuation(check))
                {
                    result = true;
                }
                else
                {
                    continue;
                }
            }
            return result;
        }

        public static string PigLatinSentences(string sentence)
        {
            string[] words = sentence.Split(' ');   //create array containing each word in the sentence
            string result = "";                     //initialize string variable to hold end result
            int indexNum = 0;                       //initiate index for refer to each word

            //loop for each word
            while (indexNum < words.Length)
            {
                //refer to each word in array at indexNum in array words
                string word = words[indexNum];

                //check if there is a non-letter or punctuation in input
                if (HasNumOrSymbols(word))
                {
                    result += word + " ";
                }
                else
                {
                    if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u'
                        || word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'O' || word[0] == 'U')
                    {
                        result += word + "way ";
                    }
                    else
                    {
                        foreach (char letter in word)
                        {
                            if (word[0] != 'a' && word[0] != 'e' && word[0] != 'i' && word[0] != 'o' && word[0] != 'u'
                                && word[0] != 'A' && word[0] != 'E' && word[0] != 'I' && word[0] != 'O' && word[0] != 'U')
                            {
                                word = word.Substring(1) + word[0];
                            }
                            else
                            {
                                break;
                            }
                        }

                        result += word + "ay ";
                    }
                }
                indexNum += 1;
            }
            result = "\n" + result.Substring(0, 1).ToUpper() + result.Substring(1);
            return result;
        }
        
    }
}
