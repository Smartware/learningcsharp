using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Topics.TryException
{
    public class MyCustomEx: Exception
    {
        public MyCustomEx(string message): base(message)
        {

        }
    }
}
