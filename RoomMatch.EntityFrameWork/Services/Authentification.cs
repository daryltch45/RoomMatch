using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using RoomMatch.Domain.Models;
using RoomMatch.Domain.Services;

namespace RoomMatch.EntityFrameWork.Services
{
  public class Authentification : IAuthentificationService
  {
    private readonly GenericDataService<User> dataService = new GenericDataService<User>(); 
    public async Task<User> Login(string username, string password)
    {
      //ToDo:Check if login credentitials valid 
      //ToDo:Get the userId 
      IEnumerable<User> users = await dataService.GetAll();    
      User user = users.FirstOrDefault(u => u.Username == username && u.PasswordHash == new PasswordHasher().HashPassword(password));
      return user; 
    }

    public async Task<bool> Register(string firstname, string lastname, string username, string email, string password, string confirmedPassword, int StudentId = -1)
    {
      //ToDo: Check if Password = confirmedPassword 
      //ToDo: Check if Password secure enough(Lenght, speciel caraters,..)
      //ToDo: Check if E-mail address valid 
      //ToDo: Check if the studentiD exists 

      //When true hash the password

      IPasswordHasher hasher = new PasswordHasher();
      
      User user = new User()
      {
        Firstname = firstname,
        Lastname = lastname,
        Username = username,
        Email = email,
        PasswordHash = hasher.HashPassword(password)
      };

      //ToDo: Add the new user in the database 
      return await dataService.Create(user) != null;


    }
  }
}
