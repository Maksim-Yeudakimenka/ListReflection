using System.Collections.Generic;

namespace ListReflection
{
    public static class ListExtensions
    {
        public static void AppendItem<T>(this List<T> list, T item)
        {
            var listType = list.GetType();

            var addMethod = listType.GetMethod("Add", new[] { typeof(T) });
            addMethod.Invoke(list, new object[] { item });
        }
    }
}