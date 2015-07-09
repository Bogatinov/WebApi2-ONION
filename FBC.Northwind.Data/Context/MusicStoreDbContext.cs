using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using FBC.Northwind.Domain;

namespace FBC.Northwind.Data.Context
{
    public class MusicStoreDbContext : DbContext
    {
        public MusicStoreDbContext()
            : base("name=DefaultConnection")
        {
        }

        public MusicStoreDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public IDbSet<Album> Albums { get; set; }
        public IDbSet<Artist> Artists { get; set; }
        public IDbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            //modelBuilder.Entity<Album>().ToTable("Albums");
            //modelBuilder.Configurations.Add(new AlbumConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public void Commit()
        {
            SaveChanges();
        }
    }
}