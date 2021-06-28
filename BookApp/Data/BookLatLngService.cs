using BookApp.Interfaces;
using BookApp.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
namespace BookApp.Data
{
    public class BookLatLngService : IBookLatLngService
    {
        private readonly IDapperService _dapperService;
        public BookLatLngService(IDapperService dapperService)
        {
            this._dapperService = dapperService;
        }

        public Task<long> Create(BookLatLng booklatlng)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("ISBN", booklatlng.ISBN, DbType.Int64);
            dbPara.Add("Latitud", booklatlng.Latitud, DbType.String);
            dbPara.Add("Longitud", booklatlng.Longitud, DbType.String);
            var booklatlngId = Task.FromResult(_dapperService.Insert<long>("[dbo].[spAddLatLng]", dbPara, commandType: CommandType.StoredProcedure));
            return booklatlngId;
        }

        public Task<List<BookLatLng>> ListAll(int skip, int take, string orderBy, string direction = "DESC", string search = "")
        {
            var bookLatlngs = Task.FromResult(_dapperService.
            GetAll<BookLatLng>($"SELECT Id, IsBn, Latitud, Longitud FROM BookLatLng " +
            $"WHERE IsBn = '{search}'" +
            $"ORDER BY {orderBy} " +
            $"{direction} OFFSET {skip} ROWS FETCH NEXT {take} " +
            $"ROWS ONLY;", null, commandType: CommandType.Text));
            return bookLatlngs;
        }

        public Task<BookLatLng> ReadById(long latlngid)
        {
            var booklatlng = Task.FromResult(_dapperService.Get<BookLatLng>
                ($"select * from [BookLatLng] where ID = {latlngid}", null, commandType: CommandType.Text));
            return booklatlng;
        }
    }

}
