using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class PingController : Controller
    {
        [Route("api/Ping")]
        public string Get()
        {
            return $"Sucesso {DateTime.Now}";
        }
    }
}
