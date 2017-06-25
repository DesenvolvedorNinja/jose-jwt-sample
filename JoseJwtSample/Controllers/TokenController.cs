using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace JoseJwtSample.Controllers
{
    [Route("api/[controller]")]
    public class TokenController : Controller
    {
        [AllowAnonymous]
        [HttpPost]
        public string Post()
        {
            AuthorizationToken token = new AuthorizationToken("http://desenvolvedor.ninja", "desenvolvedor.ninja", "DesenvolvedorNinja", null);
            return Jose.JWT.Encode(token, Encoding.UTF8.GetBytes("abcdefghijklmnopqrs"), Jose.JwsAlgorithm.HS256);
        }
    }
}