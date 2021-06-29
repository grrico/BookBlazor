using BookApp.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace BookApp.Interfaces
{
    public interface IPolygonCoordinatesService
    {
        Task<long> Create(PolygonCoordinates polygonCoordinates);
        Task<PolygonCoordinates> ReadById(long id);

        Task<List<PolygonCoordinates>> ListAll(int skip,
                              int take,
                              string orderBy,
                              string direction,
                              string search);


    }
}
