using MyFirstProject.day2.SampleProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Training.day4.ArrayListAndList
{
    class DictionaryDemo
    {
        public static void Main(string[] args)
        {
            // Dictionary Key/Value par
            Dictionary<string,int> dict = new Dictionary<string, int>();
            dict.Add("Eduardo", 32);
            dict.Add("Consuelo", 50);
            dict.Add("Yaniel", 25);

            foreach (Object key in dict.Keys)
            {
                Console.WriteLine("dict of key:{0} value:{1}",
                    key.ToString(), dict[key.ToString()]);
            }
        }
    }
}
