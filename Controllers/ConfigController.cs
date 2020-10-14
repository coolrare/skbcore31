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
        public IConfiguration Configuration { get; }

        public ConfigController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet("")]
        public ActionResult<AppSetting> GetAppSettings()
        {
            return new AppSetting()
            {
                ProjectName = Configuration.GetValue<string>("AppSettings:ProjectName"),
                SmtpIp = Configuration.GetValue<string>("AppSettings:SmtpIp")
            };
        }
    }
}