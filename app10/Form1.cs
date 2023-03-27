namespace app10
{
    public partial class Form1 : Form
    {
        internal InFile inFile = new InFile();
        
        public Form1()
        {
            InitializeComponent();
            BubbleSort.form1 = this;
            RadixSort.form1 = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new(this);
            form2.Show();
        }

        public void AddToHistory(string operation)
        {
            History.Items.Add(operation);
        }

        public void ClearHistory() => 
            History.Items.Clear();

        private void button2_Click(object sender, EventArgs e)
        {
            Context? com = KUI2();

            if (com != null)
            {
                com.ExecutableAlgorithm();
                inFile.Reset();
            }
        }

        private Context? KUI2()
        {
            if (!(Radix.Checked || Bubble.Checked))
            {
                label1.Text = "Выберите сортировку";
                return null;
            }

            if (History.Items.Count == 0)
            {
                label1.Text = "Создайте массив";
                return null;
            }

            label1.Text = String.Empty;

            if (Radix.Checked)
                return new Context(new RadixSort());

            else if (Bubble.Checked)
                return new Context(new BubbleSort());

            return null;
        }



        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);

            inFile.path = saveFileDialog1.FileName;

            inFile.Into();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            saveFileDialog1.ShowDialog(this);

            inFile.path = saveFileDialog1.FileName;

            inFile.Into();
        }
    }
}