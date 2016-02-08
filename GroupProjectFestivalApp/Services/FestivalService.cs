using GroupProjectFestivalApp.Infrastructure;
using GroupProjectFestivalApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProjectFestivalApp.Services
{
    public class FestivalService
    {
        private FestivalRepository _festivalRepo;

        public FestivalService(FestivalRepository festivalRepo)
        {
            _festivalRepo = festivalRepo;
        }
        public IList<FestivalDTO> GetFestival()
        {

            return (from f in _festivalRepo.List()
                    select new FestivalDTO()
                    {
                        Id = f.Id,
                        Name = f.Name,
                        Event = f.Event,
                        Description = f.Description,
                        Host = f.Host
                    }).ToList();
        }
    }
}