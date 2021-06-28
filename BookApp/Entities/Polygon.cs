using System;
using System.Collections.Generic;

namespace BookApp.Entities
{
    public partial class Polygon
    {
        public Polygon()
        {
            PolygonCoordinates = new HashSet<PolygonCoordinates>();
        }

        public long Id { get; set; }
        public long? ProjectId { get; set; }
        public string NameProyecto { get; set; }
        public string Icon { get; set; }
        public decimal? Scale { get; set; }
        public string NamePolygon { get; set; }
        public string LineStyleColor { get; set; }
        public decimal? LineStyleWidth { get; set; }
        public string PolyStyleColor { get; set; }

        public virtual ICollection<PolygonCoordinates> PolygonCoordinates { get; set; }
    }
}
