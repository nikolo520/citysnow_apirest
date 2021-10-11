using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace apirest_webapp.Entities
{
    public class Articulo
    {
        [Key]
        public int id { get; set; }
        public string sourc { get; set; }
        public string city { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string urlToImage { get; set; }
    }
}
