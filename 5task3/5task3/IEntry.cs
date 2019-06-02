using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5task3
{
     public interface IEntry<K, V>
    where K : IComparable
    where V : IComparable
    {
        K Key { get; }
        V Value { get; set; }
    }
}
