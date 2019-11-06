using MyFirstProject.day2.SampleProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Training.day4.ArrayListAndList
{
    class HashDemo
    {
        public static void Main(string[] args)
        {
            // HashTable Key/Value par
            Hashtable table = new Hashtable();
            table.Add("name", "eduardo");
            table.Add("age", 32);
            table.Add("location", "Lewisville");
            table.Add("married", false);

            foreach(DictionaryEntry pair in table)
            {
                Console.WriteLine("table of key:{0} value:{1}",
                    pair.Key, pair.Value);
            }
        }
    }
}
