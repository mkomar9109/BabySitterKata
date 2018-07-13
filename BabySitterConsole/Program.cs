using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BabySitterNameSpace;

namespace BabySitterConsole
{
    class Program
    {


        static void Main(string[] args)
        {
            BabySitter obj = new BabySitter();
            string response = "";
            do
            {
                Console.WriteLine("BabySitter Wage Calculator ");
                Console.WriteLine("Enter your Start time: (ex. 5:00pm)");
                string startTime = Console.ReadLine();
                Console.WriteLine("Enter the child's bed time: (ex. 8:00pm)");
                string bedTime = Console.ReadLine();
                Console.WriteLine("Enter your stop time: (ex. 1:00am) ");
                string endTime = Console.ReadLine();

                int value = obj.CalculateNightlyRate(startTime, endTime, bedTime);
                Console.WriteLine("Your total amount comes to: $" + value);
                Console.WriteLine("Do You Want to do another calculation?");
                Console.WriteLine("Enter Y to continue. Hit any key to exit");
                response = Console.ReadLine();
            } while (response.ToUpper() == "Y");
            
        }
    }
}
