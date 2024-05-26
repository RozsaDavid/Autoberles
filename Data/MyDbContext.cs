using Autoberles.Model;
using Microsoft.EntityFrameworkCore;

namespace Autoberles.Data {
    public class MyDbContext :DbContext {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Car> Car { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<User> User { get; set; }
    }
}
