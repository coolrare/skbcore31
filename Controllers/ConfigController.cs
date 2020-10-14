using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api1.Models;
using Microsoft.Extensions.Configuration;

namespace api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        public IAppSetting Config { get; }

        public ConfigController(IAppSetting config)
        {
            Config = config;
        }

        [HttpGet("")]
        public ActionResult<AppSetting> GetAppSettings()
        {
            return Config as AppSetting;
        }
    }
}