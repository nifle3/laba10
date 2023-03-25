using System;
using System.Collections.Generic;
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
        public int[] Sort(int[] array)
        {
            return array;
        }
    }

    internal class BitwiseSort : ISortable
    {
        public int[] Sort(int[] array)
        {
            return array;
        }
    }
}
