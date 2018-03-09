using LearningCSharp.Topics.EF.Sample;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Cmd.Series5
{
    public class Tester
    {
        public static void Main()
        {

            var itemList = ProductManager.GetProductList("water");

            foreach (var item in itemList)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price}");
            }

            Console.Read();
            var personObj = new Person()
            {
                LastName = "Aremu",
                FirstName = "Lollipop",
                Addresses = new List<Address>()
                {
                    new Address()
                    {
                        City = "VI",
                        Street = null
                    },
                    new Address()
                    {
                        City = "Awoyaya",
                        Street = "Convenant Drive"
                    }

                }
            };

            var serializedJson = JsonConvert.SerializeObject(personObj);

            Console.WriteLine(serializedJson);

            Console.Read();

            var person = @"{
                        'LastName': 'Prolifik', 
                        'FirstName': 'Lexzy',
                        'Addresses': [
                            {'City': 'VI', 'Street': ''}, 
                            {'City': 'Awoyaya', 'Street': 'Convenant Drive'}]
                        }";

            var objPerson = JsonConvert.DeserializeObject<Person>(person);

            Console.WriteLine($"LastName: {objPerson?.LastName} FirstName: {objPerson?.FirstName}");

            foreach (var item in objPerson.Addresses)
            {
                Console.WriteLine($"City: {item.City} Street: {item.Street ?? "NA"}");
            }

            Console.Read();
        }
    }

    public class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public List<Address> Addresses { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
    }
}
