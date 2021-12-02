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
    public class HospitalCategoriesController : ControllerBase
    {
        IHospitalCategoryService _hospitalCategoryService;

        public HospitalCategoriesController(IHospitalCategoryService hospitalCategoryService)
        {
            _hospitalCategoryService = hospitalCategoryService;
        }

        [HttpPost("add")]
        public IActionResult Add(HospitalCategory hospitalCategory)
        {
            var result = _hospitalCategoryService.Add(hospitalCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("get/{id}")]
        public IActionResult GetById(int id)
        {
            var result = _hospitalCategoryService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _hospitalCategoryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _hospitalCategoryService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(HospitalCategory hospitalCategory)
        {
            var result = _hospitalCategoryService.Update(hospitalCategory);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
