using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace app10
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
            Context.form1 = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        public void AddToHistory(string operation)=>
            History.Items.Add(operation);

        public void ClearHistory() => 
            History.Items.Clear();

        private void button2_Click(object sender, EventArgs e)
        {
            Context? executable = null;
            if (!(Radix.Checked || Bubble.Checked))
            {
                label1.Text = "Âûáåðèòå ñîðòèðîâêó";
                return;
            }

            if (Context.array is null)
            {
                label1.Text = "Ñîçäàéòå ìàññèâ";
                return;
            }

            label1.Text = String.Empty;

            if (Radix.Checked)
                executable = new Context(TypeOfSort.Radix, new RadixSort());

            else if (Bubble.Checked)
                executable = new Context(TypeOfSort.Bubble, new BubbleSort());

            if (executable == null)
                return;

            executable.ExecutableAlgorithm();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            InFile inFile = new();

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            inFile.path = saveFileDialog1.FileName;
            inFile.Into();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            OutFile outFile = new();
            outFile.Path = saveFileDialog1.FileName;
            outFile.Out();
        }
    }
}
