using System;
using System.Collections.Generic;

namespace Assignment_G2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> pmoi = new Dictionary<int, string>();
            pmoi.Add(1998,"Atal Bihari Vajpayee"); //adding a key/value using the Add() method
            pmoi.Add(2014,"Narendra Modi");
            pmoi.Add(2004,"Manmohan Singh");
            Console.WriteLine("\nPrime minister of 2004 : {0}",pmoi[2004]);
            pmoi.Add(2021,"Narendra Modi");
            var sorteddict = new SortedDictionary<int,string>(pmoi);
            Console.WriteLine("\nSorted order :");
            foreach (var element in pmoi)
            {
                Console.WriteLine("Year {0} PMOI {1}",element.Key,element.Value);
            }
        }
    }
}
