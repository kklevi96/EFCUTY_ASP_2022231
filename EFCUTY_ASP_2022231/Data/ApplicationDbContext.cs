using EFCUTY_ASP_2022231.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EFCUTY_ASP_2022231.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SiteUser> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Comment>()
                .HasOne(t => t.Post)
                .WithMany(t => t.Comments)
                .HasForeignKey(t => t.PostId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Comment>()
                .HasOne(t => t.Author)
                .WithMany()
                .HasForeignKey(t => t.SiteUserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Post>()
                .HasOne(t => t.Subject)
                .WithMany(t => t.Posts)
                .HasForeignKey(t => t.SubjectCode)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<Post>()
                .HasOne(t => t.Author)
                .WithMany()
                .HasForeignKey(t => t.SiteUserId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);

            Subject s1 = new()
            {
                Name = "Analízis 1",
                CreditValue = 7,
                ExamSubject = true,
                Semester = 1,
                SubjectCode = "NIXMN1HBNE"
            };

            builder.Entity<Subject>().HasData(s1);

        }
    }
}
