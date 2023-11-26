using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomMatch.Domain.Services
{
  public interface IDataService<T>
  {
    Task<IEnumerable<T>> GetAll();
    Task<T> GetUserById(int id);
    Task<T> GetUserByUsername(int id);
    Task<T> Create(T entity);
    Task<T> Update(int id, T entity);
    Task<bool> Delete(int id);

   // Retrieves a single entity of type T by a unique property (e.g., username)
   Task<T> GetByUniqueProperty(string propertyName, object value);
    }
}
