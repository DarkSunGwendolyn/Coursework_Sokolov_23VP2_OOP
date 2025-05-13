using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    interface IRepository<T>
    {
        void Add(T entity);

        void Delete(T entity);

        BindingList<T> Filter(decimal lowerBound, decimal higherBound, string param);

        BindingList<T> Filter(string compare, string param);

        BindingList<T> SortIncrease(string param);

        BindingList<T> SortDecrease(string param);

        void Update(T entity);

        T SearchByName(string name);
    }
}
