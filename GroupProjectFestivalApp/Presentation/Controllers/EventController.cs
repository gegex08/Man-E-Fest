using GroupProjectFestivalApp.Presentation.Models;
using GroupProjectFestivalApp.Services;
using GroupProjectFestivalApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GroupProjectFestivalApp.Presentation.Controllers {
    public class EventController : ApiController {
        private EventService _eventService;

        public EventController(EventService eventService) {
            _eventService = eventService;
        }


        [HttpGet]
        [Route("api/events")]
        public IList<EventDTO> Get() {
            return _eventService.GetEvent();
        }

        [HttpPost]
        [Authorize]
        [Route("api/events/{id}/rating")]
        public IHttpActionResult AddComment(int id, CommentBindingModel comment) {
            if (ModelState.IsValid) {
                return Ok(_eventService.AddComment(id, User.Identity.Name, comment));
            }
            return BadRequest();
        }

        [Route("api/event/comments")]
        public IList<CommentDTO> GetComment() {
            return _eventService.GetComment();
        }
    }
}
