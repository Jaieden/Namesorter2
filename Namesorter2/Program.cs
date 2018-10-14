using Autofac;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Namesorter2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileData inputFile = new FileData(args[0]);
            FileData outputFile = new FileData("sorted-names-list.txt");
            string[] names = inputFile.FileContents;
            SorterGetter sortOrderGetter = new SorterGetter();
            Array.Sort(names, sortOrderGetter.Resolve("args[1]"));
            Console.WriteLine(string.Join("\n",names));
            outputFile.FileContents = names;
        }

    }
}
