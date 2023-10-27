using RoomMatch.Domain.Services;
using RoomMatch.Domain.Utilities;
using RoomMatch.WPF.Controls;
using RoomMatch.WPF.Essencials;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomMatch.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
    public ViewModelBase CurrentViewModel
    {
      get { return Get<ViewModelBase>(); }
      set { Set<ViewModelBase>(value); }
    }

    public MainViewModel()
    {
      CurrentViewModel = new LoginViewModel(this); 
    }
      
    }
}
