using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentInformation.Repositories
{
    public interface IGenericRepository<T>where T:class
    {
        List<T> GetAll();
        T GetById(int Id);
        int Insert(T t);
        int Update(T t);
        int Delete(int Id);
        List<T> Search(string param);

    }
}