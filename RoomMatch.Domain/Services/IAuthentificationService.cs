using RoomMatch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomMatch.Domain.Services
{
  public interface IAuthentificationService
  {
    Task<bool> Register(string firstname, string lastname, string username, string email, string password, string confirmedPassword, int StudentId = -1);
    Task<User> Login(string username, string password);

  }
}
