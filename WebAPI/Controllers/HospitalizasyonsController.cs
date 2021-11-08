using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
    public class HospitalizasyonsController : ControllerBase
    {
        IHospitalizasyonService _hospitalizasyonService;

        public HospitalizasyonsController(IHospitalizasyonService hospitalizasyonService)
        {
            _hospitalizasyonService = hospitalizasyonService;
        }

        [HttpPost("add")]
        public IActionResult Add(Hospitalizasyon hospitalizasyon)
        {
            var result = _hospitalizasyonService.Add(hospitalizasyon);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("get/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _hospitalizasyonService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _hospitalizasyonService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _hospitalizasyonService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Hospitalizasyon hospitalizasyon)
        {
            var result = _hospitalizasyonService.Update(hospitalizasyon);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("checkbedavailable")]
        public IActionResult CheckBedAvailable(CheckBedAvailable checkBedAvailable)
        {
            var result = _hospitalizasyonService.BedAvailable(checkBedAvailable);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

