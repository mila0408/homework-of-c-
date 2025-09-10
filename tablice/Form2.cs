using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tablice
{
    public partial class Form2 : Form
    {
        public event Action<Users> addNewUser;
        public Form2()
        {
            InitializeComponent();
        }

        public void addUsers(object sender, EventArgs e)
        {
            if(ageText.Text != string.Empty && nameText.Text != string.Empty && loginText.Text != string.Empty && passwordText.Text != string.Empty) {
                Users addU = new Users();
                addU.age  = Convert.ToInt32(ageText.Text);
                addU.name = nameText.Text;
                addU.login = loginText.Text;
                addU.password = passwordText.Text; 
                addNewUser.Invoke(addU);
                this.Close();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
