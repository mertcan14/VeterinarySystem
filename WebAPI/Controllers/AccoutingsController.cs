using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccoutingsController : ControllerBase
    {
        IAccoutingService _accoutingService;

        public AccoutingsController(IAccoutingService accoutingService)
        {
            _accoutingService = accoutingService;
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            var result = _accoutingService.Get();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
