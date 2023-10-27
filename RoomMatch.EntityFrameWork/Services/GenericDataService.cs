using Microsoft.EntityFrameworkCore;
using RoomMatch.Domain.Models;
using RoomMatch.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomMatch.EntityFrameWork.Services
{
  public class GenericDataService<T> : IDataService<T> where T : DomainObject
  {
    //private readonly RoomMatchDBContext _context;  --> Not Thread safe 
    public async Task<T> Create(T entity)
    {
      using(RoomMatchDBContext context = new RoomMatchDBContext())
      {
        var createdEnity = await context.Set<T>().AddAsync(entity);  
        await context.SaveChangesAsync();
        return createdEnity.Entity; 
      }
    }

    public async Task<bool> Delete(int id)
    {
      using (RoomMatchDBContext context = new RoomMatchDBContext())
      {
        T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
        if (entity == null)
          return false; 

        context.Set<T>().Remove(entity);
        await context.SaveChangesAsync();
        return true;
      }
    }

    public async Task<T> GetUserById(int id)
    {
      using (RoomMatchDBContext context = new RoomMatchDBContext())
      {
        T entity = await context.Set<T>().FirstOrDefaultAsync((e) => e.Id == id);
        
        return entity;
      }
    }
    // ToDo: To be implemented 
    public Task<T> GetUserByUsername(int id)
    {
      throw new NotImplementedException();
    }

    public async Task<IEnumerable<T>> GetAll()
    {
      using (RoomMatchDBContext context = new RoomMatchDBContext())
      {
        IEnumerable<T> entities = await context.Set<T>().ToListAsync();

        return entities;
      }
    }

    public async Task<T> Update(int id, T entity)
    {
      using (RoomMatchDBContext context = new RoomMatchDBContext())
      {
        entity.Id = id; 
        context.Set<T>().Update(entity);
        await context.SaveChangesAsync();
        return entity;
      }
    }

  }
}
