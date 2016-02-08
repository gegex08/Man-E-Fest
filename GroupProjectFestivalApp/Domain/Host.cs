using GroupProjectFestivalApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProjectFestivalApp.Domain {
    public class Host {

        public int Id { get; set; }

        public string Url { get; set; }

        public IList<Pin> Pins {get;set;}

    public IList<Event> Events {get; set;}

public IList<Attraction> Attractions { get; set; }

public ApplicationUser User { get; set; }
    }
}