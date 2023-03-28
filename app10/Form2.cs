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
        public Form2(Form1 form1)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox2.Text, out int a))
                return;

            if (int.TryParse(textBox1.Text, out int b))
                Context.array = Randomizer.GetRandomNumber(a, b);

            else
                Context.array = Randomizer.GetRandomNumber(a);
        }
    }
}
