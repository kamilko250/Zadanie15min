using System;
using System.IO;

namespace zadanie
{
    class Solution 
    {
        public static int solution(int N)
        {
            int result = 0;
            int bufor = 0;

            // 010101010101001
            //100010
            //101
            int count_1 = 0;
            while(N > 0)
            { 
                if (N % 2 == 1)
                {
                    count_1++;
                    if (result < bufor && count_1 >= 2)
                    {
                        result = bufor;
                    }
                    bufor = 0;
                }
                else if (N % 2 == 0)
                {
                   bufor++;
                }
                //przesuwanie o jeden 
                if(N % 2 == 1)
                   N--;
                N /= 2;
            }
            //10011
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter writer = new StreamWriter("100wynikow.txt");
            Random random = new Random();
            for (int i = 0; i < 100 ; i++)
            {
                int v = random.Next();
                writer.WriteLine(Convert.ToString(v, 2) + " " + Solution.solution(v));
            }
            writer.Close();
        }
    }
}
