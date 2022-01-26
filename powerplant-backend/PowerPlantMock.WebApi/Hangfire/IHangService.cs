using PowertPlant.WebApi.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static PowerPlantMock.WebApi.Hangfire.HangService;

namespace PowerPlantMock.WebApi.Hangfire
{
    public interface IHangService
    {
        Task<responseModel> updateDataFromWebService();
    }
}
