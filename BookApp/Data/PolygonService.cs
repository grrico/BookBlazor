using BookApp.Interfaces;
using BookApp.Entities;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
namespace BookApp.Data
{
    public class PolygonService : IPolygonService
    {
        private readonly IDapperService _dapperService;
        public PolygonService(IDapperService dapperService)
        {
            this._dapperService = dapperService;
        }

        public Task<long> Create(Polygon polygon)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("Id", polygon.Id, DbType.Int64);
            dbPara.Add("ProjectId", polygon.ProjectId, DbType.Int64);
            dbPara.Add("NameProyecto", polygon.NameProyect, DbType.String);
            dbPara.Add("Icon", polygon.Icon, DbType.String);
            dbPara.Add("Scale", polygon.Scale, DbType.Decimal);
            dbPara.Add("NamePolygon", polygon.NamePolygon, DbType.String);
            dbPara.Add("LineStyleColor", polygon.LineStyleColor, DbType.String);
            dbPara.Add("LineStyleWidth", polygon.LineStyleWidth, DbType.Int64);
            dbPara.Add("PolyStyleColor", polygon.PolyStyleColor, DbType.String);
            var booklatlngId = Task.FromResult(_dapperService.Insert<long>("[dbo].[spAddLatLng]", dbPara, commandType: CommandType.StoredProcedure));
            return booklatlngId;
        }

        public Task<List<Polygon>> ListAll(int skip, int take, string orderBy, string direction = "DESC", string search = "")
        {
            var polygons = Task.FromResult(_dapperService.
            GetAll<Polygon>($"SELECT Id, ProjectId, NameProyect, Icon, Scale, NamePolygon, LineStyleColor, LineStyleWidth, PolyStyleColor FROM   Polygon p with (nolock) " +
            $"WHERE where p.Id = {search}" +
            $"ORDER BY {orderBy} " +
            $"{direction} OFFSET {skip} ROWS FETCH NEXT {take} " +
            $"ROWS ONLY;", null, commandType: CommandType.Text));
            return polygons;
        }

        public Task<Polygon> ReadById(long id)
        {
            var polygon = Task.FromResult(_dapperService.Get<Polygon>
                ($"select * from [BookLatLng] where ID = {id}", null, commandType: CommandType.Text));
            return polygon;
        }
    }
}
