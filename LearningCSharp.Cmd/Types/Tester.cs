using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningCSharp.Cmd.Types
{
    public class Tester
    {
        public static void Main()
        {
            Int16 w = 23;
            short z = w;

            Int32 x = 23;
            int y = w;

            Int64 a = 89;
            long b = a;

            //Console.WriteLine("{0}{1}{2}", x, e, y);
            // Console.WriteLine("{0}", x);
            // Console.WriteLine("{0}",y);

            char gender = '\n';

            Char e = gender;

            String nickname = "Prolifik \bLexzy ";
            Console.WriteLine(nickname);

            char c = '\u20A6';

            Console.WriteLine(c);

            Form f = new Form();
            Button btn = new Button();
            btn.Text = "\u063F";
            f.Controls.Add(btn);
         
            f.ShowDialog();


     
            //Console.WriteLine($"{x}\t+\t{y}\t=\t{x+y}");
            Console.Read();
        }
    }
}
