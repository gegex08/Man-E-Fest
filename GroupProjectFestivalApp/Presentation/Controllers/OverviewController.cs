using GroupProjectFestivalApp.Services;
using GroupProjectFestivalApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace GroupProjectFestivalApp.Presentation.Controllers {
    public class OverviewController : ApiController{


        private FestivalService _festivalService;

        public OverviewController(FestivalService festivalService) {
            _festivalService = festivalService;
        }

        public IList<FestivalDTO> Get()
        {
            return _festivalService.GetFestival();

        }
            
    }
}
