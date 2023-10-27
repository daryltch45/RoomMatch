using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RoomMatch.WPF.ViewModels
{
  public class RegisterViewModel: ViewModelBase
  {
    public string FirstName
    {
      get { return Get<string>(); }
      set { Set<string>(value); }
    }
    public string LastName
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

    public string Password
    {
      get { return Get<string>(); }
      set { Set<string>(value); }
    }
    public string ConfirmedPassword
    {
      get { return Get<string>(); }
      set { Set<string>(value); }
    }

    public string StudentId
    {
      get { return Get<string>(); }
      set { Set<string>(value); }
    }
    
    private MainViewModel currentViewModel; 
    public RelayCommand BackCommand { get; set; }
    public RegisterViewModel(MainViewModel mainViewModel)
    {
      currentViewModel = mainViewModel;
      BackCommand = new RelayCommand(() => { currentViewModel.CurrentViewModel = new LoginViewModel(currentViewModel); });
    }
    }
}
