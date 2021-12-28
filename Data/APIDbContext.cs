using Microsoft.EntityFrameworkCore;
using MusicAPP.Models;

namespace MusicAPP.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options)
        {

        }

        public DbSet<Song> Songs { get; set; }  
    }
}
