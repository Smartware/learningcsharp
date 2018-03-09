using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp.Topics.EF.Sample
{
    public class ProductManager
    {
        public static List<Item> GetProductList(string filter = null)
        {
            var sqlConString = "Server=.\\SQLExpress;Integrated Security=false; user id=sa; password=micr0s0ft_;Initial Catalog=Iposv3";
            var sqlCon = new SqlConnection(sqlConString);
            var cmdText = $"SELECT TOP 10 * FROM Product p where p.Name like '%{filter}%'";
            var sqlCmd = new SqlCommand(cmdText, sqlCon);

            List<Item> itemList = new List<Item>();

            try
            {
                sqlCon.Open();
                SqlDataReader reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    var prod = new Item()
                    {
                        Name = reader.GetString(2),
                        Id = reader.GetGuid(1),
                        Price = reader.GetDecimal(4),
                    };

                    itemList.Add(prod);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                sqlCon.Close();
            }

            return itemList;
        }
    }

    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
