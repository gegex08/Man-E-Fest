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
        public string Attraction { get; set; }

        public string Pin { get; set; }
        public string Event { get; set; }
        public string Comment { get; set; }
        
    }
}