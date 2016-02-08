using GroupProjectFestivalApp.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GroupProjectFestivalApp.Infrastructure
{
    public class FestivalRepository : GenericRepository<Attraction>
    {
        public FestivalRepository(DbContext db) : base(db) { }
    }
    //public IQueryable<Event> ListEvent() {
    //    return from e in _db.Event
    //           where e.Active
    //           select e;
    //}
}
