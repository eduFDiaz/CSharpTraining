using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Training.day5.readWriteFiles
{
    class WriteFile
    {
        static void Main()
        {
            try
            { //Pass the filepath and filename to the StreamWriter Constructor                 
                StreamWriter sw = new StreamWriter("C:/Users/eduardo/Desktop/Refreshing C#/Training/day5.readWriteFiles/Test.txt");
                                 
                sw.WriteLine("Hello World!!");//Write a line of text                 
                sw.WriteLine("From the StreamWriter class");//Write a second line of text                   
                sw.Close();//Close the file
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
    }
}
