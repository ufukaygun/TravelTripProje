using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TravelTripProje.Models.Siniflar
{
    public class BlogYorum
    {
        //belli sayıdaki değerleri sayı formatında tutar.IEnumerable birden fazla tablodan değer çekilebilir
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }

    }
}