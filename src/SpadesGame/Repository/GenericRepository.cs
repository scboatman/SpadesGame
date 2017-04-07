﻿using Microsoft.EntityFrameworkCore;
using SpadesGame.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpadesGame.Repository
{
    public class GenericRepository : IGenericRepository

    {
        private ApplicationDbContext _db;
        public GenericRepository(ApplicationDbContext db)
        {
            this._db = db;
        }
        public IQueryable<T> Query<T>()  where T: class
        {
            return _db.Set<T>().AsQueryable();
        }

        public void Add<T>(T entityToCreate) where T : class
        {
            _db.Set<T>().Add(entityToCreate);
            this.SaveChanges();
        }

        public void Update<T>(T entityToUpdate) where T: class
        {
            _db.Set<T>().Update(entityToUpdate);
            this.SaveChanges();

        }
        public void Delete<T>(T entityToDelete) where T: class
        {
            _db.Set<T>().Remove(entityToDelete);
            this.SaveChanges();
        }

        public  IQueryable<T> SqlQuery<T>(string sql, params object[] parameters) where T: class
        {
            return _db.Set<T>().FromSql(sql, parameters);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();

        }


    }

    
}
