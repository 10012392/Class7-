//Lara Corkery 
//Loop and If statements - Tasks 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopAndIfTasks
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task One - Odd Numbers 

          /*  Console.WriteLine("While Loop - Odd Number");
            int start = 76;
            int finish = 46;
            Console.WriteLine("Display all the odd numbers between 76 and 46.");
                while (start >= finish)
            {
                if (start % 2 !=0) 

                    Console.WriteLine($"{start}");
                    start--;
                
            
            }
            Console.WriteLine("Task One Completed - Press [ENTER] To Continue!");
            Console.ReadLine(); */
            

            //Task Two - Repeat Character 

           /* Console.WriteLine("For Loop - Repeat Character");
            Console.WriteLine("Please Enter A Character: ");
            string char1 = Console.ReadLine();
            Console.WriteLine("Please Enter The Number Of Times You Would Like To display {char1} ");
            int num1 = int.Parse(Console.ReadLine());

            for (int i = 0; <= num1; i++)
            {
                Console.Write(char1);
            }
            Console.WriteLine("\nTask Two Complete - Press [ENTER] To Continue! ");
            Console.ReadLine(); */

            //Task three - Rectangle 

            Console.Write("Please enter a symbol to use: ");
            string symbol = Console.ReadLine();
            Console.Write("Please enter the height of the rectangle: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Please enter the width of the rectangle: ");
            int w = int.Parse(Console.ReadLine());

            for (int i = 0; i < h; i++)//deals with the height of the rectangle
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nTask 3 end...");
            Console.ReadLine();





        }
    }
}
