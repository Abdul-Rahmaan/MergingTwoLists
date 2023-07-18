using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergedTwoList
{
    internal class Program
    {
        public static void Main()
        {
            int[] list1 = { 56, 70, 77 };
            int[] list2 = { 80, 99, 180 };
            //int[] list3 = { };
            var list = new List<int>();

            for (int i = 0; i < list1.Length; i++)
            {
                list.Add(list1[i]);
                list.Add(list2[i]);
            }
            int[] array3 = list.ToArray();

            foreach (int res in array3)
            {
                Console.Write(res +" ");
            }
        }
    }
}
