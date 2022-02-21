using Core.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class FilmTurModel
    {
      
        public List<FilmTur> ftList { get; set; }
        public FilmTur FilmTur { get; set; }
        public ICollection<FilmTur> FilmTurs { get; set; }

    }
}
