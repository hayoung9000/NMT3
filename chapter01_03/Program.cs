using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter01_03
{
    class Program
    {
        class CMyInt
        {
            public int theValue;
            public override string ToString()
            {
                Console.WriteLine("-");
                return theValue.ToString();
            }
        }
        static void Main(string[] args)
        {
            int a = 12345;
            int b = a;
            Console.WriteLine("Before");
            Console.WriteLine("a : {0}", a);
            Console.WriteLine("b : {0}", b);

            a = 98765;
            Console.WriteLine("After");
            Console.WriteLine("a : {0}", a);
            Console.WriteLine("b : {0}", b);

            object c = 12345;
            object d = c;
            Console.WriteLine("Before");
            Console.WriteLine("a : {0}", c);
            Console.WriteLine("b : {0}", d);

            c = 98765;
            Console.WriteLine("After");
            Console.WriteLine("a : {0}", c);
            Console.WriteLine("b : {0}", d);

            CMyInt e = new CMyInt();
            e.theValue = 12345;
            CMyInt f = e;
            Console.WriteLine("Before");
            Console.WriteLine("e : {0}", e);
            Console.WriteLine("f : {0}", f);
            e.theValue = 56789;
            Console.WriteLine("After");
            Console.WriteLine("e : {0}", e);
            Console.WriteLine("f : {0}", f);

            //Console.Write("Input name:");
            //string tmpName = Console.ReadLine();
            //Console.WriteLine("Your Name : {0}", tmpName);

            //Console.Write("\nInput char:");
            /*ConsoleKeyInfo tmpKey = Console.ReadKey();

            int i;
            for (i = 0; i < tmpName.Length; i++)
            {
                if (tmpName[i].Equals(tmpKey.KeyChar) == true)
                {
                    break;
                }
            }
            if (i == tmpName.Length)
            {
                Console.WriteLine("\nChar:{0} Fail", tmpKey.KeyChar);
            }
            else
            {
                Console.WriteLine("\nChar:{0} Success", tmpKey.KeyChar);
            }
            Console.ReadKey();*/

            //string searchString = Console.ReadLine();
            //int result = tmpName.IndexOf(searchString);
            //if (result == 1)
            //{
            //    Console.WriteLine("\nChar : {0} Fail", searchString);
            //}
            //else
            //{
            //    Console.WriteLine("\nChar:{0} Success", searchString);
            //}
            //Console.Write("input Number : ");
            //string tempNumber = Console.ReadLine();
            //Console.WriteLine("100+input : {0}", 100 +Convert.ToInt16(tempNumber));

            String strSW = "apple";
            switch (strSW)
            {
                case "apple":
                    Console.WriteLine("apple, apple");
                    break;
                case "banana":
                    Console.WriteLine("banana, banana");
                    break;
                default:
                    Console.WriteLine("Fruits");
                    break;
            }
            int i;
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            foreach(int iter in arr)
            {
                Console.Write("{0}", iter);
            }
            Console.WriteLine();
        }
    }
}
