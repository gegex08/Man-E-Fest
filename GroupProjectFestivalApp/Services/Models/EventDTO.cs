using GroupProjectFestivalApp.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroupProjectFestivalApp.Services.Models {
    public class EventDTO {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public ApplicationUser Users { get; set; }

        public IList<Pushpin> Pushpins { get; set; }

        public IList<Attraction> Attractions { get; set; }

        public IList<Tag> Tags { get; set; }

        public string Host { get; set; }

        [Range(0, 5)]
        public int Ratings { get; set; }
    }
}