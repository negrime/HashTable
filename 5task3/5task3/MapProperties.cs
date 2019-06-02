using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace _5task3
{
    class MapProperties : IMap<String, String>
    {
        LinkedMap<String, String> map;
        public MapProperties()
        {
            map = new LinkedMap<String, String>();
        }
        public bool ContainsKey(String key)
        {
            return map.ContainsKey(key);
        }
        public bool ContainsValue(String value)
        {
            return map.ContainsValue(value);
        }
        public String this[String key]
        {
            get
            {
                return map[key];
            }
            set
            {
                map[key] = value;
            }
        }
        public int Count
        {
            get
            {
                return map.Count;
            }
        }
        public void Put(String key, String value)
        {
            map.Put(key, value);
        }
        public void Clear()
        {
            map.Clear();
        }
        public void Remove(String key)
        {
            map.Remove(key);
        }
        public bool isEmpty { get { return map.isEmpty; } }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<IEntry<String, String>>)this.GetEnumerator();
        }
        public IEnumerator<IEntry<String, String>> GetEnumerator()
        {
            return map.GetEnumerator();
        }
        public IEnumerable<String> Keys
        {
            get
            {
                return map.Keys;
            }
        }
        public IEnumerable<String> Values
        {
            get
            {
                return map.Values;
            }
        }
    }
}
