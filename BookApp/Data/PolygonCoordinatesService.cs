using BookApp.Interfaces;
using BookApp.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
namespace BookApp.Data
{
    public class PolygonCoordinatesService : IPolygonCoordinatesService
    {
        private readonly IDapperService _dapperService;
        public PolygonCoordinatesService(IDapperService dapperService)
        {
            this._dapperService = dapperService;
        }

        public Task<long> Create(PolygonCoordinates polygon)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", polygon.Id, DbType.Int64);
            dbPara.Add("PolygonId", polygon.PolygonId, DbType.Int64);
            dbPara.Add("Latitude", polygon.Latitude, DbType.Decimal);
            dbPara.Add("Longitude", polygon.Longitude, DbType.Decimal);
            dbPara.Add("Altitude", polygon.Altitude, DbType.Currency);
            var booklatlngId = Task.FromResult(_dapperService.Insert<long>("[dbo].[spAddPolygonCoordinates]", dbPara, commandType: CommandType.StoredProcedure));
            return booklatlngId;
        }

        public Task<List<PolygonCoordinates>> ListAll(int skip, int take, string orderBy, string direction = "DESC", string search = "")
        {
            var polygonsCoodinates = Task.FromResult(_dapperService.
            GetAll<PolygonCoordinates>($"SELECT Id, PolygonId, Latitude, Longitude, Altitude FROM  PolygonCoordinates p with (nolock)" +
            $"WHERE p.PolygonId = {search}" +
            $"ORDER BY {orderBy} " +
            $"{direction} OFFSET {skip} ROWS FETCH NEXT {take} " +
            $"ROWS ONLY;", null, commandType: CommandType.Text));
            return polygonsCoodinates;
        }

        public Task<PolygonCoordinates> ReadById(long id)
        {
            var polygonCoordinates = Task.FromResult(_dapperService.Get<PolygonCoordinates>
                ($"SELECT Id, PolygonId, Latitude, Longitude, Altitude FROM  PolygonCoordinates p with (nolock) where ID = {id}", null, commandType: CommandType.Text));
            return polygonCoordinates;
        }

    }
}
