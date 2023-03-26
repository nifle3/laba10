using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app10
{
    internal class Context
    {
        private ISortable? _sort;
        public static int[]? array;

        public Context(ISortable sort) => _sort = sort;
        
        public Context() { }

        public void ExecutableAlgorithm() 
        { 
            if (array != null && _sort != null) 
                _sort.Sort(array);
        }
    }
}
