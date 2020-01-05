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
    public class IlanController : ControllerBase
    {
        private IilanService _ilanService;

        public IlanController(IilanService ilanService)
        {
            _ilanService = ilanService;
        }
        ///<summary>
        ///Bütün ilanları Getir
        ///</summary>
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var data = _ilanService.GetList().ToList();
            return Ok(data);
        }


        ///<summary>
        ///İd'ye göre ilanı getirir
        ///</summary>
        [HttpGet]
        [Route("{id}")]
        [Authorize()]
        public IActionResult GetByid(int id)
        {

            var data = _ilanService.GetByid(id);
            return Ok(data);
        }


        ///<summary>
        ///İlan tipinde gelen nesneyi ekleme işlemi yapar
        ///</summary>
        [HttpPost("")]
        [Authorize()]
        public IActionResult AddIlan(Ilan ilan)
        {
            _ilanService.Add(ilan);

            return Ok(ilan);
        }

        ///<summary>
        ///İlan tipinde gelen nesneyi günceller
        ///</summary>
        [HttpPost("update")]
        [Authorize()]
        public IActionResult Update(Ilan ilan)
        {
            _ilanService.Update(ilan);

            return Ok(ilan);
        }

        ///<summary>
        ///İd'ye göre gelen ilanı siler
        ///</summary>
        [HttpPost]
        [Route("delete/{id}")]
        [Authorize()]
        public IActionResult Delete(int id)
        {

            _ilanService.Delete(id);

            return Ok(id);


        }

        [HttpPost("getnotyet/{userId}")]
        public IActionResult GetNotYet(int userId)
        {

            var data = _ilanService.GetNotYet(userId).ToList();
            return Ok(data);
        }
    }
}