using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api1.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace api1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        public AppSetting Options { get; }

        public ConfigController(IOptions<AppSetting> options)
        {
            Options = options.Value;
        }

        [HttpGet("")]
        public ActionResult<AppSetting> GetAppSettings()
        {
            return Options;
        }
    }
}