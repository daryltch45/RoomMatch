using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomMatch.Domain.Models
{
  public  class User: DomainObject
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
        public string Username
        {
          get { return Get<string>(); }
          set { Set<string>(value); }
        }
        public string Email
        {
          get { return Get<string>(); }
          set { Set<string>(value); }
        }
        public string PasswordHash
        {
          get { return Get<string>(); }
          set { Set<string>(value); }
        }
    
        public DateTime DateJoined
        {
          get { return Get<DateTime>(); }
          set { Set<DateTime>(value); }
        }
    }
}
