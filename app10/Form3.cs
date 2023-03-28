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

        public static void AddToList(string[] s)=>
             _strings.Add(s.ToList());

        public Form3()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("about", "Вид сортировки");
            dataGridView1.Columns.Add("Quan", "Кол-во элементов");
            dataGridView1.Columns.Add("Info", "Информация");

            for (int i = 0; i < _strings.Count; ++i)
                dataGridView1.Rows.Add(_strings[i][0], _strings[i][1], _strings[i][2]);
        }
    }
}
