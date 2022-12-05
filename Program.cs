using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main menu");
            Console.WriteLine("++++++++");
            Console.WriteLine("1. Count vowels");
            Console.WriteLine("2. Count space");
            Console.WriteLine("3. Count words");
            Console.WriteLine("4. Replace");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Please enter your Selection [ ]");
            int choice;
            int counter = 0;
            choice = Convert.ToInt32(Console.ReadLine());
            string str;

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please enter your text : ");
                    str = Console.ReadLine();
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str.Substring(i, 1).ToLower().Equals("a"))
                        {
                            counter++;
                        }else if (str.Substring(i, 1).ToLower().Equals("e"))
                        {
                            counter++;
                        }
                        else if (str.Substring(i, 1).ToLower().Equals("i"))
                        {
                            counter++;
                        }
                        else if (str.Substring(i, 1).ToLower().Equals("o"))
                        {
                            counter++;
                        }
                        else if (str.Substring(i, 1).ToLower().Equals("u"))
                        {
                            counter++;
                        }
                        
                    }
                    Console.WriteLine("Total number of vowels: " + counter);
                    break;
                case 2:
                    Console.WriteLine("please enter your string :");
                    
                     str = Console.ReadLine();  
                    for (int i = 0; i<str.Length; i++)
                    {
               
                        if(str.Substring(i, 1).ToLower().Equals(" "))
                        {
                            counter++;
                        }
                        
                    }
                   
                    Console.WriteLine("Total number of space: " + counter);
                    break;
                case 3:
                    Console.WriteLine("please enter your String: ");
                    str = Console.ReadLine();
                    for (int i = 0; i < str.Length; i++)
                    {

                        if (str.Substring(i, 1).Equals(" ") && !str.Substring(i + 1, 1).Equals(" "))
                        {
                            counter++;
                        }

                    }
                    Console.WriteLine("There are {0} number of words: ", ++counter);
                    break;
                case 4:
                    Console.WriteLine("Pleae enter your text");
                    str = Console.ReadLine();
                    int p = -1;
                    string ftext, rtext;
                    Console.WriteLine("please text you want to replace from: ");
                    ftext = Console.ReadLine();
                    Console.WriteLine("please text you want to replace to: ");
                    rtext = Console.ReadLine();
                    do
                    {
                        p = str.IndexOf(ftext, p + 1);
                        if (p == -1) break;
                        str = str.Remove(p, ftext.Length);
                        str = str.Insert(p, rtext);
                    } while (p != -1);
                    Console.WriteLine(str);
                    break;
                
                
            }


        }
    }
}
