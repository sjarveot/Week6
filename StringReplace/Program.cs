using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Hello World!" tärniga(*);

            string helloW = "Hello World!";

            // for (int i = 0; i < helloW.Length-1; i++)
            //  {
            //      helloW[i] = "*";
            //  }
            helloW = helloW.Replace('o', '*');

            Console.WriteLine(helloW);
        }
    }
}
