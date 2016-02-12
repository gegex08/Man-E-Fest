using GroupProjectFestivalApp.Infrastructure;
using GroupProjectFestivalApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupProjectFestivalApp.Services {
    public class HostService {
        private HostRepository _hostRepo;

        public HostService(HostRepository hostRepo) {
            _hostRepo = hostRepo;
        }
        public IList<HostDTO> GetHost() {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
            return (from f in _hostRepo.List()
                    select new HostDTO() {

                        Id = f.Id,
                        Url = f.Url,
                        Name = f.Name,
                        Pushpins = f.Pushpins,
                        Events = f.Events,
                        Attractions = f.Attractions,
                        User = f.User
                    }).ToList();
        }
    }
}