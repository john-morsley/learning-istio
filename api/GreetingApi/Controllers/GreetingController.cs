﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace GreetingApi.Controllers
{
    [ApiController]
    [Route("v1/greeting")]
    public class GreetingController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return $"Hello, World (from {Environment.MachineName})!";
        }
    }
}