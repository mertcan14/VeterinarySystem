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
    public class HospitalizasyonBedsController : ControllerBase
    {
        IHospitalizasyonBedService _hospitalizasyonBedService;

        public HospitalizasyonBedsController(IHospitalizasyonBedService hospitalizasyonBedService)
        {
            _hospitalizasyonBedService = hospitalizasyonBedService;
        }

        [HttpPost("add")]
        public IActionResult Add(HospitalizasyonBed hospitalizasyonBed)
        {
            var result = _hospitalizasyonBedService.Add(hospitalizasyonBed);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("get/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _hospitalizasyonBedService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _hospitalizasyonBedService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _hospitalizasyonBedService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(HospitalizasyonBed hospitalizasyonBed)
        {
            var result = _hospitalizasyonBedService.Update(hospitalizasyonBed);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
