using Autofac;
using Autofac.Features.Indexed;
using System;
using System.Collections.Generic;
using System.Text;

namespace Namesorter2
{
    class SorterGetter
    {

        public IComparer<string> Resolve(string argFlag)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<AscendingNameSorter>().Named<IComparer<string>>("-a");
            builder.RegisterType<DescendingNameSorter>().Named<IComparer<string>>("-d");
            var container = builder.Build();
            IComparer<string> sorter = container.ResolveNamed<IComparer<string>>(argFlag);
            return sorter;
        }
    }
}
