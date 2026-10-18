// -----------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------------------

using BenchmarkDotNet.Running;
using System;
//using static Microsoft.CodeAnalysis.CSharp.SyntaxTokenParser;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Fan_in__Fan_out;
using System.Threading.Tasks;

namespace Fan_in__Fan_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _ = BenchmarkRunner.Run(typeof(Program).Assembly);

            //var data = new int[35];
            //for (var i = 0; i < data.Length; i++)
            //    data[i] = i;


            //Task.Run(async () =>
            //{
            //    var result = await data.FanOut(v => v * 2, Environment.ProcessorCount).FanIn().ToArray();

            //    Console.WriteLine(result);
            //}).Wait();


        }
    }
}
