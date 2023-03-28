using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace app10
{
    public partial class Form3 : Form
    {
        private static List<List<string>> _strings= new List<List<string>>();

        public void AddToList(string[] s)=>
             _strings.Add(s.ToList());

        public Form3()
        {
            InitializeComponent();

        }
    }
}
