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
        public IList<CommentDTO> GetComments(int eventId) {

            return (from c in _commentRepo.List()
                    where c.Event.Id == eventId
                    select new CommentDTO() {
                        Id = c.Id,
                        Message = c.Message,
                        User = new ApplicationUserDTO() {
                            UserName = c.User.UserName
                        }
                    }).ToList();
        }
    }
}
