﻿using System;
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
    public class IlanBasvuruController : ControllerBase
    {
        private IilanBasvuruService _ilanBasvuruService;

        public IlanBasvuruController(IilanBasvuruService ilanBasvuruService)
        {
            _ilanBasvuruService = ilanBasvuruService;
        }
        ///<summary>
        ///Bütün ilan basvurularını Getir
        ///</summary>
        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var data = _ilanBasvuruService.GetList().ToList();
            return Ok(data);
        }


        ///<summary>
        ///İd'ye göre ilan basvurusunu getirir
        ///</summary>
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetByid(int id)
        {

            var data = _ilanBasvuruService.GetByid(id);
            return Ok(data);
        }


        ///<summary>
        ///İlan  basvuru tipinde gelen nesneyi ekleme işlemi yapar
        ///</summary>
        [HttpPost("")]
        public IActionResult AddIlan(IlanBasvuru ilanBasvuru)
        {
            _ilanBasvuruService.Add(ilanBasvuru);

            return Ok(ilanBasvuru);
        }

        ///<summary>
        ///İlan basvuru tipinde gelen nesneyi günceller
        ///</summary>
        [HttpPost("update")]
        public IActionResult Update(IlanBasvuru ilanBasvuru)
        {
            _ilanBasvuruService.Update(ilanBasvuru);

            return Ok(ilanBasvuru);
        }

        ///<summary>
        ///İd'ye göre gelen ilan basvurusnu siler
        ///</summary>
        [HttpPost]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {

            var data=_ilanBasvuruService.Delete(id);

            return Ok(data);


        }
        [HttpPost("getlistbyownerid/{userId}")]
        public IActionResult GetAll(int userId)
        {

            var data = _ilanBasvuruService.GetListByOwnerId(userId).ToList();
            return Ok(data);
        }
        [HttpPost("getunapproved/{userId}")]
        public IActionResult GetUnapproved(int etkinlikId)
        {

            var data = _ilanBasvuruService.GetUnapprovedByIlanId(etkinlikId).ToList();
            return Ok(data);
        }
    }
}