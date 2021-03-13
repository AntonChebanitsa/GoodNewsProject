using GoodNewsProject.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GoodNewsProject.Data
{
    public class GoodNewsContext: DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentArticle> CommentArticles { get; set; }
        public DbSet<CommentUser> CommentUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public GoodNewsContext(DbContextOptions<GoodNewsContext> options) :base(options)
        {
            //todo Add migrations here
        }

    }
}