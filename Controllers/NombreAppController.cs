﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCoder.Modelos;
using WebApiCoder.Repository;

namespace WebApiCoder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NombreAppController : ControllerBase
    {
        [HttpGet("GetNombreApp")]
        public string Get()
        {
            return "WEB-API TEST";
        }

    }
}
