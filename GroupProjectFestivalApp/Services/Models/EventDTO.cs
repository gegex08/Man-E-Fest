﻿using GroupProjectFestivalApp.Domain;
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

        public int AttendanceCount { get; set; }

        public string Pushpin { get; set; }

        public AttractionDTO Attraction { get; set; }

        public IList<string> Tags { get; set; }

        public string Host { get; set; }

        public int Rating { get; set; }
    }
}