using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize()]
    [ApiController]
    public class CozumController : ControllerBase
    { private ICozumService _cozumService;
        public CozumController(ICozumService cozumService)
        {
            _cozumService = cozumService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var data = _cozumService.GetList().ToList();
            return Ok(data);
        }
    }
}