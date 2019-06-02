using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _5task3
{
    class ArrayMap<K, V> : IMap<K, V>
    where K : IComparable
    where V : IComparable
    {
        Entry<K, V>[] entries;
        public ArrayMap()
        {
            entries = new Entry<K, V>[0];
        }
        public bool ContainsKey(K key)
        {
            if (isEmpty) return false;
            foreach (Entry<K, V> i in entries)
                if (i != null && i.Key.CompareTo(key) == 0) return true;
            return false;
        }
        public bool ContainsValue(V value)
        {
            if (isEmpty) return false;
            foreach (Entry<K, V> i in entries)
                if (i != null && i.Value.CompareTo(value) == 0) return true;
            return false;
        }
        public V this[K key]
        {
            get
            {
                foreach (Entry<K, V> i in entries)
                    if (i.Key.CompareTo(key) == 0) return i.Value;
                return default(V);
            }
            set
            {
                foreach (Entry<K, V> i in entries)
                    if (i.Key.CompareTo(key) == 0) i.Value = value;
            }
        }
        public int Count { get { return entries.Length; } }
        public void Put(K key, V value)
        {
            if (ContainsKey(key)) this[key] = value;
            else
            {
                Entry<K, V>[] tmp = new Entry<K, V>[Count + 1];
                Array.Copy(entries, 0, tmp, 0, Count);
                entries = tmp;
                entries[Count - 1] = new Entry<K, V>();
                entries[Count-1].Key = key;
                entries[Count-1].Value = value;
            }
        }
        public void Clear()
        {
            entries = new Entry<K, V>[0];
        }
        public void Remove(K key)
        {
            if (ContainsKey(key))
            {   
                int i = 0;
                while (!(entries[i].Key.CompareTo(key) == 0)) i++;
                Entry<K, V>[] tmp = new Entry<K, V>[Count -1];
                Array.Copy(entries, 0, tmp, 0, i);
                Array.Copy(entries, i+1, tmp,i, Count-i-1);
                entries = tmp;
            }
        }
        public bool isEmpty => Count == 0;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<IEntry<K, V>>)this.GetEnumerator();  
        }
        public IEnumerator<IEntry<K, V>> GetEnumerator()
        {
            foreach (Entry<K, V> i in entries)
                yield return i;
            yield break;
        }
        public IEnumerable<K> Keys
        {
            get
            {
                foreach (Entry<K, V> i in entries)
                    yield return i.Key;
                yield break;
            }
        }
        public IEnumerable<V> Values
        {
            get
            {
                foreach (Entry<K, V> i in entries)
                    yield return i.Value;
                yield break;
            }
        }
    }
}
