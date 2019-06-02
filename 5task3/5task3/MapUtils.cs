using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5task3
{
    delegate bool CheckDelegate<K, V>(IEntry<K, V> source) where K : IComparable where V : IComparable;
    delegate void ActionDelegate<K, V>(IEntry<K, V> source) where K : IComparable where V : IComparable;
    delegate IMap<K, V> MapConstructorDelegate<K, V>() where K : IComparable where V : IComparable;
    class MapUtils
    {
        public static bool Exists<K, V>(IMap<K, V> sourcemap, CheckDelegate<K, V> del) where K : IComparable where V : IComparable
        {
            foreach (IEntry<K, V> i in sourcemap)
            {
                if (del(i)) return true;
            }
            return false;
        }
        public static IMap<K, V> FindAll<K, V>(IMap<K, V> sourcemap, CheckDelegate<K, V> checkdel, MapConstructorDelegate<K, V> constdel) where K : IComparable where V : IComparable
        {
            IMap<K, V> temp = constdel();
            foreach (IEntry<K, V> i in sourcemap)
            {
                if (checkdel(i)) temp.Put(i.Key, i.Value);
            }
            return temp;
        }
        public static void ForEach<K, V>(IMap<K, V> sourcemap, ActionDelegate<K, V> del) where K : IComparable where V : IComparable
        {
            foreach (IEntry<K, V> i in sourcemap) del(i);
        }
        public static bool CheckForAll<K, V>(IMap<K, V> sourcemap, CheckDelegate<K, V> del) where K : IComparable where V : IComparable
        {
            if (sourcemap.isEmpty) return false;
            else
            {
                bool OK = true;
                foreach (IEntry<K, V> i in sourcemap)
                {
                    OK = OK && del(i);
                }
                return OK;
            }
        }

        public static MapConstructorDelegate<K, V> ArrayMapConstructor<K, V>() where K : IComparable where V : IComparable
        {
            return new MapConstructorDelegate<K, V>(Activator.CreateInstance<ArrayMap<K, V>>);
        }
        public static MapConstructorDelegate<K, V> LinkedMapConstructor<K, V>() where K : IComparable where V : IComparable
        {
            return new MapConstructorDelegate<K, V>(Activator.CreateInstance<LinkedMap<K, V>>);
        }
        public static MapConstructorDelegate<K, V> HashMapConstructor<K, V>() where K : IComparable where V : IComparable
        {
            return new MapConstructorDelegate<K, V>(Activator.CreateInstance<HashMap<K, V>>);
        }

    }
}
