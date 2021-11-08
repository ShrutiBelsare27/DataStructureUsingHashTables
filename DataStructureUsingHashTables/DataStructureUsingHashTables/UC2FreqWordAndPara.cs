using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureUsingHashTables
{
   public class UC2FreqWordAndPara
    {
        public void FreqPara()
        {
            MyMapNode<string, int> myMapNode = new MyMapNode<string, int>(5);
       
           string sentence = "Paranoids are not paranoid because they are paranoid but because" +
           " they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = sentence.ToLower().Split(" ");
            foreach (string word in words)
            {
                int value = myMapNode.Get(word);
                if (value == 0)
                    value = 1;
                else
                    value = value + 1;
                myMapNode.Add(word, value);
            }
            int frequency = myMapNode.Get("paranoid");
            Console.WriteLine("Frequency of word paranoid in paragraph = " + frequency);
        }
    }
}
