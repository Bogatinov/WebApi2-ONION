using System.Collections.Generic;
using FBC.Northwind.Domain;

namespace FBC.Northwind.RepositoryInterfaces
{
    public interface IAlbumRepository : IRepository<Album>
    {
        IEnumerable<Album> GetLatestReleases(int count);
    }
}