using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GroupProjectFestivalApp.Infrastructure {
    public class FestivalRepository: GenericRepository<> {
        private ApplicationDbContext _db;

        public FestivalRepository(DbContext db) {
            _db = (ApplicationDbContext)db;
        }
        public IQueryable<T> List() {
            return from e in Table
                   where e.Active
                   select e;
        }
    }
}