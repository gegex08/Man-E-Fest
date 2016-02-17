using GroupProjectFestivalApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GroupProjectFestivalApp.Presentation.Controllers {
    public class CommentController : ApiController {

        private EventService _eventService;

        public CommentController(EventService eventService) {
            _eventService = eventService;
        }

        [HttpGet]
        [Route("api/event/comments")]
        public IList<CommentDTO> GetComment() {
            return _eventService.GetComment();
        }
    }
}

