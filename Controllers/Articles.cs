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
    public class ArticlesController : ControllerBase
    {
        private readonly AppDbContext cont1;
        public ArticlesController(AppDbContext cont1)
        {
            this.cont1 = cont1;
        }

        [HttpGet]
        public IEnumerable<Articulo> Get()
        {
            return cont1.Articulo.ToList();
        }


        [HttpGet("{name}")]
        public IEnumerable<Articulo> Get(string name)
        {
            History registro = new History
            {
                palabra = name,
                controller = "Articles",
                fecha = DateTime.Now,
                ip = "127.0.0.1"
            };
            cont1.History.Add(registro);
            cont1.SaveChanges();
            return cont1.Articulo.Where(art => art.city == name).ToList();
        }
    }
}
