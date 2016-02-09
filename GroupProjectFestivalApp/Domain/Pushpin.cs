using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProjectFestivalApp.Domain {
    public class Pushpin {

        public int Id { get; set; }

        public bool Loc1 { get; set; }

        public bool Loc2 { get; set; }

        public bool Loc3 { get; set; }

        public bool Loc4 { get; set; }

        public bool Loc5 { get; set; }

        public bool Loc6 { get; set; }

        public bool Loc7 { get; set; }

        public bool Loc8 { get; set; }

        public string Host { get; set; }

        public IList<Event> Events { get; set; }

        
    }
}