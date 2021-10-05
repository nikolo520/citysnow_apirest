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
        [HttpGet("{city}")]
        public IActionResult Get(String city)
        {
            if (city == "Cali")
            {
                return Ok(
                        new object[]
                        {
                            new{ Temp = 50 }
                        }
                    );
            }else if(city == "Ibague")
            {
                return Ok(
                        new object[]
                        {
                            new{ Temp = 60 }
                        }
                    );
             }
            else if (city == "New York")
            {
                return Ok(
                        new object[]
                        {
                            new{ Temp = 70 }
                        }
                    );
            }
            else
            {
                return Ok(
                        new object[]
                        {
                            new{ Temp = 80 }
                        }
                    );
            }
        }
    }
}
