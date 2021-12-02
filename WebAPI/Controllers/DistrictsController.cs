using Business.Abstract;
using Entities.Concrete;
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
    public class DistrictsController : ControllerBase
    {
        IDistrictService _districtService;
        public DistrictsController(IDistrictService districtService)
        {
            _districtService = districtService;
        }

        [HttpPost("add")]
        public IActionResult Add(District district)
        {
            var result = _districtService.Add(district);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("get/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _districtService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _districtService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _districtService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(District district)
        {
            var result = _districtService.Update(district);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbycityid/{id}")]
        public IActionResult GetByCityId(int id) 
        {
            var result = _districtService.GetByCityId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
