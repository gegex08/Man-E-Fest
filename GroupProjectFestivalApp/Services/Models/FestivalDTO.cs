﻿using GroupProjectFestivalApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProjectFestivalApp.Services.Models
{
    public class FestivalDTO
    {

        public int Id { get; set; }
        public string Url { get; set; }
        public IList<Pushpin> Pushpins { get; set; }

        public IList<Event> Events { get; set; }
        public IList<Attraction> Attractions { get; set; }
        public ApplicationUser User { get; set; }
                
    }
}