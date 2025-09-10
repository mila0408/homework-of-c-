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
    public partial class Form3 : Form
    {

        public event Action<BindingList<Users>> DeletUserF3_1 ;
        public BindingList<Users> us = new BindingList<Users>();
        public Form3( )
        {
            InitializeComponent();
        }

        public BindingList<Users> returnList( BindingList<Users> us)
        {
            return us;
        }
        public void DeletUserF3(object sender, EventArgs e)
        {

            if(deleteLogin.Text != string.Empty)
            {
                for (int i = 0; i < us.Count; i++)
                {
                    if (us[i].login == deleteLogin.Text)
                    {
                        us.RemoveAt(i);
                        break;
                    }

                }
            }
            DeletUserF3_1.Invoke(us);
            returnList( us );
            this.Close();
        }

    }
}
