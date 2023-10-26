using LibraryProject.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataLayer.Repositories.Abstracts
{
    internal interface IRepository<T> where T : BaseEntity,new()
    {
        T GetById(int id);
        void Add(T entity);
        void AddRange(ICollection<T> entity);
        void Update(T entity);
        void Remove(int id);
        ICollection<T> GetAll();
        void SaveChanges();
    }
}
