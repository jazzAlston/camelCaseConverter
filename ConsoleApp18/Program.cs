using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MakeCamelCase("The_Stealth_Warrior")); 
        }
        public static string MakeCamelCase(string string1)
        {
            string result = "";
            string[] stringSplit;
            char special = 'a';



            foreach (char c in string1)
            {
                if (!Char.IsLetter(c))
                {
                    special = c;

                }

            }
            stringSplit = string1.Split(special);
            
            result += stringSplit[0].ToLower();

            for (int i = 1; i < stringSplit.Length; i++)
            {
                for (int j = 0; j < stringSplit[i].Length; j++)
                {
                    string current = stringSplit[i];

                    if (j == 0)
                    {
                        result += Char.ToUpper(current[j]);
                    }
                   else
                   {
                        result += current[j];
                    }
                  
                }

            }
            return result;

        }
    }
}
