using Microsoft.AspNetCore.Mvc;
using PowertPlant.WebApi.Entity;
using PowertPlant.WebApi.IService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowertPlant.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly IWebService _webService;

        public ApiController(IWebService webService)
        {
            _webService = webService;
        }

        [HttpGet("get-all")]
        public async Task<List<ElectroMeter>> GetAllAsync()
        {
            return await _webService.getAllElectroMetersAsync();
        }

        

        [HttpPost("save")]
        public async Task createElectroMeterAsync(string name)
        {
          await _webService.insertElectroMeterAsync(name);
        }

        [HttpPost("update")]
        public async Task updateElectroMeterAsync(string name, Guid webid)
        {
            await _webService.updateElectroMeterAsync(name, webid);
        }

        [HttpDelete("delete")]
        public async Task deleteElectroMeterAsync(Guid webid)
        {
            await _webService.deleteElectroMeterAsync(webid);
        }

    }
}
