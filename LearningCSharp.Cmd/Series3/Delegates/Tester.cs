using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningCSharp.Cmd.Series3.Delegates
{
    public class Tester
    {
        static ItemFilter filter1 = (name) => Console.WriteLine($"Searching for '{name}' inside delegate store.");


        public static void Main()
        {
            Form window = new Form();
            window.Text = "Delegate & Events";

            Button btn = new Button();
            btn.Text = "Click Me";
            btn.Location = new Point(window.Width/2, window.Height/2);
            btn.Click +=  ( sender,  args)=>
            {
                window.BackColor = Color.Azure;
            };

            btn.Click += Btn_Click;

            window.Controls.AddRange(new Control[1] { btn });
            window.ShowDialog();
            //AddGenericmethod();
            //AddMethod();

            //if (filter1 != null)
            //    filter1("ma");


            foreach(var item in ProductManager.Stocks)
            {
                filter1("ma");
            }

            Console.Read();
        }

        private static void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private static void AddGenericmethod()
        {
            ItemInsert<string> insert = new ItemInsert<string>(ProductManager.Add);
        }

        public static void AddMethod()
        {
            filter1 += ProductManager.FilterStock;
            filter1 += StaffManager.FilterStaff; // multicasting a delegate
            //filter1 -= new ItemFilter(StaffManager.FilterStaff);
            //filter1 = null;
        }
    }
}
