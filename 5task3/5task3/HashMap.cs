using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _5task3
{
    class HashMap<K, V> : IMap<K, V>
    where K : IComparable
    where V : IComparable
    {
        enum Tstate { sfree, sfull, sdel }; // свободно, занято, удалено
        class Cell<TK,TV>
        where TK : IComparable
        where TV : IComparable
        {
            public Cell()
            {
                state = Tstate.sfree;
            }
            public Tstate state;
            public Entry<K, V> info;
        }
        const int n = 101;
        const int c = 3;
        int count;
        Cell<K,V>[] HashTable;
        public HashMap()
        {
            HashTable = new Cell<K,V>[n];
            for (int i = 0; i < n; i++)
            {
                HashTable[i] = new Cell<K,V>();
                HashTable[i].info = new Entry<K, V>();
            }
            count = 0;
        }
        public HashMap(int new_n)
        {
            HashTable = new Cell<K, V>[new_n];
            for (int i = 0; i < n; i++)
            {
                HashTable[i] = new Cell<K, V>();
                HashTable[i].info = new Entry<K, V>();
            }
            count = 0;
        }
        int NextCell(int h, ref int i)
        {
            i++;
            return (h + c * i) % n;
        }
        public void Put(K key, V value)
        {
            if (ContainsKey(key)) this[key] = value;
            else
            {
                int index = key.GetHashCode() % n;
                int i = 1;
                while (HashTable[index].state == Tstate.sfull && i < 2 * n) index = NextCell(index, ref i);
                if (HashTable[index].state != Tstate.sfull)
                {
                    HashTable[index].info.Key = key;
                    HashTable[index].info.Value = value;
                    HashTable[index].state = Tstate.sfull;
                    count++;
                }
                else throw (new MapException("Не удалось добавить элемент!"));
            }
        }
        int IndexOf(K key)
        {
            bool stop= false, ok = false;
            int h1 = key.GetHashCode() % n;
            int  i=0, a = h1;
            while (i < 2 * n && !stop && !ok)
                switch (HashTable[a].state)
                {
                    case Tstate.sfree: stop = true; break;
                    case Tstate.sdel: a = NextCell(h1, ref i); break;
                    case Tstate.sfull: if (HashTable[a].info.Key.Equals(key)) ok = true;
                        else a = NextCell(h1, ref i); break;
                }
            if (ok) return a;
            return -1;
        }
        public void Remove(K key)
        {
                int index = IndexOf(key);
                if (index!=-1)  HashTable[index].state=Tstate.sdel;
                if (count>0) count--;
        }
        public bool ContainsKey(K key)
        {
            if (isEmpty) return false;
            return IndexOf(key) != -1;
        }
        public bool ContainsValue(V value)
        {
            if (isEmpty) return false;
            foreach (var i in HashTable)
                if (i.state == Tstate.sfull && i.info.Value.Equals(value)) return true;
            return false;
        }
        public V this[K key]
        {
            get
            {
                int index = IndexOf(key);
                if (index != -1) return HashTable[index].info.Value;
                return default(V);
            }
            set
            {
                int index = IndexOf(key);
                if (index == -1) return;
                HashTable[index].info.Value = value;
                if (HashTable[index].state != Tstate.sfull) count++;
            }
        }
        public int Count => count;

        public void Clear()
        {
            HashTable = new Cell<K, V>[n];
            for (int i = 0; i < n; i++)
            {
                HashTable[i] = new Cell<K, V>();
                HashTable[i].info = new Entry<K, V>();
            }
            count = 0;
        }
        public bool isEmpty => Count == 0;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<IEntry<K, V>>)this.GetEnumerator();
        }
        public IEnumerator<IEntry<K, V>> GetEnumerator()
        {
            foreach (var i in HashTable)
                if (i.info != null && i.info.Key != null) yield return i.info;
            yield break;
        }
        public IEnumerable<K> Keys
        {
            get
            {
                foreach (var i in HashTable)
                    if (i.state == Tstate.sfull) yield return i.info.Key;
                yield break;
            }
        }
        public IEnumerable<V> Values
        {
            get
            {
                foreach (var i in HashTable)
                    if (i.state == Tstate.sfull) yield return i.info.Value;
                yield break;
            }
        }
    }
}
