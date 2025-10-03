using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSbFM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void SaveTransactionInFile(string puth)
        {

        }
        private void addExpenseClick(object sender, EventArgs e)
        {
            DateTime date = dateTimeExpense.Value;
            int summa = int.Parse(SummaExpense.Text);
            Category category;


            Transaction transaction;

        }

        private void AddIncomeClick(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}
