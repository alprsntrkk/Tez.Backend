using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
   
    [ApiController]
    public class CozumController : ControllerBase
    { private ICozumService _cozumService;
        
        public CozumController(ICozumService cozumService)
        {
            _cozumService = cozumService;
        }
        ///<summary>
        ///Bütün Çözümleri Getir
        ///</summary>
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
          
            var data = _cozumService.GetList().ToList();
            return Ok(data);
        }


        ///<summary>
        ///İd'ye göre çözümü getirir
        ///</summary>
        [HttpGet]
        [Route("{id}")]
        [Authorize()]
        public IActionResult GetByid(int id)
        {

            var data = _cozumService.GetByid(id);
            return Ok(data);
        }


        ///<summary>
        ///Çözüm tipinde gelen nesneyi ekleme işlemi yapar
        ///</summary>
        [HttpPost("")]
        [Authorize()]
        public IActionResult AddCozum(Cozum cozum)
        {
            _cozumService.Add(cozum);

            return Ok(cozum);
        }

        ///<summary>
        ///Çözüm tipinde gelen nesneyi günceller
        ///</summary>
        [HttpPost("update")]
        [Authorize()]
        public IActionResult Update(Cozum cozum)
        {
            _cozumService.Update(cozum);

            return Ok(cozum);
        }

        ///<summary>
        ///İd'ye göre gelen çözümü siler
        ///</summary>
        [HttpGet]
        [Route("delete/{id}")]
        [Authorize()]
        public IActionResult Delete(int id)
        {
            
            _cozumService.Delete(id);
            
            return Ok(id);

            
        }
        [HttpPost("getbyhataid")]
        [Authorize()]
        public IActionResult GetListByHataID(int id)
        {
            var data=_cozumService.GetListByHataID(id).ToList();
            return Ok(data);
        }

    }
}