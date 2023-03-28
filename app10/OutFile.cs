using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace app10
{
    internal class OutFile
    {
        public string? Path { set; get; }

        public void Out()
        {
            if (Path is null)
                return;

            List<int> output = new List<int>();

            using(StreamReader sr = new StreamReader(Path, System.Text.Encoding.Default)) 
            {
                string[] time;
                string input = sr.ReadToEnd();
                time = input.Split(new char[] { ','});
                
                for (int i =0; i < time.Length; i++)
                {
                    output.Add(int.Parse(time[i]));
                }
            }

            Context.array = output.ToArray();
        }
    }
}
