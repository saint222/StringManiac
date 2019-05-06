using System;

namespace StringManiac
{
    public class MethClass
    {
        public void Menu()
        {
            var exit = false;
            while (!exit)
            {
                Console.WriteLine("Dear maniac, please, make your choice and press Enter...");
                Console.WriteLine("1 - Write a thred note.");                              
                Console.WriteLine("2 - Exit.");
                var answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        //ThreadNote();
                        break;                                     
                    case "2":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect input, try again...");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}