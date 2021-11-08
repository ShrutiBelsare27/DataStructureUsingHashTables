using System;

namespace DataStructureUsingHashTables
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("UC1: ");
            UC1WordFrequency freq = new UC1WordFrequency();
            freq.Frequency();

            Console.WriteLine("\n UC2: ");
            UC2FreqWordAndPara freq1 = new UC2FreqWordAndPara();
            freq1.FreqPara();


            Console.WriteLine("\n UC3: ");
            UC3Remove rm = new UC3Remove();
            rm.Remove();
           
        }
    }
}
