using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> animalList = new List<string>() { "cat", "dog", "bird", "snake", "rabbit" };
            foreach (string currentList in animalList)
            {
                Console.WriteLine(currentList);
            }

            {
                Console.WriteLine();
            }

            List <bool> boolList = new List<bool>() { true, false, false, true, false};

            foreach (bool listBool in boolList)

            if (listBool == true)
                 {
                    Console.WriteLine("Better bring an umbrella.");
                 }
                        else

                {
                    Console.WriteLine("No rain today, enjoy the sun.");
                }

                {
                    Console.WriteLine();
                }

            
                int[] arrayList = new int[] { 5, 2, 3, 4, 1, 5, 6, 3 };

                List<int> newList = new List<int>(arrayList);
            {
                Console.WriteLine(newList.Count);
                newList.Sort();
             }
            
            foreach (int newList8 in newList)
            {    
                Console.WriteLine(newList8);
            }
            {
                Console.WriteLine(newList.Count);
                int[] newArrayList = arrayList.ToArray();
            }

            List<int> practiceList = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            List<int> sampleList = new List<int>() { 23, 77, 15 };

            if (practiceList.Contains(23))
            {
                Console.WriteLine(23);
            }

            if (practiceList.Contains(77))
            {
                Console.WriteLine(77);
            }

            if (practiceList.Contains(15))
            {
                Console.WriteLine(15);
            }
            Console.WriteLine(practiceList.Count);
            Console.WriteLine();
            practiceList.Remove(23);
            practiceList.Remove(77);
            practiceList.Remove(32);
            practiceList.Remove(6);
            Console.WriteLine();
            Console.WriteLine(practiceList.Count);
            Console.WriteLine();
            if (practiceList.Contains(23))
            {
                Console.WriteLine(23);
            }
            else
            {
                Console.WriteLine("The number 23 is not on the list.");
            }

            if (practiceList.Contains(77))
            {
                Console.WriteLine(77);
            }
            else
            {
                Console.WriteLine("The number 77 is not on the list");
            }
               
            if (practiceList.Contains(15))
            	{
                    Console.WriteLine(15);            
                }
            else
            {
                Console.WriteLine("There is no 15 on the list");
            } 
                                   
         }

    }
}
