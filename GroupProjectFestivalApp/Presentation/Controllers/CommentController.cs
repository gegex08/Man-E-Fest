using GroupProjectFestivalApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GroupProjectFestivalApp.Presentation.Controllers {
    public class CommentController : ApiController {

        private CommentService _commentService;

        public CommentController(CommentService commentService) {
            _commentService = commentService;
        }

        [HttpGet]
        [Route("api/event/comments")]
        public IList<CommentDTO> GetComment() {
            return _commentService.GetComment();
        }
    }
}

