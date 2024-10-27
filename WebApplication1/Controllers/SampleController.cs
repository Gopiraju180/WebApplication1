﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        [Route("GetString")]
        public string ListOfData()
        {
            var result = "DotNet Developers";
            return result;
        }
    }
}
