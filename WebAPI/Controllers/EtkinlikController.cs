using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
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
        public IActionResult GetByid(int id)
        {

            var data = _etkinlikService.GetByid(id);
            return Ok(data);
        }


        ///<summary>
        ///Etkinlik tipinde gelen nesneyi ekleme işlemi yapar
        ///</summary>
        [HttpPost("")]
        public IActionResult AddEtkinlik(Etkinlik etkinlik)
        {
            _etkinlikService.Add(etkinlik);

            return Ok(etkinlik);
        }

        ///<summary>
        ///Etnlik tipinde gelen nesneyi günceller
        ///</summary>
        [HttpPost("update")]
        public IActionResult Update(Etkinlik etkinlik)
        {
            _etkinlikService.Update(etkinlik);

            return Ok(etkinlik);
        }

        ///<summary>
        ///İd'ye göre gelen etkinliği siler
        ///</summary>
        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {

            _etkinlikService.Delete(id);

            return Ok(id);


        }
    }
}