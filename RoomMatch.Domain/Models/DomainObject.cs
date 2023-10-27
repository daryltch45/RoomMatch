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
      set { Set<int> (value); }
    }
    }
}
