using GroupProjectFestivalApp.Infrastructure;
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
                        AttendanceCount = e.Users.Count(),
                        Pushpin = e.Pushpin.Name,
                        Attraction = new AttractionDTO() {
                            Name = e.Attraction.Name,
                            Description = e.Attraction.Description,
                            Rating = (int) e.Attraction.Rating,
                            SoundUrl = e.Attraction.Sound,
                            PictureUrl = e.Attraction.PictureUrl
                        },
                        Tags = (from t in e.Tags
                               select t.Name).ToList(),
                        Host = e.Host.Name,
                        Rating = (int) e.Rating
                    }).ToList();
        }
    }
}