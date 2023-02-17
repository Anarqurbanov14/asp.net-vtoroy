using HomeWork2.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace HomeWork2.Data.appDbContext
{
    public class CodeAcademy :DbContext
    {
        public CodeAcademy(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("TbBook");
            modelBuilder.Entity<Student>().ToTable("TbStudent");
        }
    }
}
