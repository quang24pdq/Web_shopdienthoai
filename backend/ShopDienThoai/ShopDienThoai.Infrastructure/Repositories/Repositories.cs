using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopDienThoai.Domain.Repositories;
using ShopDienThoai.Infrastructure.Context;

namespace ShopDienThoai.Infrastructure.Repositories
{
    public class Repositories<T> : IRespositories<T> where T : class, new()
    {
        private readonly KinhdoanhdienthoaiContext dbContext;
        DbSet<T> entities;
        public Repositories(KinhdoanhdienthoaiContext context)
        {
            dbContext = context;
            entities = dbContext.Set<T>();
        }



        /*public async Task Add(T entity)
        {
            if(entity != null) 
            {
                entities.Add(entity);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            var obj = await entities.FindAsync(id);
            if(obj != null)
            {
                entities.Remove(obj);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<T>> GetAll()
        {
            return await entities.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            var obj = await entities.FindAsync(id);
            if (obj != null) 
            {
                return obj;
            }
            return null;
        }

        public async Task Update(T entity)
        {
            var obj = await entities.FindAsync(entity);
            if (obj != null)
            {
                dbContext.Entry(entity).State = EntityState.Modified;
                await dbContext.SaveChangesAsync();
            }
        }*/
        public bool Add(T entity)
        {
            if (!entities.Any(e => e == entity))
            {
                entities.Add(entity);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            var entity = entities.Find(id);
            if (entity == null)
            {
                return false;
            }
            entities.Remove(entity);
            dbContext.SaveChanges();
            return true;
        }

        public List<T> GetAll()
        {
            return entities.ToList();
        }

        public T GetEntity(int id)
        {
            var entity = entities.Find(id);
            if (entity != null)
            {
                return entity;
            }
            return null;
        }

        public bool Update(T entity)
        {
            if (!entities.Any(e => e == entity))
            {
                return false;
            }
            dbContext.Entry(entity).State = EntityState.Modified;
            try
            {
                dbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

            }
            return true;
        }

        /*public List<T> Paning(int page)
        {
            int pageSize = 10;
            if(entities == null)
            {
                return NotFound();
            }
            var sp = entities.Select(e => T(s).Skip);

        }*/
        /*[HttpGet]
        public async Task<ActionResult<IEnumerable<SinhvienDTO>>> GetSinhviens(int pageNumber)
        {
            int pageSize = 5;
            if (_context.Sinhviens == null)
            {
                return NotFound();
            }
            var sinhviens = await _context.Sinhviens.Select(s => SvDTO(s)).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
            *//*return await _context.Sinhviens.Select(s => SvDTO(s)).ToListAsync();*//*
            return sinhviens;
        }*/
    }
}
