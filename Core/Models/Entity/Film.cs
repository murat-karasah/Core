using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models.Entity
{
    public class Film
    {
        public int FilmId { get; set; }
        public string FilmAd{ get; set; }
        public string FilmAciklama{ get; set; }
        public string FilmResim{ get; set; }
        


        [ForeignKey("FilmTur")]
        public int FilmTurId { get; set; }
        public FilmTur FilmTur{ get; set; }
    }
}
