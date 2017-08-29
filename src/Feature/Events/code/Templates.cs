using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace code
{
  public class Templates
  {
    public struct Event
    {
      public static readonly ID ID = new ID("{8ED15A32-249F-4315-AE92-5A2B69535008}");
      public struct Fields
      {
        public static readonly ID Title = new ID("{E6F0EB4C-76C6-4780-8E84-935C392791E4}");
        public static readonly ID Description = new ID("{1EF47557-4207-42B0-B164-307703A913AB}");
        public static readonly ID Date = new ID("{86E8829C-5711-4BBA-AE20-E2A1B81FDC92}");
        public static readonly ID Venue = new ID("{1ECE8FD8-EE40-4BF7-8383-6022F8803E13}");
        public static readonly ID VenueAddress = new ID("{57DAD052-55C0-44D0-8E7B-E88F5909165C}");
      }
    }
  }
}