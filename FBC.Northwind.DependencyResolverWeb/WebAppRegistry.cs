using FBC.Northwind.Data.Context;
using FBC.Northwind.Data.Repositories;
using FBC.Northwind.Data.UnitOfWOrk;
using FBC.Northwind.RepositoryInterfaces;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;
using StructureMap.Web;

namespace FBC.Northwind.DependencyResolverWeb
{
    public class WebAppRegistry : Registry
    {
        public WebAppRegistry()
        {
            Scan(
                scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });

            For<IDbContextFactory>().HybridHttpOrThreadLocalScoped().Use<MusicStoreDbContextFactory>();
            For<IUnitOfWork>().HybridHttpOrThreadLocalScoped().Use<MusicStoreUnitOfWork>();
            For<IAlbumRepository>().HybridHttpOrThreadLocalScoped().Use<AlbumRepository>();
            For<IArtistRepository>().HybridHttpOrThreadLocalScoped().Use<ArtistRepository>();
            For<IGenreRepository>().HybridHttpOrThreadLocalScoped().Use<GenreRepository>();
        }
    }
}