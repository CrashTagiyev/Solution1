using LibraryProject.DataLayer.Contexts;
using LibraryProject.DataLayer.Repositories.Abstracts;
using LibraryProject.Models.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.DataLayer.Repositories.Concretes
{
    public class LibraryRepository<T> :
        IRepository<T> where T : BaseEntity, new()
    {
        private readonly LibraryDBContext _Context;
        private readonly DbSet<T> _DbSet;

        public LibraryRepository()
        {
            _Context = new LibraryDBContext();
            _DbSet = _Context.Set<T>();
        }

        public void Add(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Data is null");
            _DbSet.Add(entity);
            SaveChanges();
        }

        public void AddRange(ICollection<T> entity)
        {
            if (entity == null || entity.Count == 0) throw new ArgumentNullException("Data is null");
            _DbSet.AddRange(entity);
        }

        public ICollection<T> GetAll() => _DbSet.ToList();
        public T GetById(int id) => _DbSet.FirstOrDefault(x => x.Id == id);
        public void Remove(int id)
        {
            if (GetById(id) == null) throw new Exception("Entity did not found");
            _DbSet.Remove(GetById(id));
            SaveChanges();
        }
        public void Remove(T Entity)
        {
            var ent = _DbSet.FirstOrDefault(e => e.Id == Entity.Id);
            if (ent == null) throw new Exception("Entity did not found");
            _DbSet.Remove(Entity);
            SaveChanges();
        }
        public void SaveChanges() => _Context.SaveChanges();
        public void Update(T entity)
        {
            var ent = _DbSet.FirstOrDefault(e => e.Id == entity.Id);
            if (ent == null) throw new ArgumentException("Data is Null");
            _DbSet.Update(entity);
            SaveChanges();
        }
    }
}
