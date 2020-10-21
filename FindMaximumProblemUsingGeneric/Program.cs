// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Aseem Anand"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FindMaximumProblemUsingGeneric
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            /// UC 1 : Finds max among the given three data
            Console.WriteLine(FindMaximum.MaxIntegerAmongThree(70, 50, 60));
            /// UC 2 : Finds the max float value among three
            Console.WriteLine(FindMaximum.MaxFloatAmongThree(5.645, 5.64, 5.648));
            /// UC 3 : Finds the max string value among three
            Console.WriteLine(FindMaximum.MaxStringAmongThree("Apple","Banana","Peach"));

            /// UC 3: Refactor 1
            Console.WriteLine(FindMaximum.MaxValueAmongThreeRefactor1<int>(12,45,56));
            Console.WriteLine(FindMaximum.MaxValueAmongThreeRefactor1<double>(12.45, 12.56, 12.89));
            Console.WriteLine(FindMaximum.MaxValueAmongThreeRefactor1<string>("Rain","Game","Football"));

            /// UC 3 : Refactor 2
            GenericMaximum<int> maxInt = new GenericMaximum<int>(50, 40, 300);
            GenericMaximum<double> maxFloat = new GenericMaximum<double>(23.56,45.67,67.23);
            GenericMaximum<string> maxString = new GenericMaximum<string>("Cricket", "Football", "Hockey");
            Console.WriteLine(maxInt.MaxMethod());
            Console.WriteLine(maxFloat.MaxMethod());
            Console.WriteLine(maxString.MaxMethod());
        }
    }
}
