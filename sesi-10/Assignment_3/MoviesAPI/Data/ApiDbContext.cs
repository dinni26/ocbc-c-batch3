using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;


namespace MoviesAPI.Data {
    public class ApiDbContext : DbContext {
        public virtual DbSet<MoviesData> Movies {get; set;}

        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) 
        {

        }
    }
}