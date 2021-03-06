﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }


        [HttpPost("login")]
        public ActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _authService.Login(userForLoginDto);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }
            var result = _authService.CreateAccessToken(userToLogin.Data);
            if (result.Success)
            {
                UserInfo userInfo = new UserInfo();
                userInfo.accesToken = result.Data;
                userInfo.userInfo = userToLogin.Data;
                return Ok(userInfo);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("register")]
        public ActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExists = _authService.UserExists(userForRegisterDto.Email);
            if (!userExists.Success)
            {
                return BadRequest(userExists.Message);
            }
            if (userForRegisterDto.Email == "" || userForRegisterDto.Password == "" || userForRegisterDto.FirstName=="" || userForRegisterDto.LastName == "" || userForRegisterDto.telefonNo == "")
            {
                return BadRequest("Alanlar boş geçilemez.");
            }
            var registerResult = _authService.Register(userForRegisterDto, userForRegisterDto.Password);
            var result = _authService.CreateAccessToken(registerResult.Data);
            if (result.Success)
            {
                UserInfo userInfo = new UserInfo();
                userInfo.accesToken = result.Data;
                userInfo.userInfo = registerResult.Data;
                return Ok(userInfo);
            }
            return BadRequest(result.Message);
        }
    }
}