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
        }
    }
}
