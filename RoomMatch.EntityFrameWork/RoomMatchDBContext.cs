using Microsoft.EntityFrameworkCore;
using RoomMatch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomMatch.EntityFrameWork
{
  public class RoomMatchDBContext: DbContext
  {
    public DbSet<User> Users {  get; set; }
    public DbSet<Room> Rooms {  get; set; }
    public DbSet<Student> Students{  get; set; }

    //public RoomMatchDBContext(DbContextOptions options): base() {}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=RoomMatchDB;Trusted_Connection=True;");
      base.OnConfiguring(optionsBuilder);
    }
  }
}
