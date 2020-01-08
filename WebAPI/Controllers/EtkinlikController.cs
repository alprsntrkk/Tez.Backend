using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtkinlikController : ControllerBase
    {
        private IEtkinlikService _etkinlikService;

        public EtkinlikController(IEtkinlikService etkinlikService)
        {
            _etkinlikService = etkinlikService;
        }
        ///<summary>
        ///Bütün Etkinlikleri Getir
        ///</summary>
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var data = _etkinlikService.GetList().ToList();
            return Ok(data);
        }


        ///<summary>
        ///İd'ye göre etkinliği getirir
        ///</summary>
        [HttpGet]
        [Route("{id}")]
        [Authorize()]
        public IActionResult GetByid(int id)
        {

            var data = _etkinlikService.GetByid(id);
            return Ok(data);
        }


        ///<summary>
        ///Etkinlik tipinde gelen nesneyi ekleme işlemi yapar
        ///</summary>
        [HttpPost("")]
        [Authorize()]
        public IActionResult AddEtkinlik(Etkinlik etkinlik)
        {
            _etkinlikService.Add(etkinlik);

            return Ok(etkinlik);
        }

        ///<summary>
        ///Etnlik tipinde gelen nesneyi günceller
        ///</summary>
        [HttpPost("update")]
        [Authorize()]
        public IActionResult Update(Etkinlik etkinlik)
        {
            _etkinlikService.Update(etkinlik);

            return Ok(etkinlik);
        }

        ///<summary>
        ///İd'ye göre gelen etkinliği siler
        ///</summary>
        [HttpPost]
        [Route("delete/{id}")]
        [Authorize()]
        public IActionResult Delete(int id)
        {

            var data=_etkinlikService.Delete(id);

            return Ok(data);


        }

        [HttpPost("getnotyet/{userId}")]
        public IActionResult GetNotYet(int userId)
        {

            var data = _etkinlikService.GetNotYet(userId).ToList();
            return Ok(data);
        }
        [HttpPost("getbyuserid/{userId}")]
        public IActionResult GetByUserId(int userId)
        {
            var data = _etkinlikService.GetByUserId(userId).ToList();
            return Ok(data);
        }
    }
}