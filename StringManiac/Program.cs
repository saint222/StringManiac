using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringManiac
{
    class Program
    {
        static void Main(string[] args)
        {
            string readPath = @"C:\Users\Admin\Desktop\Example.txt";
            string writePath = @"C:\Users\Admin\Desktop\Done.txt";
            var correct = false;
            while (!correct)
            {
                Console.WriteLine("Dear maniac. Type a word to find and save in the thread note and press 'Enter'...");
                string findWord = Console.ReadLine();
                string readText;
                using (StreamReader sr = new StreamReader(readPath, System.Text.Encoding.Default))
                {
                    readText = sr.ReadToEnd();
                }
                if (readText.Contains(findWord))
                {
                    int posIndex = readText.IndexOf(findWord);
                    readText = readText.Remove(posIndex, findWord.Length);
                    //readText = readText.Replace(findWord, "...");
                    //Regex reg = new Regex(@"\w?");
                    //readText = reg.Replace(readText, "...");
                    using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                    {
                        sw.Write(findWord+" ");
                        sw.Close();
                    }
                    using (StreamWriter sw = new StreamWriter(readPath, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(readText);
                        sw.Close();
                    }
                    Console.WriteLine($"The word '{findWord}' is found and saved in the note...");
                    correct = true;
                    Console.WriteLine($"Would you like to add one more word to the note?");
                    var correct_1 = false;
                    while (!correct_1)
                    {
                        Console.WriteLine("Press '1' to add a word and '2' to exit...");
                        int choise = Convert.ToInt32(Console.ReadLine());
                        if (choise == 1)
                        {
                            Console.WriteLine("Ok, let's continue!");
                            correct_1 = true;
                            correct = false;
                        }
                        else if (choise == 2)
                        {
                            Console.WriteLine("Ok, check up the ready note...");
                            correct_1 = true;
                        }
                        else
                        {
                            Console.WriteLine("I didn't catch you, try again...");
                            correct_1 = false;
                        }
                    }                   
                    
                }
                else
                {
                    Console.WriteLine($"No maches with a '{findWord}', try to type another word....");
                    correct = false;
                }
                
            }
            Console.ReadLine();
        }
    }
}
