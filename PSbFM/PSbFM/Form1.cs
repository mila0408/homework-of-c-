namespace PSbFM
{
    public partial class Form1 : Form
    {
        public string puth = "DataBaseOfTransaction.csv";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void AddTransaction(object sender, EventArgs e)
        {
            Form2 form23 = new Form2();
            form23.Show();

        }
    }
}
