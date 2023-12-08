using System;

namespace Maskify
{
    class Program
    {
        static void Main(string[] args)
        {
            string Maskify(string cc)
            {
                string newstr = "";
                if (cc.Length > 4)
                {
                    for (int i = 0; i < cc.Length - 4; i++)
                        newstr = newstr + "#";
                    newstr = newstr + cc.Substring(cc.Length - 4, 4);
                }
                else
                    return cc;

                return newstr;
            }
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("Enter your informataion : ");
                string info = Console.ReadLine();
                Console.WriteLine("Your maskify info : ");
                Console.WriteLine(Maskify(info));
                Console.WriteLine("Enter 0 to exit or 1 to continue ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 0 || userInput == 1)
                {
                    if (userInput == 0)
                    {
                        exit = false;
                    }

                    continue;
                }

                Console.WriteLine("Invalid input. Please enter 0 or 1.");
            }
        }
    }
}

