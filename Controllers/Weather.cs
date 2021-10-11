using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System;
using apirest_webapp.Contexts;
using apirest_webapp.Entities;

namespace apirest_webapp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly AppDbContext context;
        public WeatherController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet("{name}")]
        public Clima Get(string name)
        {
            History registro = new History
            {
                palabra = name,
                controller = "Weather",
                fecha = DateTime.Now,
                ip = "127.0.0.1"
            };
            context.History.Add(registro);
            context.SaveChanges();
            var articulos = context.Clima.FirstOrDefault(p=>p.city==name);
            return articulos;
        }
        
    }
}
