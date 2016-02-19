using GroupProjectFestivalApp.Infrastructure;
using GroupProjectFestivalApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace GroupProjectFestivalApp.Services {
    public class AttractionService {

        private EventRepository _eventRepo;
        private AttractionRepository _attractionRepo;
        private InfoRepository _infoRepo;

        public AttractionService(EventRepository eventRepo, AttractionRepository attractionRepo, InfoRepository infoRepo) {

            _eventRepo = eventRepo;
            _attractionRepo = attractionRepo;
            _infoRepo = infoRepo;
        }

        public AttractionDTO GetAttraction(int id) {

            return (from a in _attractionRepo.List()
                    where a.Id == id
                    select new AttractionDTO() {
                        PictureUrl = a.PictureUrl,
                        Name = a.Name,
                        Description = a.Description,
                        Rating = (int)a.Rating,
                    }).FirstOrDefault();
        }

        public IList<AttractionDTO> GetAttractions() {

            return (from a in _attractionRepo.List()
                    select new AttractionDTO() {
                        PictureUrl = a.PictureUrl,
                        Name = a.Name,
                        Description = a.Description,
                        Rating = (int)a.Rating,
                        Event = new EventDTO() {
                            StartTime = (from e in a.Events select e.StartTime).FirstOrDefault(),
                        }
                    }).ToList();
        }
    }
}
