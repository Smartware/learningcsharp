using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series2.GetSet
{
    public class Product
    {
        //private string _name;
        //public string Name
        //{
        //    get
        //    {
        //        return _name;
        //    }
        //    set
        //    {
        //        _name = value;
        //    }
        //}

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name { get; private set; } = "Default"; // Property Initializer

        public void SetName(string name)
        {
            this.Name = name.Trim();
        }

        public string ProductInfo() => this.Name; // Expression Body
        //{
        //    return this.Name;
        //}
    }
}
