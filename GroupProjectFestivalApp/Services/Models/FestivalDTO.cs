using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProjectFestivalApp.Services.Models
{
    public class FestivalDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Event { get; set; }

        public string Tags { get; set; }
        public string Description { get; set; }
        public string Host { get; set; }
        
    }
}