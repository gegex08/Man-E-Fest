using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GroupProjectFestivalApp.Domain {
    public class Attraction {

        public int Id { get; set; }

        public string Event { get; set; }

        public string Name { get; set; }

        public string Tag { get; set; }

        public string Description { get; set; }

        public string Host { get; set;  }

        [Range(0,5)]
        
        public int Rating { get; set; }
    }
}