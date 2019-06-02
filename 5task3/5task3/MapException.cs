using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5task3
{
    class MapException : Exception
    {
        public MapException(string message) : base("Ошибка: " + message)
        { }
    }
}
