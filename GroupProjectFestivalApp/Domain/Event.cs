using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProjectFestivalApp.Domain {
    public class Event {

        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public ApplicationUser Users { get; set; }

        public Pin Pin { get; set; }

        public string Attraction { get; set; }

        public IList<Tag> Tags { get; set; }

        public string Host { get; set; }

        public IList<Rating> Ratings { get; set; }


    }
}