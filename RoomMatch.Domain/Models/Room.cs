using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomMatch.Domain.Models
{
    public class Room : DomainObject
    {

        public int UserId
        {
            get { return Get<int>(); }
            set { Set<int>(value); }
        }

        //The name of the person who have the room?? We already know it because of UserId or Id (DomainObject)??
        public string Name
        {
            get { return Get<string>(); }
            set { Set<string>(value); }
        }

        //What do this property?? I don't really understand
        public string Description
        {
            get { return Get<string>(); }
            set { Set<string>(value); }
        }
        public double Pricepublic
        {
            get { return Get<double>(); }
            set { Set<double>(value); }
        }
        public DateTime MoveInDate
        {
            get { return Get<DateTime>(); }
            set { Set<DateTime>(value); }
        }
        public DateTime MoveOutDate
        {
            get { return Get<DateTime>(); }
            set { Set<DateTime>(value); }
        }
        public bool Available
        {
            get { return Get<bool>(); }
            set { Set<bool>(value); }
        }
        public bool AnimalAllow
        {
            get { return Get<bool>(); }
            set { Set<bool>(value); }
        }

        public bool PlayMusicAllow
        {
            get { return Get<bool>(); }
            set { Set<bool>(value); }
        }

        //public string StreetAddress
        //{
        //    get { return Get<string>(); }
        //    set { Set<string>(value); }
        //}

        //public string City
        //{
        //    get { return Get<string>(); }
        //    set { Set<string>(value); }
        //}

        //public string State
        //{
        //    get { return Get<string>(); }
        //    set { Set<string>(value); }
        //}

        //public string ZipCode
        //{
        //    get { return Get<string>(); }
        //    set { Set<string>(value); }
        //}

        // represents the number of bedrooms
        public int NumberOfBedrooms
        {
            get { return Get<int>(); }
            set { Set<int>(value); }
        }

        // represents the number of bathrooms
        public int NumberOfBathrooms
        {
            get { return Get<int>(); }
            set { Set<int>(value); }
        }

        // represents the size of the room or apartment in square feet
        public double SquareFootage
        {
            get { return Get<double>(); }
            set { Set<double>(value); }
        }

        // indicates whether the room or apartment is furnished
        public bool Furnished
        {
            get { return Get<bool>(); }
            set { Set<bool>(value); }
        }

        // indicates whether utilities (such as electricity, water, gas, internet, etc.) are included in the rent.
        public bool UtilitiesIncluded
        {
            get { return Get<bool>(); }
            set { Set<bool>(value); }
        }
    }
}
