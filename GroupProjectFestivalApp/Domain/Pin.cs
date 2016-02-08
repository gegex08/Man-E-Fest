using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProjectFestivalApp.Domain {
    public class Pin {

        public IList<Event> Events { get; set; }

      

        public string Host { get; set; }
    }
}