using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18
{
    public static class LinkedListExtensions
    {
        public static bool RemoveAt<T>(this LinkedList<T> list, int index)
        {
            #region Notes and other attempts...
            //if (index > list.Count - 1)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}

            //var count = 0;
            //for (var node = list.First; node != null; node = node.Next, count++)
            //{
            //    if (index.Equals(node.Value))
            //        return true;
            //}
            #endregion

            try
            {
                var count = 0;
                var node = list.First;
                while (count < index)
                {
                    node = node.Next;
                    count++;
                }
                list.Remove(node);
                //list.Remove(list.ElementAt<T>(index));
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void PrintReverse<T>(this LinkedList<T> list)
        {
            #region Crap stuff...
            //Console.Write("[ ");
            //foreach (var node in list)
            //{
            //    Console.Write(node.ToString() + ", ");
            //}
            #endregion

            do
            {
                if (!list.Count.Equals(0))
                {
                    Console.WriteLine(list.Last<T>().ToString());
                }
            } while (RemoveAt<T>(list, list.Count - 1) && list.Count > 0);
        }

        public static bool InsertAt<T>(this LinkedList<T> list, object o, int index)
        {
            try
            {
                var count = 0;
                var node = list.First;
                T ob = default(T);
                while (count < index)
                {
                    node = node.Next;
                    count++;
                }

                if (o is T)
                {
                    ob = (T)o;
                }
                if (count >= list.Count)
                {
                    node = list.Last;
                    list.AddAfter(node, ob);
                }
                else
                {
                    list.AddBefore(node, ob);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var testLL = new LinkedList<int>();
            int[] blahblah = { 1,2,3,2,2,4,5,5,7,8,4,4,1,0,10 };
            foreach (var item in blahblah)
            {
                testLL.AddLast(item);
            }

            #region ======== Part 1 ========
            Console.WriteLine("======== Part 1 ========");
            var removeTest = new LinkedList<int>(testLL);
            Console.Write("Remove at index: ");
            var userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int result))
            {
                Console.WriteLine(LinkedListExtensions.RemoveAt(removeTest, result));
            }
            else
            {
                Console.WriteLine("Try again later.");
            }

            var reverseTest = new LinkedList<int>(testLL);
            LinkedListExtensions.PrintReverse(reverseTest);

            var insertTest = new LinkedList<int>(testLL);
            Console.Write("Insert integer: ");
            var userInt = Console.ReadLine();
            if (int.TryParse(userInt, out int resultingInt))
            {
                Console.Write("At index: ");
                var userInd = Console.ReadLine();
                if (int.TryParse(userInd, out int resultingInd))
                {
                    Console.WriteLine(LinkedListExtensions.InsertAt(insertTest, resultingInt, resultingInd));
                }
            }
            else
            {
                Console.WriteLine("Try again later.");
            }
            #endregion

            #region ======== Part 2 ========
            Console.WriteLine("======== Part 2 ========");

            #endregion

            Console.ReadKey();

            //LinkedListExtensions.PrintReverse<int>(blahblah.ToList<int>);
        }
    }
}
