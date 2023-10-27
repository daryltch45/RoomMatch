using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomMatch.Domain.Models
{
  public  class Room: DomainObject
  {
    
        public int UserId 
        {
          get { return Get<int>(); }
          set { Set<int>(value); }
        }

        public string Name
        {
          get { return Get<string>(); }
          set { Set<string>(value); }
        }
        public string Description
        {
          get { return Get<string>(); }
          set { Set<string>(value); }
        }
         public double Pricepublic
          {
            get { return Get<double>(); }
            set { Set<double>(value); }
          }
        public DateTime MoveInDate
        {
          get { return Get<DateTime>(); }
          set { Set<DateTime>(value); }
        }
        public DateTime MoveOutDate
        {
          get { return Get<DateTime>(); }
          set { Set<DateTime>(value); }
        }
        public bool Available
        {
          get { return Get<bool>(); }
          set { Set<bool>(value); }
        }
        public bool AnimalAllow
        {
          get { return Get<bool>(); }
          set { Set<bool>(value); }
        }
        
        public bool PlayMusicAllow
        {
          get { return Get<bool>(); }
          set { Set<bool>(value); }
        }
  }
}
