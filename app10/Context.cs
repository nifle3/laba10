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
    enum TypeOfSort
    {
        Bubble,Radix
    }
    internal class Context
    {
        private static int[]? _array;
        public static Form1? form1;

        private ISortable? _sort;
        private TypeOfSort _type;

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

                InFile.Clear();
                InFile.AddString("Не отсортированный массив\n" + s);

            }
        }

        public Context(TypeOfSort type, ISortable? sort = null) => (_sort,_type) = (sort, type);

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
                InFile.AddString(outputString);
            }

            watch.Stop();
            var resultTime = watch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}", resultTime.Hours, resultTime.Minutes, resultTime.Seconds, resultTime.Nanoseconds);

            if (form1 is null)
                return;

            form1.Ifi.Text = _sort.IfiCount.ToString();
            form1.Iter.Text = _sort.IterationCount.ToString();
            form1.Time.Text = elapsedTime;

            string type = _type is TypeOfSort.Radix ? "Поразрядовый" : "Пузырьком";
            string info = $"Иф:{_sort.IfiCount}, И:{_sort.IterationCount}, Т:{elapsedTime}";
            string[] toGrid = {type, $"Количество: {array.Length}", info };
            Form3.AddToList(toGrid);
        }
    }
}
