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
    public class EtkinlikKatilimController : ControllerBase
    {
        private IEtkinlikKatilimService _etkinlikKatilimService;

        public EtkinlikKatilimController(IEtkinlikKatilimService etkinlikKatilimService)
        {
            _etkinlikKatilimService = etkinlikKatilimService;
        }
        ///<summary>
        ///Bütün Etkinlikleri Getir
        ///</summary>
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var data = _etkinlikKatilimService.GetList().ToList();
            return Ok(data);
        }


        ///<summary>
        ///İd'ye göre etkinliği getirir
        ///</summary>
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetByid(int id)
        {

            var data = _etkinlikKatilimService.GetByid(id);
            return Ok(data);
        }


        ///<summary>
        ///Etkinlik tipinde gelen nesneyi ekleme işlemi yapar
        ///</summary>
        [HttpPost("")]
        public IActionResult AddEtkinlikKatilim(EtkinlikKatilim etkinlikkatilim)
        {
            _etkinlikKatilimService.Add(etkinlikkatilim);

            return Ok(etkinlikkatilim);
        }

        ///<summary>
        ///Etnlik tipinde gelen nesneyi günceller
        ///</summary>
        [HttpPost("update")]
        public IActionResult Update(EtkinlikKatilim etkinlikkatilim)
        {
            _etkinlikKatilimService.Update(etkinlikkatilim);

            return Ok(etkinlikkatilim);
        }

        ///<summary>
        ///İd'ye göre gelen etkinliği siler
        ///</summary>
        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {

            _etkinlikKatilimService.Delete(id);

            return Ok(id);


        }
        [HttpPost("getlistbyownerid")]
        public IActionResult GetAll(int userId)
        {

            var data = _etkinlikKatilimService.GetListByOwnerId(userId).ToList();
            return Ok(data);
        }
    }
}