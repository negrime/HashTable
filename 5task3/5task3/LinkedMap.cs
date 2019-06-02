using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _5task3
{
    class LinkedMap<K, V> : IMap<K, V>
        where K : IComparable
        where V : IComparable
    {
        class TItem
        {
            public Entry<K, V> info;
            public TItem next;
            public TItem(K _key, V _value)
            {
                info = new Entry<K, V>();
                info.Key = _key;
                info.Value = _value;
                next = null;
            }
        }
        TItem head;
        public LinkedMap()
        {
            head = null;
        }
        public bool ContainsKey(K key)
        {
            if (isEmpty) return false;
            else
            {
                TItem i = head;
                do
                {
                    if (i.info.Key.Equals(key))
                        return true;
                    i = i.next;
                }
                while (i != null);
                return false;
            }
        }
        public bool ContainsValue(V value)
        {
            if (isEmpty) return false;
            else
            {
                TItem i = head;
                do
                {
                    if (i.info.Value.Equals(value))
                        return true;
                    i = i.next;
                }
                while (i != null);
                return false;
            }
        }
        public V this[K key]
        {
            get
            {
                TItem i = head;
                while (i != null)
                {
                    if (i.info.Key.Equals(key))
                        return i.info.Value;
                    i = i.next;
                }
                return default(V);
            }
            set
            {
                TItem i = head;
                while (i != null)
                {
                    if (i.info.Key.Equals(key))
                        i.info.Value = value;
                    i = i.next;
                }
            }
        }
        public int Count
        {
            get
            {
                int count = 0;
                TItem i = head;
                while (i != null)
                {
                    count++;
                    i = i.next;
                }
                return count;
            }
        }
        public void Put(K key, V value)
        {
            if (ContainsKey(key)) this[key] = value;
            else
            {
                if (head == null) head = new TItem(key, value);
                else
                {
                    TItem i = head;
                    while (i.next != null) i = i.next;
                    i.next = new TItem(key, value);
                }
            }
        }
        public void Clear()
        {
            head = null;
        }
        public void Remove(K key)
        {
            if (ContainsKey(key))
            {
                if (head.info.Key.Equals(key)) head = head.next;
                else
                {
                    TItem i = head;
                    while (i.next != null)
                    {
                        if (i.next.info.Key.Equals(key))
                        {
                            i.next = i.next.next;
                            break;
                        }
                        else i = i.next;
                    }
                }
            }
        }
        public bool isEmpty { get { return head == null; } }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<IEntry<K, V>>)this.GetEnumerator();
        }
        public IEnumerator<IEntry<K, V>> GetEnumerator()
        {
            TItem i = head;
            while (i != null)
            {
                yield return i.info;
                i = i.next;
            }
            yield break;
        }
        public IEnumerable<K> Keys
        {
            get
            {
                TItem i = head;
                while (i != null)
                {
                    yield return i.info.Key;
                    i = i.next;
                }
                yield break;
            }
        }
        public IEnumerable<V> Values
        {
            get
            {
                TItem i = head;
                while (i != null)
                {
                    yield return i.info.Value;
                    i = i.next;
                }
                yield break;
            }
        }
    }
}
