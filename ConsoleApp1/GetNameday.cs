using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    public class GetNameday
    {
        List<string> listA = new List<string>();
        List<string> listB = new List<string>();
        int input;
        int count;
        public string indexError = "Whoops! Enter number within given range!";
        public string numberError = "Whoops! Did you enter a number?";
        public void SetLists(String path)
        {
            using (var reader = new StreamReader(path))
            {

                try
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        listA.Add(values[0]);
                        listB.Add(values[1]);

                    }
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Something wrong with csv file :", ex);
                }
            }
        }

        public void Namedays()
        {
            

            Console.WriteLine("Select date to show who's nameday it is!");
            Console.WriteLine("Choose date with number and press enter: \r\n");
                
            for (int i = 0; i < listA.Count; i++)
                {
                    Console.WriteLine(i + " = " + listA[i]);
                 }
            this.input = -1;
            this.count = listA.Count;
                while (input >= count || input <= 0)
                {
                    string numString = Console.ReadLine();
                    Console.WriteLine(IsInt(numString));
                }

            Console.Clear();
            Console.WriteLine(listA[input] + " is nameday of " + listB[input] + "!");
            Console.ReadLine();

        }
        public string IsInt(string numString)
        { 
            int number1 = 0;
            bool canConvert = int.TryParse(numString, out number1);
            if (canConvert == true)
            {
                this.input = number1;
                

                if (input >= count || input <= 0)
                {
                    return indexError;
                }
                return null;
            }
            else
            {
                return numberError;
            }
        }
       
    }
}
