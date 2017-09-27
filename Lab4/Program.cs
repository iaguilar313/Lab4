using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ProgramContinue = true;

            while (ProgramContinue == true)
            {
                Console.WriteLine("Please Enter Interger from 1-10");
                long userinput;
                userinput = long.Parse(Console.ReadLine());

                Console.WriteLine("You entered the number" + userinput);

                for (long i = userinput; i >= 1; i--)
                {
                    Console.WriteLine(userinput * i);
                }
                string UserChoice;
                Console.WriteLine("Do you want to run the code again? (N/No/y/yes)");
                UserChoice = Console.ReadLine();
                if (UserChoice == "N" || UserChoice == "No")
                {
                    ProgramContinue = false;
                }

            }


              
        }
    }
}
