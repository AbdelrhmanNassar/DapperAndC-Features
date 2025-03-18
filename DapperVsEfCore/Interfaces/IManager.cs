using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperVsEfCore.Interfaces
{
    internal interface IManager<T>
    {
        List<T> GettAll();
        T? GetById(int id);
        bool Add(T item);
        bool Upadate(T item);
        bool Delete(int id);

    }
}
