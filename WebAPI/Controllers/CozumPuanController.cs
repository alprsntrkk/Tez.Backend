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
    [Authorize()]
    public class CozumPuanController : ControllerBase
    {
        private ICozumPuanService _cozumPuanService;

        public CozumPuanController(ICozumPuanService cozumPuanService)
        {
            _cozumPuanService = cozumPuanService;
        }
        ///<summary>
        ///Bütün Çözüm Puanlarını Getir
        ///</summary>
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var data = _cozumPuanService.GetList().ToList();
            return Ok(data);
        }

        ///<summary>
        ///İd'ye göre çözüm puanını getirir
        ///</summary>
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetByid(int id)
        {

            var data = _cozumPuanService.GetByid(id);
            return Ok(data);
        }


        ///<summary>
        ///Çözüm puan tipinde gelen nesneyi ekleme işlemi yapar
        ///</summary>
        [HttpPost("")]
        public IActionResult AddCozum(CozumPuan puan)
        {
            _cozumPuanService.Add(puan);

            return Ok(puan);
        }

        ///<summary>
        ///Puanda güncelleme ve silme işlemi yok çünkü yoruma verilen puan silinip güncellenemez.
        ///</summary>


    }
}