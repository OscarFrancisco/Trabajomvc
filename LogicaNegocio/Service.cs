using System;
using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace LogicaNegocio
{
    public class Service<T> : IService<T> where T : class
    {
        readonly IRepositorio<T> _context;
        public Service(IRepositorio<T> context)
        {
            _context = context;
        }
        public T Add(T entity)
        {
            _context.Entities.Add(entity);
            _context.SaveChanges();
            return entity;
        }
        public int Delete(T entity)
        {
            _context.Entities.Remove(entity);
            return _context.SaveChanges();
        }
        public T Get(T entity)
        {
            return _context.Entities.Find(entity);
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Entities;
        }
        public int Update(T entity)
        {
            var Entity = entity;
            Entity = entity;
            return _context.SaveChanges();
        }
    }
}
