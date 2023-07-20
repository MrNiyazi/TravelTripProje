using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TravelTripProje.Models.Sınıflar;

namespace TravelTripProje.Models.Siniflar
{
    public class BlogYorum
    {
        public IEnumerable<Blog> Değer1 { get; set; }
        public IEnumerable<Blog> Değer3 { get; set; }
        public IEnumerable<Yorumlar> Değer2 { get; set; }
        
    }
}