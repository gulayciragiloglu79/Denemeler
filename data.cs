using System.Data.Entity;
using RepveUOW.Data.Model;

namespace Data
{
    public class EFBlogContext : DbContext
    {
        public EFBlogContext()
            : base("BlogContext")
        {
        }

        public DbSet Users { get; set; }
        public DbSet Categories { get; set; }
        public DbSet
 Articles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // İlişkileri kuruyoruz one-to-many olarak.
            modelBuilder.Entity
()
                .HasRequired(x => x.Category)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.CategoryId);

            modelBuilder.Entity
()
                .HasRequired(x => x.User)
                .WithMany(x => x.Articles)
                .HasForeignKey(x => x.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
