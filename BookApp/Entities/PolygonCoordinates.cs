using System;
using System.Collections.Generic;

namespace BookApp.Entities
{
    public partial class PolygonCoordinates
    {
        public long Id { get; set; }
        public long? PolygonId { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Altitude { get; set; }

        public virtual Polygon Polygon { get; set; }
    }
}
