using Castle.DynamicProxy.Generators.Emitters;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTests.BubbleSort
{
    public class SortSentence
    {
        public SortSentence()
        {

        }

        public char[] SortSentenceUsingBubbleSort(string sentence)
        {
            char temp;
            string myStr = "The quick brown fox jumped over a dog!";  
            string str = myStr.ToLower();
            char[] charstr = str.ToCharArray();
            for (int i = 1; i < charstr.Length; i++)
            {
                for (int j = 0; j < charstr.Length - 1; j++)
                {
                    if (charstr[j] > charstr[j + 1])
                    {
                        temp = charstr[j];
                        charstr[j] = charstr[j + 1];
                        charstr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine(charstr); 
            Console.ReadLine();

            return charstr;
        }
    }
}
