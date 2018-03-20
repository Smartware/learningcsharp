using LearningCSharp.Topics.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series5
{
    public class Tester3
    {
        public static void Main()
        {
            using (var context = new UniversityDbContext())
            {

                var studentList = context.Set<Student>().ToList();
                var courseList = context.Set<Course>().ToList();

                var d = new Department();
                var departmentList = context.Set(d.GetType());
            }

            Console.Read();
        }
    }

    public class DiskPlayer: IDisposable
    {
        private string status;

        public void Dispose()
        {
            status = "Off";
            Console.WriteLine(status);
        }

        public void Play()
        {
            this.status = "Playing";
            Console.WriteLine(status);
        }

    }

    public interface IExplorable<in T>
    {
        void Add(T item);
    }

    public interface IDiscoverable<out T>
    {
        T get(int index);
    }

    public class DiscoverAndExplore<T> : IExplorable<T>, IDiscoverable<T>
    {
        private List<T> _list;

        public DiscoverAndExplore(List<T> list)
        {
            _list = list;
        }
        public void Add(T item) => _list.Add(item);

        public T get(int index) => _list.ElementAt(index);

    }
}
