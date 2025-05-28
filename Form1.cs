using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string pathExpenses= "C:\\Users\\Взрослая академия\\Desktop\\Day17.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (StreamReader file = new StreamReader(pathExpenses))
            {
                label1.Text = "";
                string line = "0";
                while (line != null)
                {
                    line = file.ReadLine();
                    label1.Text += line+"\n";

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            using(StreamWriter file = new StreamWriter(pathExpenses,append:true)) {
                string line;
                line = textBox1.Text;
                file.WriteLine(line);
                textBox1.Clear();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        { 
            label2.Text = "Write down the Category (food, transport,extertainment) first, then amount, and then date \n example: food;785;14.04.25";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
