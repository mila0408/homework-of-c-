using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1

{
    public partial class Form1 : Form
    {
        public string pathBaseDate = "C:\\Users\\Взрослая академия\\Desktop\\BaseDate.csv";

        public Form1()
        {

            InitializeComponent();
        }

        private void enter(object sender, EventArgs e)
        {
            
            if (loginText.Text != string.Empty && paswordText.Text != string.Empty)
            {
                string[] data = File.ReadAllLines(pathBaseDate);
                for (int i = 0; i < data.Length; i++)
                {
                   string line = data[i].Split(';')[0];
                    if (data[i] == (loginText.Text+";"+paswordText.Text))
                    {
                        Form2 form23 = new Form2();
                        form23.Show();
                        this.Hide();
                    }
                    else
                    {
                        label3.Text = "incorrect login or password. Try again.";
                    }

                }

            }
        }
        private void register(object sender, EventArgs e)
        {
            if (loginText.Text != string.Empty && paswordText.Text != string.Empty)
            {
                for (int i = 0; i < data.Length; i++) { 
                //if () 
                //{
                //    File.AppendAllText(pathBaseDate, loginText.Text + ";" + paswordText.Text+"\n;");
                //}
                //}


            }
        }

        private void lodin(object sender, EventArgs e)
        {


        }

        private void pasword(object sender, EventArgs e)
        {

        }
        
    }
}
