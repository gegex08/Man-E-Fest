using GroupProjectFestivalApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProjectFestivalApp.Services.Models {
    public class AttractionService {
        private AttractionRepository _attractionRepo;

        public AttractionService(AttractionRepository attractionRepo) {
            _attractionRepo = attractionRepo;
        }
        public IList<AttractionDTO> GetAttraction() {
            return (from a in _attractionRepo.List()
                    select new AttractionDTO() {

                        Name = a.Name,
                        Description = a.Description,
                        Rating = (int)a.Rating,
                        PictureUrl = a.PictureUrl,
                        SoundUrl = a.Sound
                    }).ToList();
        }
    }
}
