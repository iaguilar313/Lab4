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
                long fact;
                 
                Console.WriteLine("Please Enter Interger from 1-10");
                long userinput;
                userinput = long.Parse(Console.ReadLine());
                fact = userinput;
                 


                for (int i = 1; i <= userinput; i++)

                {
                    fact = fact * i;
                    
                    
                }
                Console.WriteLine(fact);  
                   
                
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
