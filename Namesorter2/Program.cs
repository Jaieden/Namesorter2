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
            Dictionary<string, IComparer<string>> sorters = new Dictionary<string, IComparer<string>>(){ {"-a", new AscendingNameSorter() }, { "-d", new DescendingNameSorter() } };
            Array.Sort(names, sorters[args[1]]);
            Console.WriteLine(string.Join("\n",names));
            outputFile.FileContents = names;
        }

    }
}
