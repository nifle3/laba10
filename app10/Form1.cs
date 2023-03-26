namespace app10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}