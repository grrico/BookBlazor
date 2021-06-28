using BookApp.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookApp.Interfaces
{
    public interface IBookLatLngService
    {

        Task<long> Create(BookLatLng latlng);
        Task<BookLatLng> ReadById(long latlngid);

        Task<List<BookLatLng>> ListAll(int skip,
                              int take,
                              string orderBy,
                              string direction,
                              string search);
        //Task<int> Update(LatLng book, long pk);
        //Task<int> Delete(long id);
        //Task<int> Count(string search);

    }
}
