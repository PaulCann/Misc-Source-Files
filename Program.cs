using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

namespace CodeLibrary
{
    class Program
    {
        static void Main()
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();



            //static void Main(string[] args)
            //{
            //    //FIZZ BUZZ
            //    for (int i = 0; i <= 100; i++)
            //    {
            //        string Output = "";
            //        if (i % 3 == 0) Output = "Fizz";
            //        if (i % 5 == 0) Output += "Buzz";
            //        if (Output == "") Output = i.ToString();
            //        Console.WriteLine(Output); // Finally print the complete output
            //    }
            //    Console.ReadLine();


            //string input = "kincenvizh";

            ////declare the string variable  
            //string final = "";

            ////Get a string of possible substrings with out uniqueness  
            //for (int i = 0; i < input.Length; i++)
            //{
            //    string str = "";
            //    for (int j = i; j < input.Length; j++)
            //    {
            //        str += input[j];
            //        final += str + ",";
            //    }
            //}

            //Remove the ending comma from the string  
            //final = final.Remove(final.Length - 1, 1);

            //Get an array after Spilt the string on basis of comma  
            //string[] arr = final.Split(',');

            //Get the distinct array  
            //arr = arr.Distinct().ToArray();

            //int lengthArr = arr.Length;
            //Console.Write(lengthArr);

            //Print the array  
            //for (int i = 0; i < arr.Length; i++)
            //    Console.Write(arr[i] + " ");



            //string str = "Hello, World.";
            //Console.Write("String= {0} ", str);

            //Console.Write("String= ");
            //foreach (char c in str)
            //{
            //    Console.Write(c);
            //    //Console.ReadKey();
            //}

            //string input = "APPLE";
            //string sub1 = input.Substring(input.Length -1, 1);
            //string sub2 = input.Substring(input.Length -2, 1);
            //string sub3 = sub1 + " " + sub2;
            // Console.WriteLine(sub3);
            //Console.ReadLine();

            //string strIn = "APPLE";
            //int len = strIn.Length
            //int Idx1 strIn.IndexOf
            //string strOut = strIn.IndexOf(strIn.length - 1) + " " + strIn.IndexOf(strIn.length - 2);
            //Console.WriteLine(strOut.Length);


            //int age = 10;
            //string pass = age > 20 ? "pass" : "nopass";
            //Console.WriteLine(pass);

            ///Largest_Pair_Sum_In_Array largestPair = new Largest_Pair_Sum_In_Array();
            //{
            //    int[] arr = { 52, 12, 34, 10, 6, 40, 12, 40, 52 };
            //    int firstMax = 0, secondMax = 0;

            //    for (int i = 0; i < arr.Length; ++i)
            //    {
            //        if (arr[i] > firstMax)
            //        {
            //            secondMax = firstMax;
            //            firstMax = arr[i];
            //        }
            //        else if (arr[i] > secondMax)
            //        {
            //            secondMax = arr[i];
            //        }
            //    }

            //    Console.WriteLine(string.Format("Largest pair sum in given array is: { 0}", firstMax + secondMax));
            //    Console.ReadKey();
            //}

            //Circle cir = new Circle();
            //cir.Calculate(r => 2 * Math.PI * r);

            //Circle cir = new Circle();
            //var field = cir.GetType().GetField("radius", BindingFlags.Instance | BindingFlags.NonPublic);
            //field.SetValue(cir, 5);
            //double circ = cir.Calculate((radius) => 2 * Math.PI * radius);
            //Console.WriteLine(circ);
            //Console.ReadLine();

            // circ.Calculate<Func<double,double>op
            //public double Calculate(Func<double, double> op)
        }


    //        {
    //            //Console.WriteLine("test");
    //            //Console.ReadLine();
    //            //ListCollectionExample();
    //            //CreateListFromArray();
    //            //TestListElements();
    //            //ListIndexOf();
    //            // ArrayExample01();
    //            string s = Reverse("abcd");
    //            Console.WriteLine(s);
    //            Console.ReadLine();
    //        }

    //        static void ListCollectionExample()
    //        {
    //            List<int> list = new List<int>();
    //            for (int i = 0; i < 10; i++)
    //            {
    //                list.Add(i);
    //            }

    //            foreach (int prime in list) // Loop through List with foreach.
    //            {
    //                Console.WriteLine(prime);
    //            }

    //            for (int i = 0; i < list.Count; i++) // Loop with for.
    //            {
    //                Console.WriteLine(list[i]);
    //            }
    //            Console.ReadLine();
    //        }

    //        static void CreateListFromArray()
    //        {
    //            int[] arr = new int[3]; // New array with 3 elements.
    //            arr[0] = 2;
    //            arr[1] = 3;
    //            arr[2] = 5;
    //            List<int> list = new List<int>(arr); // Copy to List.
    //            Console.WriteLine(list.Count);       // 3 elements in List.
    //            Console.ReadLine();
    //        }

    //        static void TestListElements()
    //        {
    //            // New list for example.
    //            List<int> primes = new List<int>(new int[] { 2, 3, 5 });

    //            // See if List contains 3.
    //            foreach (int number in primes)
    //            {
    //                if (number == 3) // Will match once.
    //                {
    //                    Console.WriteLine("Contains 3");
    //                    Console.ReadLine();
    //                }
    //            }
    //        }

    //        static void ListIndexOf()
    //        {
    //            List<int> primes = new List<int>(new int[] { 19, 23, 29 });

    //            int index = primes.IndexOf(23); // Exists.
    //            Console.WriteLine(index);

    //            index = primes.IndexOf(10); // Does not exist.
    //            Console.WriteLine(index);
    //            Console.ReadLine();
    //        }

    //        static string Reverse(string s)
    //        {
    //            char[] charArray = s.ToCharArray();
    //            Array.Reverse(charArray);
    //            return new string(charArray);
    //        }

}
}
