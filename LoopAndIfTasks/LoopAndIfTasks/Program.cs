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

            //Part One Tasks 

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

            /*  Console.Write("Please enter a symbol to use: ");
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
              Console.WriteLine("\nTask Three Completed - Press [ENTER] To Continue!");
              Console.ReadLine(); */


            //Part Two Tasks

            //Task One 

            /* Console.WriteLine("Task one - For Loop 1 - 50 ");
             for (int i = 1; i <= 50; i++)
             {
                 Console.WriteLine(i);
             } 

            Console.WriteLine("Task One For Loop Completed - Press [ENTER] To Continue!");
            Console.ReadLine(); */

            /* Console.WriteLine("Task One - While Loop 1 - 50");

              int counter = 1;
              int finish = 50;
              while (counter <= finish)
              {
                  Console.WriteLine(counter);
                  counter++;
              }
              Console.WriteLine("Task One While Loop Completed - Press [ENTER] To Continue!"); 
              Console.ReadLine(); */

            //Task one Extention

            /* Console.Clear();
             Console.WriteLine("Task One Extention -  ");

             for (int i = 1; i <= 50; i++)
             {
                 Console.Write($"{i} ");
                 if (i % 10 == 0)
                     Console.WriteLine();
             }

             Console.WriteLine("Task One Extention Completed - Press [ENTER] To Continue! ");
             Console.ReadLine(); */

            //Task Two 

            /*Console.WriteLine("Task Two - ");

             double total = 0;

             for (int i = 1; i <= 10; i++)
             {
                 Console.WriteLine($"Enter A Number: ");
                 total = double.Parse(Console.ReadLine());
             }

             Console.WriteLine($"Total: {total}");
             Console.WriteLine("Task Two Completed - Press [ENTER] To Continue! ");
             Console.ReadLine(); */

            //Task Two Extention 

            /* Console.Clear();
             Console.WriteLine("Task Two Extention: ");
             Console.Write("Please Enter A Number: ");
             total = double.Parse(Console.ReadLine());

             Console.WriteLine("Would you Like To Enter Another Number? (yes/no): ");
             string input = Console.ReadLine().ToLower();
             if (input == "yes")
                 check = false;
             while (check == true) ;  */



            //Task Three 

            Console.WriteLine("Task Three - Even Numbers: ");
            Console.Write("Please Enter A Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                if (i != 0 && i %2 ==0 )
                    Console.WriteLine(i);
            }
            Console.WriteLine("Task Three Completed - Press [ENTER] To Continue! ");
            Console.ReadLine();




         

        }
    }
}
