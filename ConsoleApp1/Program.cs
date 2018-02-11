using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNameday name = new GetNameday();
            name.SetLists(@"C:\nimet.csv");
            name.Namedays();
        }

    }
}