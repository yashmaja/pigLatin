using System;

namespace pigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a word: ");
            string input = Console.ReadLine();

            Console.WriteLine(PigLatin(input));

        
        }

        public static string PigLatin(string x)
        {
            //x = x.ToLower();

            //check if there is a non-letter or punctuation in input
            foreach (char check in x)
            {
                if (!char.IsLetter(check) && !char.IsPunctuation(check))
                {
                    return x;
                }
                else
                {
                    continue;
                }
            }
            
            if (x[0] == 'a' || x[0] == 'e' || x[0] == 'i' || x[0] == 'o' || x[0] == 'u'
                && x[0] != 'A' && x[0] != 'E' && x[0] != 'I' && x[0] != 'O' && x[0] != 'U')
            {
                return (x + "way");
            }
            else
            {
                foreach (char n in x)
                {
                    if (x[0] != 'a' && x[0] != 'e' && x[0] != 'i' && x[0] != 'o' && x[0] != 'u' 
                        && x[0] != 'A' && x[0] != 'E' && x[0] != 'I' && x[0] != 'O' && x[0] != 'U')
                    {
                        x = x.Substring(1) + x[0];
                        //Console.WriteLine(x);
                    }
                    else
                    {
                        //Console.WriteLine("why is this happening");
                        break;
                    }
                }

                return x + "ay";
            }
        }
    }
}
