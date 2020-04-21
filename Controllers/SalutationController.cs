using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Learning;

namespace Learning.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalutationController : ControllerBase
    {
        private readonly ILogger<SalutationController> _logger;

        public SalutationController(ILogger<SalutationController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            var salut = new Salutation();
            return salut.Salut("Públio");
        }
    }
}
