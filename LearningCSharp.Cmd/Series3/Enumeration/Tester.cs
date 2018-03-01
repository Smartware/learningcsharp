using LearningCSharp.Topics.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series3.Enumeration
{
    public class Tester
    {
        public static void Main()
        {
            //var numberList = new int[6]
            //{
            //    1,2, 6, 58, 3, 300
            //};
            //AddSet(1, 2, 6, 58, 3, 300);
            loop:
            var inputs = Console.ReadLine();

            var numbers = inputs.Split(',', ' ' ,'\0');

            var nums = new int[numbers.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                var s = numbers[i];

                int r = 0;
                if (int.TryParse(s, out r))
                {
                    nums[i] = r;
                }
            }

            var answer = Add(nums);
            Console.WriteLine(answer);

            goto loop;

            Console.Read();
        }

        static List<int> Numbers { get; set; } = new List<int>();
        public static void AddSet(params int[] numbers)
        {
            Numbers.AddRange(numbers);
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Add(params int [] numbers)
        {
            int result = 0;

            foreach (var num in numbers)
            {
                result = result + num;
            }

            return result;
        }
    }
}
