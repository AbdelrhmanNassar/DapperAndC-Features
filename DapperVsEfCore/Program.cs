using BenchmarkDotNet.Running;
using DapperVsEfCore.Contexts;
using DapperVsEfCore.Managers;

namespace DapperVsEfCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ProductManager manager = new ProductManager();

            //Console.WriteLine(manager.GetById(2)?.ProductName);            



            //NorthwindDbContext context = new NorthwindDbContext();
            //var result =context.products.Select(p => p);
            //foreach (var product in result) {

            //Console.WriteLine(product.ProductName);
            //}


            var Summary = BenchmarkRunner.Run<DapperVsEf>();

        }
    }
}
