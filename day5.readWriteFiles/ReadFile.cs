using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Training.day5.readWriteFiles
{
    class ReadFile
    {
        static void Main()
        {
            String line;
            try
            { //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:/Users/eduardo/Desktop/Refreshing C#/Training/day5.readWriteFiles/Test.txt"); //Read the first line of text                 
                line = sr.ReadLine(); //Continue to read until you reach end of file                 
                while (line != null)
                { //write the lie to console window                     
                    Console.WriteLine(line);
                    //Read the next line                     
                    line = sr.ReadLine();
                }
                //close the file                 
                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }
    }
}
