using GalaSoft.MvvmLight.Command;
using RoomMatch.Domain.Utilities;
using RoomMatch.WPF.Commands;
using RoomMatch.WPF.Controls;
using RoomMatch.WPF.Essencials;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RoomMatch.WPF.ViewModels
{
  public class LoginViewModel : ViewModelBase
  {
    public RelayCommand RegisterCommand { get; set; }
    public RelayCommand BackCommand { get; set; }
    
    public string Username
    {
      get { return Get<string>(); }
      set { Set<string>(value); }
    }
    int i = 3;
    public string Password
    {
      get { return Get<string>(); }
      set { Set<string>(value); }
    }
    private MainViewModel currentViewModel;
    public LoginViewModel(MainViewModel viewModel)
    {
      currentViewModel = viewModel;
      Username = "Sandro";
      Password = "Jäger"; 

      RegisterCommand = new RelayCommand(() => { currentViewModel.CurrentViewModel = new RegisterViewModel(currentViewModel); });
       
 //() => { currentViewModel.CurrentViewModel = new MainViewModel(); 
    }
}
}
