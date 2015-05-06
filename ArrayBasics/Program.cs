using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace ArrayBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';
            a += 'c';
            Console.WriteLine("Value of addition is={0}", a);
            //string[] names = {"Apple", "Orange", "Grape","Banana"};
            //IEnumerator e = names.GetEnumerator();
            //while (e.MoveNext())
            //{
            //    string str = (string)e.Current;
            //    Console.WriteLine("Fruit Name={0}",str);
            //}
            Console.WriteLine("Press any key to finish");
            Console.ReadLine();
        }
    }
}
