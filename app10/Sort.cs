using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Runtime.CompilerServices;
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
        public static Form1? form1;


        public int[] Sort(int[] array)
        {
            for (int i = array.Length; i > 0; i--)
            {
                for (int k = 0; k < i - 1; k++)
                {
                    if (array[k] < array[k - 1])
                    {
                        (array[k], array[k - 1]) = (array[k - 1], array[k]);
                        Print('}', '{', k, k - 1, array);
                    }

                    else
                        Print(')', '(', k, k - 1, array);
                }
            }

            return array;
        }

        private bool Print(char chs, char che, int first, int second, int[] array)
        {
            if (form1 is null)
                return false;

            string output = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (i == first)
                    output += array[i].ToString() + ", " + chs;

                else if (i == second)
                    output += che + array[i].ToString() + ", " ;

                else
                    output += array[i].ToString() + ", ";
            }

            form1.AddToHistory(output);
            return true;
        }
    }

    internal class RadixSort : ISortable
    {
        private int _iterationCount;
        public static Form1? form1;

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
                Print(array, max - step - 1);

                for (int i = 0; i < 10; i++)
                    lists[i].Clear();
            }

            return array;
        }

        private bool Print(int[] array, int step)
        {
            if (form1 is null)
                return false;

            string output = "";

            for (int i = 0; i < array.Length; i++)
            {
                string a = array[i].ToString();

                if (a.Length >= step)
                {
                    a = a.Insert(step, "(");
                    a = a.Insert(step + 2, ")");
                }

                output += a + ", ";
            }

            form1.AddToHistory(output);

            return true;
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
