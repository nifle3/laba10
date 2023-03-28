using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace app10
{
    internal class InFile
    {
        private static List<string> output = new List<string>();
        public string? path;

        public static void AddString(string add)=>
            output.Add(add);

        public static void Clear()=> 
            output.Clear();

        public void Into()
        {
            if (path is null)
                return;

            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                foreach (string i in output)
                {
                    sw.WriteLine(i);
                }
            }
            output.Clear();
        }
    }
}
