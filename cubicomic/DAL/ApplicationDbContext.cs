using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity.ModelConfiguration.Conventions;
using cubicomic.Models;

namespace cubicomic.DAL
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("LocalConnection", throwIfV1Schema: false)
        {
        }
        public DbSet<File> Files { get; set; }
        public DbSet<FilePath> FilePaths { get; set; }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
    }
}