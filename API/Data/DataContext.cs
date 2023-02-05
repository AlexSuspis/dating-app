using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    //creates database connection
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        //Represents tables inside database
        public DbSet<AppUser> Users { get; set; }
    }
}