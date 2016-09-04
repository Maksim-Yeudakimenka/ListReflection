using System;
using System.Collections.Generic;

namespace ListReflection
{
    public class ListFactory
    {
        public static List<T> CreateList<T>()
        {
            return Activator.CreateInstance<List<T>>();
        }
    }
}