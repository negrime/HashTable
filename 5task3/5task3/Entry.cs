using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5task3
{
    class Entry<K, V> : IEntry<K, V> 
    where K : IComparable
    where V : IComparable
    {
        public K Key { get; set; }

        public V Value { get; set; }
    }
}
