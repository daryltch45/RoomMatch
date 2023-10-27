using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomMatch.Domain.Models
{
  public class Student: DomainObject
  {
    public string Firstname
    {
      get { return Get<string>(); }
      set { Set<string>(value); }
    }
    public string Lastname
    {
      get { return Get<string>(); }
      set { Set<string>(value); }
    }  
    
  }
}
