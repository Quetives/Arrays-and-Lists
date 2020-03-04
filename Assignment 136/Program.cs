﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_136
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] str = new string[] { "Hello", "Greetings", "Hi", "Aloha" };
           int[] intArray = new int[] { 5, 10, 15, 20 };
            int strChoice;
            int intChoice;
            int listChoice;

            List<string> wordList = new List<string>();
            wordList.Add("Boring");
            wordList.Add("Let's do this!");
            wordList.Add("Come on!");
            wordList.Add("Okay, okay...");


            Console.WriteLine("Please select an item in the string array. 0 - 3:");
            strChoice = Convert.ToInt32(Console.ReadLine());
            if (strChoice < str.Length)
            {
                Console.WriteLine(str[Convert.ToInt32(strChoice)]);
            }else
            {
                Console.WriteLine("That number does not exist in the index.");
            }
            

            Console.WriteLine("Please select an item in the integer array. 0 - 3:");
            intChoice = Convert.ToInt32(Console.ReadLine());
            if (intChoice < intArray.Length)
            {
                Console.WriteLine(intArray[intChoice]);
            } else
            {
                Console.WriteLine("That number does not exist in the index.");
            }
         
            Console.WriteLine("Please select an index from the string list. 0 - 3");
            listChoice = Convert.ToInt32(Console.ReadLine());
            if (listChoice < wordList.Count)
            {
                Console.WriteLine(wordList[Convert.ToInt32(listChoice)]);
            }
            else
            {
                Console.WriteLine("That number does not exist in the index.");
            }
            Console.ReadLine();
        }
    }
}
