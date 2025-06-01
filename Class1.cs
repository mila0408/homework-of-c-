using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;
using System.Collections.Generic;
using System.IO;

namespace classwork
{
    public class Class1
    {
        public void lalal() {
            string path = "C:\\Users\\Взрослая академия\\Desktop\\name.csv";
            using (StreamReader file = new StreamReader(path))

            {
                string a = file.ReadLine();
                while (a != null)
                {

                    Console.WriteLine(a);
                    a = file.ReadLine();
                }



            }

        }
    }
}
