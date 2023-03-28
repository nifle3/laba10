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
        private List<string> output = new List<string>();
        public string? path;

        public void AddActive (string active)=>
            output.Add(active);
 
        public void Reset()=>
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
