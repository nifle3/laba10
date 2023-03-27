using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace app10
{
    public partial class Form2 : Form
    {
        private Form1 _form1;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            KUI();
        }

        private bool KUI()
        {
            if (!int.TryParse(textBox2.Text, out int a))
                return false;

            _form1.ClearHistory();

            if (int.TryParse(textBox1.Text, out int b))
                Context.array = Randomizer.GetRandomNumber(a, b);

            else
                Context.array = Randomizer.GetRandomNumber(a);

            string answer = "";

            for (int i = 0; i < Context.array.Length; i++)
                answer += Context.array[i].ToString() + " , ";

            _form1.AddToHistory(answer);
            _form1.inFile.AddActive("Базовый массив \n" + answer);

            return true;
        }
    }
}
