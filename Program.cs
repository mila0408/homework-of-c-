using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLib
{
    class PC {
        public string stemp;
        public int SerialNumber;
        public string processor;
        public bool included = false;
        public PC() { }
        public PC(string stemp, int SerialNumber, string processor,bool included)
        {
            this.stemp = stemp;
            this.SerialNumber = SerialNumber;
            this.processor = processor;
            this.included = included;
        }
        public void setrStemp(string newStemp)
        {
            this.stemp = newStemp;
        }
        public void setrSerialNumber(int newSerialNumber)
        {
            this.SerialNumber = newSerialNumber;
        }
        public void setrProcessor(string newProcessor)
        {
            this.processor = newProcessor;
        }
        public void setrincluded(bool newIncluded)
        {
            this.included = newIncluded;
        }
        public string getrStemp()
        {
            return this.stemp;
        }
        public int getrSerialNumber()
        {
            return this.SerialNumber;
        } 
        public string getrProcessor()
        {
            return this.processor;
        }
        public bool getrIncluded()
        {
            return this.included;
        }

        public void turnOn()
        {
            included = true;
        }
        public void turnOff()
        {
            included = false;
        }
    }

}

namespace classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            classwork.Class1 v = new classwork.Class1();
            v.lalal();
                //string path = "C:\\Users\\Взрослая академия\\Desktop\\name.csv";
                //ClassLib.PC a = new ClassLib.PC("uedvfcel", 29836, "yhwgclf", false);  
                //ClassLib.PC b = new ClassLib.PC("ljfbh", 8023, "iredg", true);
                //ClassLib.PC c = new ClassLib.PC("lsjdb", 9863, "idhjvg'o", false);
                //ClassLib.PC d = new ClassLib.PC(".kjsdcgbvs", 28758, "olikhgolvkn", false);
                //ClassLib.PC e = new ClassLib.PC(";ajbg", 3796, "lsdebgjjbvgf", true);
                //List<ClassLib.PC> a1 = new List<ClassLib.PC>();
                //a1.Add(a);
                //a1.Add(b);
                //a1.Add(c);
                //a1.Add(d);
                //a1.Add(e);
                //using (StreamWriter file = new StreamWriter(path,append:true))
                //{
                //    for (int i = 0; i < 5; i++)
                //    {
                //        file.WriteLine(a1[i].getrProcessor());
                //        file.WriteLine(a1[i].getrIncluded());
                //        file.WriteLine(a1[i].getrSerialNumber());
                //        file.WriteLine(a1[i].getrStemp());
                //        file.WriteLine();
        }
            }

        }
    

