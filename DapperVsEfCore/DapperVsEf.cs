using BenchmarkDotNet.Attributes;
using Dapper;
using DapperVsEfCore.Contexts;
using DapperVsEfCore.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperVsEfCore
{
    public class DapperVsEf
    {
        private SqlConnection DapperConnection { get => new SqlConnection("Server=.;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;"); }
        private NorthwindDbContext EfDbContext { get => new NorthwindDbContext(); }


        [Benchmark]
        public void EfCoreExample()
        {
            var result = EfDbContext.products.Select(p=>p).ToList();
            Console.WriteLine(result.Count);

        }
        [Benchmark]

        public void DapperExample()
        {
            var result = DapperConnection.Query<Product>("SelectAllProducts", commandType: CommandType.StoredProcedure).ToList();
            Console.WriteLine(result.Count);

        }


    }
}
