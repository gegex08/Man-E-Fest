using GroupProjectFestivalApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProjectFestivalApp.Services.Models
{
    public class FestivalDTO
    {


        public string Name { get; set; }
        public string Event { get; set; }

        public IList<Tag> Tags { get; set; }
        public string Description { get; set; }
        public string Host { get; set; }
        public int Rating { get; set; }    
        
    }
}