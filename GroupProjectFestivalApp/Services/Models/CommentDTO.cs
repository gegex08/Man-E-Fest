using GroupProjectFestivalApp.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroupProjectFestivalApp.Services {
    public class CommentDTO {
        public int Id { get; set; }

        public string Message { get; set; }

        public Event Event { get; set; }


    }
}