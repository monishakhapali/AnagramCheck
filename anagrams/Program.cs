using System;
using System.Collections;

namespace anagrams
{
    class Program
    {
        static int ASCII_SIZE = 256;
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string s = "SILEET";
            string s1 = "LISTEN";

        
            bool flag= true;
            int[] count = new int[ASCII_SIZE];

            int[] count1 = new int[ASCII_SIZE];
            if (s.Length != s1.Length)
            {
                flag = false;
            }
            for (int i = 0; i < s.Length; i++)
            {
                count[s[i]]++;
                count1[s1[i]]++;
            }
            
            for(int j =0; j< s.Length; j++)
            {
                if(count[s[j]] != count1[s1[j]])
                {
                    flag = false;
                }
            }
            Console.WriteLine(flag);
            Console.ReadLine();



        }
    }
}
