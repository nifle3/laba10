using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace app10
{
    interface ISortable 
    {
        public int IterationCount { set; get; }
        public int IfiCount { set; get; }
        public int[]? Array { set; get; }
        public IEnumerator<string> GetEnumerator();
    }

    internal class BubbleSort : ISortable
    {
        public int IterationCount { set; get; }
        public int IfiCount { set; get; }
        public int[]? Array { set; get; }

        public IEnumerator<string> GetEnumerator()
        {
            if (Array is null)
                yield break ;

            for (int i = Array.Length; i > 0; i--)
            {
                for (int k = 0; k < i - 1; k++)
                {
                    char ch1, ch2;
                    if (Array[k] > Array[k + 1])
                    {
                        IfiCount++;
                        (Array[k], Array[k + 1]) = (Array[k + 1], Array[k]);
                        (ch1, ch2) = ('}', '{');
                    }

                    else
                        (ch1, ch2) = (')', '(');

                    IterationCount++;

                    yield return Print(ch1, ch2, k, k + 1, Array);
                    InFile.AddString($"Сравниваем{Array[k]} и {Array[k + 1]}, кол-во итераций {IterationCount}, кол-во ифоф {IfiCount}");
                }

                IterationCount++;
            }
        }

        private string Print(char chs, char che, int first, int second, int[] array)
        {
            string output = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (i == first)
                    output += che + array[i].ToString() + ", ";

                else if (i == second)
                    output += array[i].ToString() + chs + ", " ;

                else
                    output += array[i].ToString() + ", ";
            }

            return output;
        }
    }

    internal class RadixSort : ISortable
    {
        public int IterationCount { set; get; }
        public int IfiCount { set; get; }
        public int[]? Array { set; get; }

        public IEnumerator<string> GetEnumerator()
        {
            if (Array is null)
                yield break;

            int max = Array.Max().ToString().Length;
            List<List<int>> lists = new List<List<int>>(10);

            for (int i = 0; i < 10; i++)
            {
                lists.Add(new List<int>());
            }

            for (int step = 0; step < max; step++)
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    int temp = (Array[i] % (int)Math.Pow(10, step + 1)) / (int)Math.Pow(10, step);
                    lists[temp].Add(Array[i]);
                    IterationCount++;
                }
                Array = ListToArray(lists);

                for (int i = 0; i < 10; i++)
                {
                    lists[i].Clear();
                    IterationCount++;
                }

                IterationCount++;
                yield return Print(Array, max - step - 1);
                InFile.AddString($"Сортируется по {max - step}, кол-во итераций {IterationCount}, кол-во ифоф {IfiCount}");
            }
        }

        private string Print(int[] array, int step)
        {
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

            return output;
        }

        private int[] ListToArray(List<List<int>> arr)
        {
            List<int> ints = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    ints.Add(arr[i][j]);
                    IterationCount++;
                }
            }

            return ints.ToArray();
        }
    }
}
