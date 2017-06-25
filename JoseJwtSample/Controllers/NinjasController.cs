using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace JoseJwtSample.Controllers
{
    [Route("api/[controller]")]
    public class NinjasController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Genin", "Chuunin", "Jonin" };
        }

        // GET api/values/5
        [HttpGet("{level}")]
        public string Get(string level)
        {
            switch (level)
            {
                case "Genin": return "Shinobi Baixo";
                case "Chuunin": return "Shinobi Intermediário";
                case "Jonin": return "Shinobi Alto";
                default: return "Nível não encontrado";
            }
        }
    }
}
