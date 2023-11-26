using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomMatch.Domain.Models
{
  public  class User: DomainObject
  {
        //ToDo: can we group properties like firstname, Lastname, username and age in the class DomainObject??
        public string Firstname
        {
          get { return Get<string>(); }
          set { Set<string>(value); }
        }
        public string Lastname
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
        public string PasswordHash
        {
          get { return Get<string>(); }
          set { Set<string>(value); }
        }
   
        //Date of what?? When the user joined the app or when he joined the appartment??
        public DateTime DateJoined
        {
          get { return Get<DateTime>(); }
          set { Set<DateTime>(value); }
        }

        //User's role: Is he a student? admin?? random person??
        public string UserRole
        {
            get { return Get<string>(); }
            set { Set<string>(value); }
        }

        //That's only a possibility 
        //We can include a property for the URL of the user's profile picture

        public string ProfilePictureUrl
        {
            get { return Get<string>(); }
            set { Set<string>(value); }
        }

    }
}
