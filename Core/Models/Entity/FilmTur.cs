using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models.Entity
{
    public class FilmTur
    {
        public int FilmTurId { get; set; }
        public string TurAd{ get; set; }
        public ICollection<Film> Filmler { get; set; }
    }
}
