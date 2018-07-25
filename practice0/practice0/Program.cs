using System;
//ZACHS using

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
            PlayArea playArea = new PlayArea();

            //Add options HERE and in SWITCH
            string[] options = {    "1 - Comment Script", 
                                    "2 - Future Game" 
                                };    


            string optionsString = $"There are {options.Length} options.";
            bool gameOn = true;

            Console.WriteLine($"Hello, t{optionsString.Substring(1)}");  //removed first letter of optionsString to make capital.

            int option;
            while (gameOn)
            {
                foreach (string opt in options)
                {
                    Console.WriteLine(opt);
                }
                Console.WriteLine("Please select a number or select 0 to quit");

                option = Convert.ToInt32(Console.ReadLine()); //READ INT
                Console.WriteLine("");
                switch (option)
                {
                    case 0:
                        System.Environment.Exit(1);
                        break;
                    case 1:
                        Script.startScript();
                        break;
                    case 2:
                        //Now Displays Preview
                        Console.WriteLine("Preview");
                        Console.WriteLine(playArea.DisplayGameBoard());
                        break;

                }

                //Closing loop statements
                option = -1;
                Console.WriteLine($"\n{optionsString}");
            }


            Console.Read();
        }

        
        
    }
}
