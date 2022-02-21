using Core.Models.Entity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class FilmModel
    {
    
        public List<Film> fList{ get; set; }
        public List<FilmTur> ftList { get; set; }

        public Film Film{ get; set; }
        //public int FilmTurId { get; set; }
        public FilmTur FilmTurler { get; set; }

        public ICollection<FilmTur> FilmTur { get; set; }


    }
}
