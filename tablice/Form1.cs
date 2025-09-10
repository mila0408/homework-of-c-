using System.ComponentModel;

namespace tablice
{
    public partial class Form1 : Form
    {
        public BindingList<Users> UserList = new BindingList<Users>();
        public
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = UserList;
        }

        private void add_User(object sender, EventArgs e)
        {
            Form2 form23 = new Form2();
            form23.addNewUser += Form2_addUsers;
            form23.Show();


        }
        public void Form2_addUsers(Users obj)
        {
            UserList.Add(obj);

        }
        private void delete_User(object sender, EventArgs e)
        {
            Form3 form34 = new Form3();
            form34.us = UserList;
            form34.DeletUserF3_1 += Form3_deleteUsers;
            form34.Show();


        }
        public void Form3_deleteUsers(BindingList<Users> obj)
        {
            UserList = obj;
        }

        private void o(object sender, EventArgs e)
        {

        }

        private void importBD(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;
               string fileText =  File.ReadAllText(path);
                


            }
        }
    }
}
