
using Microsoft.EntityFrameworkCore;

namespace MoviePages.Models {
    public class MoviePageContext : DbContext {
        public MoviePageContext (DbContextOptions<MoviePageContext> options) : base (options) { }

        public DbSet<MoviePages.Models.Movie> Movie { get; set; }
    }
}