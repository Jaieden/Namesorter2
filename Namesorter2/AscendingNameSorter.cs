using System;
using System.Collections.Generic;
using System.Text;

namespace Namesorter2
{
    class AscendingNameSorter : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            string[] NameOne = x.Split(' ');
            string[] NameTwo = y.Split(' ');
            //Compares the surname
            int comparisonResult = NameOne[NameOne.Length - 1].CompareTo(NameTwo[NameTwo.Length - 1]);
            //If surname is the same, loop through given names, returning the result if they are different
            if (comparisonResult == 0)
            {
                for (int i = 0; i < NameOne.Length - 1; i++)
                {
                    comparisonResult = NameOne[i].CompareTo(NameTwo[i]);
                    if (comparisonResult != 0)
                    {
                        return comparisonResult;
                    }
                }
            }
            //If surname is different returns value. Also will return zero if all names are equal
            return comparisonResult;
        }
    }
}
