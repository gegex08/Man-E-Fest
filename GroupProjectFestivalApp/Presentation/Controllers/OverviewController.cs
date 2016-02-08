using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace GroupProjectFestivalApp.Presentation.Controllers {
    public class OverviewController : ApiController{


        private OverviewService _overviewService;

        public OverviewController(OverviewService overviewService) {
            _overviewService = overviewService;
        }

    }
}
