using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2
{
    public class Staff
    {
        public Staff()
        {
        }
    }
    public class Item
    {
        public Item()
        {
            Console.WriteLine("Item is constructed....");
            
            Price++;
        }

        public string name = "";
        public int Price = 0;

       
    }
    //public abstract class Storable
    //{
    //    public abstract void Write();
    //    public abstract void Read();

    //}

    //public class CloudStorage : Storable
    //{
       
    //    public override void Write()
    //    {
    //        Console.WriteLine("Cloud Storage saving to cloud.");
    //    }

    //    public override void Read()
    //    {
    //        Console.WriteLine("Cloud Storage reading from cloud.");
    //    }
    //}


}
