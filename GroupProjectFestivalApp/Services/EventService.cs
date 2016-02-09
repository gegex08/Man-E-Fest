using GroupProjectFestivalApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProjectFestivalApp.Services {
    public class EventService {
        private EventRepository _eventRepo;

        public EventService(EventRepository eventRepo) {
            _eventRepo = eventRepo;
        }
        public IList<EventDTO> GetEvent() {
             
            return (from e in _eventRepo.List()
                    select new EventDTO() {

                        Id = e.Id,
                        StartTime = e.StartTime,
                        EndTime = e.EndTime,
                        Users = e.Users,
                        Pushpins = e.Pushpins,
                        Attractions = e.Attractions,
                        Tags = e.Tags,
                        Host = e.Host,
                        Ratings = e.Ratings
                    }).ToList();
        }
    }
}