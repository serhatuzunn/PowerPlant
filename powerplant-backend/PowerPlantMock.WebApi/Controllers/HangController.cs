using Microsoft.AspNetCore.Mvc;
using PowerPlantMock.WebApi.Hangfire;
using PowertPlant.WebApi.Entity;
using PowertPlant.WebApi.IService;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PowerPlantMock.WebApi.Controllers
{
    
    public class HangController : Controller
    {
        private readonly IHangService _hangService;

        public HangController(IHangService hangService)
        {
            _hangService = hangService;
        }

        public async Task updateDataByParemeters(string webId,  DateTime startTime, DateTime endTime)
        {
            await _hangService.updateDataFromWebService();
        }

    }
}
