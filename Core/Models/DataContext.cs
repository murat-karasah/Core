using Core.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options): base(options)
        {

        }
        public DbSet<Film> Filmler { get; set; }
        public DbSet<FilmTur> FilmTurleri { get; set; }

    }
}
