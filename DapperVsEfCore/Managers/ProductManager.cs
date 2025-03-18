using Dapper;
using DapperVsEfCore.Interfaces;
using DapperVsEfCore.Models;
using Microsoft.Data.SqlClient;
using System.Data;


namespace DapperVsEfCore.Managers
{
    internal class ProductManager : IManager<Product>
    {
        private SqlConnection connection;

        public ProductManager()
        {
            connection = new SqlConnection("Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public bool Add(Product item)
        {
            try
            {
                return connection.Execute("Insert into Products (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice,"
                      + " UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)"
                      + "VALUES (@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued)"
                      , item) > 0;
            }
            catch (Exception e)
            {

                throw new Exception($"{e.Message}");
            }
        }

        public bool Delete(int id)
        {
            //Will use Sp For Deleting a product

           return connection.Execute("DeleteProductByID", new {ProductID = id},commandType:CommandType.StoredProcedure) > 0;
        }

        public Product? GetById(int id)
        {
           return connection.QueryFirstOrDefault<Product>("select * from Products where ProductID=@Id" ,new {Id=id});
        }

        public List<Product> GettAll()
        {
         return connection.Query<Product>("select * from Products").ToList();
                
        }

        public bool Upadate(Product item)
        {
            //We Will Use A Sp
            return connection.Execute("PrdsUpdateCommand",new
            {
                ProductID = item.ProductID,
                ProductName = item.ProductName,
                SupplierID = item.SupplierID,
                CategoryID = item.CategoryID,
                QuantityPerUnit = item.QuantityPerUnit,
                UnitPrice = item.UnitPrice,
                UnitsInStock = item.UnitsInStock,
                UnitsOnOrder = item.UnitsOnOrder,
                ReorderLevel = item.ReorderLevel,
                Discontinued = item.Discontinued
            },commandType: CommandType.StoredProcedure) > 0;
        }
    }
}
