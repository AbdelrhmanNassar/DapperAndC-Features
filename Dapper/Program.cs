using DapperExplaintion;
using DapperExplaintion.Managers;
using DapperExplaintion.Models;
using Microsoft.Data.SqlClient;


namespace Dapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Windows Authentication"  "For making sql server turst vs certificate of encryption"
       //   using SqlConnection connection = new SqlConnection("Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;");
            #region Query Methodd
            //var Result = connection.Query("Select * from Orders");
            //var Result = connection.Query<Order>("Select * from Orders");

            //var Result = connection.Query<Employee>("SelectALLEmployees", CommandType.StoredProcedure);

            //foreach (var item in Result) {
            //Console.WriteLine($"{item.FirstName} {item.LastName}" );

            //} 
            #endregion

            #region Execute
            //var affectedRows = connection.Execute("update Products set ProductName=@ProductName where ProductID=@id", new
            //{
            //    ProductName = "جوافه",
            //    id = 1

            //});
            //if (affectedRows > 0)
            //    Console.WriteLine("Done");
            //else
            //{
            //    Console.WriteLine("Falid");
            // }

            //Using Sp

            //var affectedRows = connection.Execute("UpdateProductNameByProductID",
            //    new { ProductID=1,ProductName="فله" }, commandType: CommandType.StoredProcedure);

            //if (affectedRows > 0)
            //    Console.WriteLine("Done");
            //else
            //{
            //    Console.WriteLine("Falid");
            //}
            #endregion

            #region Crud
            Product product = new Product()
            {

                ProductName = "IceMocha",
                SupplierID = 1,
                CategoryID = 1,
                QuantityPerUnit = "20 g",
                UnitPrice = 10,
                UnitsInStock = 15,
                UnitsOnOrder = 10,
                ReorderLevel = 20,
                Discontinued = false // Assuming this is part of the initialization

            };
            ProductManager manager = new ProductManager();
            #region Add

            //  Console.WriteLine(manager.Add(product));
            #endregion
            #region Update
            //فكنا منها
            //var p= manager.GetById(2);
            //if (p is not null)
            //{
            //    p.ProductName = "Matcha";
            //    Console.WriteLine(manager.Upadate(p));

            //}

            #endregion
            #region GetAll
            // Console.WriteLine(manager.GettAll().Count);
            #endregion
            #region GetById
              Console.WriteLine(manager.GetById(2)is null ? "NA" : manager.GetById(2).ReorderLevel);
            #endregion
            #region delete
           // Console.WriteLine(manager.Delete(91));
            #endregion
            #endregion
        }
    }
}
