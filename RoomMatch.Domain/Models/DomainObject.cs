using RoomMatch.Domain.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomMatch.Domain.Models
{
  public class DomainObject: NotifyObject
  {
        public int Id
        {
            get { return Get<int>(); }
            set { Set<int>(value); }
        }

        public string StreetAddress
        {
            get { return Get<string>(); }
            set { Set<string>(value); }
        }

        public string City
        {
            get { return Get<string>(); }
            set { Set<string>(value); }
        }

        public string State
        {
            get { return Get<string>(); }
            set { Set<string>(value); }
        }

        public string ZipCode
        {
            get { return Get<string>(); }
            set { Set<string>(value); }
        }

    }
}
