using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name
{
    class NameClass { 
    private static string name;
    
        //Method to enter and display your name
        public void enterName()
        {
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Your name is {0} \n", name);
        }
        
        //Method that displays your n ame
        public  void getName()
        {
            if (name != null)
            {
                Console.Clear();
                Console.WriteLine("Your name is {0} \n", name);
                
            }
            //Show this message when no name is entered(if name == null)
            else
            {
                Console.WriteLine("No name entered please pick menu item 1 to enter your name\n");
            }
        }
    }
}