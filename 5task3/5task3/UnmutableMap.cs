using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _5task3
{
    class UnmutableMap<K, V> : IMap<K, V>
        where K : IComparable
        where V : IComparable
    {
        LinkedMap<K, V> map;
        public UnmutableMap()
        {
            map = new LinkedMap<K, V>();
            map.Put(default(K), default(V));
        }
        public UnmutableMap(IMap<K, V> source)
        {
            map = new LinkedMap<K, V>();
            if (!source.isEmpty)
             foreach (IEntry<K,V> i in source)
                map.Put(i.Key, i.Value);
        }
        public bool ContainsKey(K key)
        {
            return map.ContainsKey(key);
        }
        public bool ContainsValue(V value)
        {
            return map.ContainsValue(value);
        }
        public V this[K key]
        {
            get
            {
                return map[key];
            }
            set
            {
                throw (new MapException("Невозможно установить значение свойства - индексатора у неизменяемого множества!"));
            }
        }
        public int Count { get { return map.Count; } }
        public void Put(K key, V value)
        {
            throw (new MapException("Невозможно добавить элемент в неизменяемое множество!"));
        }
        public void Clear()
        {
            throw (new MapException("Невозможно очистить неизменяемое множество!"));
        }
        public void Remove(K key)
        {
            throw (new MapException("Невозможно удалить элемент из неизменяемого множества!"));
        }
        public bool isEmpty { get { return map.isEmpty; } }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<IEntry<K, V>>)this.GetEnumerator();
        }
        public IEnumerator<IEntry<K, V>> GetEnumerator()
        {
            return map.GetEnumerator();
        }
        public IEnumerable<K> Keys
        {
            get
            {
                return map.Keys;
            }
        }
        public IEnumerable<V> Values
        {
            get
            {
                return map.Values;
            }
        }
    }
}
