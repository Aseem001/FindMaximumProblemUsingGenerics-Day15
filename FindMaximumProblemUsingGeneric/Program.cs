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
            int[] arr1 = { 12, 45, 67, 234, 67 };
            GenericMaximum<int> generic = new GenericMaximum<int>(arr1);
            Console.WriteLine(generic.MaxMethod());

            string[] arr2 = { "Ram", "Shyam", "Geeta", "Zebra" };
            GenericMaximum<string> gen = new GenericMaximum<string>(arr2);
            Console.WriteLine(gen.MaxMethod());
        }
    }
}
