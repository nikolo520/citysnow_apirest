using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Properties.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultarDatos : Controller
    {
        [HttpGet("{id}")]
        public string Get(String city)
        {
            return city switch
            {
                
            };
        }
    }
}
