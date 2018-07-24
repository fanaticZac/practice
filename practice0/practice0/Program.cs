using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice0
{
    class Program
    {
        // Zach and Grey Practice Project (using git)

        //RULES, for now:
        // -heavily comment code
        // -test before commiting
        // -do something interesting
        // -if you change to much, try to preserve previous code to other burner classes to avoid deletion (for preservation of old fun for record)

        static void Main(string[] args)
        {
            string[] names = { "Zach", "Grey" };

            string[] comments = {   "I created project, then put a shortcut in the main folder.",
                                    "I updated the project and hopefully this works",
                                    "I added array and loop to function, added comments, and arrays",
                                    "I am trying to get this right and also adding a bit to this project"
                                };


            //loops now goes for as long as their is elements left in the array
            for (int i = 0; i < comments.Length; i++)  //checks for odd or even, assuming we take turns
            {
                //ternary operator with modulus to variable for speaker
                string speaker = (i % 2 == 0) ? names[0] : names[1]; //terniary operator - compact if/else
                {
                    Console.Write($"{speaker} says - ");
                }
                Console.WriteLine(comments[i]);
            }



            Console.Read();
        }
    }
}
