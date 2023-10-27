using RoomMatch.Domain.Utilities;
using RoomMatch.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomMatch.WPF.Controls
{
    public class Navigator: NotifyObject
    {
        public ViewModelBase CurrentView
        {
          get { return Get<ViewModelBase>(); }
          set { Set<ViewModelBase>(value); }
        }

    
  }
}
