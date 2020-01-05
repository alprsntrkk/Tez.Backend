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
    public class HataController : ControllerBase
    {
        private IHataService _hataService;

        public HataController(IHataService hataService)
        {
            _hataService = hataService;
        }
        ///<summary>
        ///Bütün Hataları Getir
        ///</summary>
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var data = _hataService.GetList().ToList();
            return Ok(data);
        }


        ///<summary>
        ///İd'ye göre hatayı getirir
        ///</summary>
        [HttpGet]
        [Route("{id}")]
        [Authorize()]
        public IActionResult GetByid(int id)
        {

            var data = _hataService.GetByid(id);
            return Ok(data);
        }


        ///<summary>
        ///Hata tipinde gelen nesneyi ekleme işlemi yapar
        ///</summary>
        [HttpPost("")]
        [Authorize()]
        public IActionResult AddCozum(Hata hata)
        {
            _hataService.Add(hata);

            return Ok(hata);
        }

        ///<summary>
        ///Hata tipinde gelen nesneyi günceller
        ///</summary>
        [HttpPost("update")]
        [Authorize()]
        public IActionResult Update(Hata hata)
        {
            _hataService.Update(hata);

            return Ok(hata);
        }

        ///<summary>
        ///İd'ye göre gelen hatayı siler
        ///</summary>
        [HttpPost]
        [Route("delete/{id}")]
        [Authorize()]
        public IActionResult Delete(int id)
        {

            _hataService.Delete(id);

            return Ok(id);


        }
    }
}