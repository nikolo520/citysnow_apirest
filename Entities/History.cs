using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace apirest_webapp.Entities
{
    public class History
    {
        [Key]
        public string palabra { get; set; }
        public string controller { get; set; }
        public DateTime fecha { get; set; }
        public string ip { get; set; }
    }
}
