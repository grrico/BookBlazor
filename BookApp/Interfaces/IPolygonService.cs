using BookApp.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BookApp.Interfaces
{
    public interface IPolygonService
    {
        Task<long> Create(Polygon polygon );
        Task<Polygon> ReadById(long id);

        Task<List<Polygon>> ListAll(int skip,
                              int take,
                              string orderBy,
                              string direction,
                              string search);

    }
}
