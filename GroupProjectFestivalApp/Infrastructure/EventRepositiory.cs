using GroupProjectFestivalApp.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GroupProjectFestivalApp.Infrastructure {
    public class EventRepositiory : GenericRepository<Event>
        
        {

        public EventRepositiory(DbContext db) : base(db) { }

        }  
        }
    
