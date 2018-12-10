using System.Collections.Generic;

namespace Lab18
{
    public static class LinkedListExtensions
    {
        public static bool RemoveAt<T>(this LinkedList<T> list, int index)
        {
            if (index > list.Count - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void PrintReverse<T>(this LinkedList<T> list)
        {
            LinkedList<T> temp = new LinkedList<T>();
            for (int i = 0; i < list.Count; i++)
            {
                temp.AddLast(list.Last);
                list.RemoveLast();
            }
        }

        public static bool InsertAt<T>(this LinkedList<T> list, int index)
        {
            return true;
        }
    }
}
