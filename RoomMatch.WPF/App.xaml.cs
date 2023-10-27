using Microsoft.Extensions.DependencyInjection;
using RoomMatch.Domain.Services;
using RoomMatch.WPF.Controls;
using RoomMatch.WPF.ViewModels;
using RoomMatch.WPF.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Xaml;

namespace RoomMatch.WPF
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {

    protected override void OnStartup(StartupEventArgs e)
    {
      Navigator navigator = new Navigator();
      MainWindow = new MainWindow()
      {
        DataContext= new MainViewModel()
      }; 
      MainWindow.Show();  
      base.OnStartup(e);
    }
    // Dependency Injection 
    //private IServiceProvider serviceProvider()
    // {
    //   IServiceCollection serviceProvider = new ServiceCollection();
    // }
  }
}
