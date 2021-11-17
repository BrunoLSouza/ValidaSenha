using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bpls.validaSenha.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SenhaConntroller : ControllerBase
    {
        [HttpGet]
        public IActionResult IsVallid(string senha)
        {
            return null;
        }
    }
}
