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
    public class HistoryController : ControllerBase
    {
        private readonly AppDbContext context;
        public HistoryController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable <History> Get()
        {
            return context.History.ToList();
        }

    }
}
