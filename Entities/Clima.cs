using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace apirest_webapp.Entities
{
    public class Clima
    {
        [Key]
        public int id { get; set; }
        public int temp { get; set; }
        public int temp_min { get; set; }
        public int temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public int feels_like { get; set; }
        public string city { get; set; }
        public string icon { get; set; }
    }
}
