using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProjectFestivalApp.Domain {
    public class Event {

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public ApplicationUser User {get; set;}

        public Pin Pin { get; set; }

          
    }
}