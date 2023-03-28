using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app10
{
    internal class Context
    {
        private static int[]? _array;
        public static Form1? form1;

        private ISortable? _sort;

        public static int[]? array
        {
            get => _array; 
            set
            {
                _array = value;

                if (form1 is null || _array is null)
                    return;

                form1.ClearHistory();
                string s = "";
                for (int i = 0;i < _array.Length; i++)
                    s += _array[i].ToString() + " , ";

                form1.AddToHistory(s);

            }
        }

        public Context(ISortable? sort = null) => _sort = sort;

        public void ExecutableAlgorithm() 
        {
            if (array == null || _sort == null || form1 == null)
                return;

            _sort.Array = array;

            Stopwatch watch = new();
            watch.Start();
            foreach (string outputString in _sort)
            {
                form1.AddToHistory(outputString);
            }

            watch.Stop();
            var resultTime = watch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}", resultTime.Hours, resultTime.Minutes, resultTime.Seconds, resultTime.Nanoseconds);

            if (form1 is null)
                return;

            form1.Ifi.Text = _sort.IfiCount.ToString();
            form1.Iter.Text = _sort.IterationCount.ToString();
            form1.Time.Text = elapsedTime;
        }
    }
}
