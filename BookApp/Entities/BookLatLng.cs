using System;
using System.ComponentModel.DataAnnotations;
namespace BookApp.Entities
{
    public class BookLatLng 
    {
        [Key]
        public long? ID {get; set; }
        public long? ISBN { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
    }
}
