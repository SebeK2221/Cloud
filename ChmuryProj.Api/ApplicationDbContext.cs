using ChmuryProj.Api.Entity;
using Microsoft.EntityFrameworkCore;

namespace ChmuryProj.Api
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<KomentarzEntity> Komentarze { get; set; }
        // Dodaj DbSet dla Twoich tabel np:
        // public DbSet<Book> Books { get; set; }
    }
}
