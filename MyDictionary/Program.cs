﻿using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
           // Console.WriteLine(myDictionary.Count);
            myDictionary.Add("Oğuz" , 1);
            myDictionary.Add("Busra" , 2);
            myDictionary.Add("Fatma" , 3);

            Console.WriteLine(myDictionary);

        }
    }
}
