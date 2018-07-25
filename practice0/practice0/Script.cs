using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice0
{
    static class Script
    {
        // Zach and Grey - Changes script

        public static void startScript()
        {
            string[] names = { "Zach", "Grey" };

            string[] comments = {   "I created project, then put a shortcut in the main folder.",
                                    "I updated the project and hopefully this works.",
                                    "I added array and loop to function, added comments, and arrays.",
                                    "I am trying to get this right and also adding a bit to this project.", 
                                    "I've moved the 'script' to a static class to keep the main method uncluttered."
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
        }
        
    }
}
