using GroupProjectFestivalApp.Infrastructure;
using GroupProjectFestivalApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectFestivalApp.Services {
    public class CommentService {
        private CommentRepository _commentRepo;
        private EventRepository _eventRepo;
        private AttractionRepository _attractionRepo;

        public CommentService(CommentRepository commentRepo, EventRepository eventRepo, AttractionRepository attractionRepo) {
            _commentRepo = commentRepo;
            _eventRepo = eventRepo;
            _attractionRepo = attractionRepo;

        }
        public IList<CommentDTO> GetComment() {

            return (from c in _commentRepo.List()
                    select new CommentDTO() {

                        Id = c.Id,
                        Message = c.Message,
                        Event = new EventDTO() {
                            Id = c.Event.Id,
                            Pushpin = new PushpinDTO() {
                                Name = c.Event.Pushpin.Name,
                            },
                            Attraction = new AttractionDTO() {
                                Name = c.Event.Attraction.Name,
                            },
                            Tags = (from t in c.Event.Tags
                                    select t.Name).ToList(),
                            Rating = (int)c.Event.Rating
                        },
                        User = new ApplicationUserDTO() {
                            UserName = c.User.UserName
                        }
                    }).ToList();
        }
        


    }
}
