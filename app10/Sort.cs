using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Text;
using System.Threading.Tasks;

namespace app10
{
    interface ISortable
    {
        public int[] Sort(int[] array);
    }

    internal class BubbleSort : ISortable
    {
        private int _iterationCount;
        public static Form1 _form1;


        public int[] Sort(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
                if (array[i] < array[i - 1])
                    (array[i], array[i - 1]) = (array[i - 1], array[i]);

            return array;
        }
    }

    internal class RadixSort : ISortable
    {
        public int[] Sort(int[] array)
        {
            int max = array.Max().ToString().Length;
            List<List<int>> lists = new List<List<int>>(10);

            for (int i = 0; i < 10; i++)
            {
                lists.Add(new List<int>());
            }

            for (int step = 0; step < max; step++)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    int temp = (array[i] % (int)Math.Pow(10, step + 1)) / (int)Math.Pow(10, step);
                    lists[temp].Add(array[i]);
                }
                array = ListToArray(lists);
                for (int i = 0; i < 10; i++)
                    lists[i].Clear();
            }

            return array;
        }

        private int[] ListToArray(List<List<int>> arr)
        {
            List<int> ints = new List<int>();

            for (int i = 0; i < arr.Count; i++)
                for (int j = 0; j < arr[i].Count; j++)
                    ints.Add(arr[i][j]);

            return ints.ToArray();
        }
    }
}
